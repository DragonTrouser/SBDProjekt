using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp.Forms.Products;

namespace WinFormsApp.Forms;

public partial class ProductsForm : Form
{
    private readonly SqlConnection _connection;

    public ProductsForm(SqlConnection connection)
    {
        InitializeComponent();
        _connection = connection;
    }

    private void Reload()
    {
        ComboBoxCategories.Items.Clear();
        ComboBoxCategories.Items.Add("All");
        {
            using var cmd = new SqlCommand("dbo.uspGetCategories", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxCategories.Items.Add($"{reader["CategoryName"]}");
            }
        }
        ComboBoxCategories.SelectedIndex = 0;
    }

    private void ProductsForm_Load(object sender, EventArgs e)
    {
        Reload();
    }

    private void ComboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        string categoryName = ComboBoxCategories.SelectedItem!.ToString()!;
        ComboBoxSubcategories.Items.Clear();
        ComboBoxSubcategories.Items.Add("All");
        {
            using var cmd = new SqlCommand("dbo.uspGetSubcategoriesByCategoryName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName", categoryName);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxSubcategories.Items.Add($"{reader["SubcategoryName"]}");
            }
        }
        ComboBoxSubcategories.SelectedIndex = 0;
    }

    private void ComboBoxSubcategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        string subcategoryName = ComboBoxSubcategories.Text;
        string categoryName = ComboBoxCategories.Text;
        ListBoxProducts.Items.Clear();
        {
            using var cmd = new SqlCommand("dbo.uspGetProductsBySubcategoryName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubcategoryName", subcategoryName);
            cmd.Parameters.AddWithValue("@CategoryName", categoryName);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListBoxProducts.Items.Add($"{reader["ProductNumber"]} --- {reader["ProductName"]}");
            }
        }
    }

    private void ListBoxProducts_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (ListBoxProducts.SelectedItem is null) return;
        string productName = ListBoxProducts.SelectedItem.ToString()!.Split("---")[1].Trim();
        var form = new ProductDetailsForm(_connection, productName);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void ButtonNewProduct_Click(object sender, EventArgs e)
    {
        var form = new ProductCreateForm(_connection);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void ButtonGoBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}
