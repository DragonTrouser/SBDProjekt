using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp.Forms.Categories;

namespace WinFormsApp.Forms;

public partial class CategoriesForm : Form
{
    private readonly SqlConnection _connection;

    public CategoriesForm(SqlConnection connection)
    {
        InitializeComponent();
        _connection = connection;
    }

    private void Reload()
    {
        ListBoxCategories.Items.Clear();
        ListBoxCategories.Items.Add("All");
        ListBoxCategories.SelectedItem = ListBoxCategories.Items[0];
        using var cmd = new SqlCommand("dbo.uspGetCategories", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            ListBoxCategories.Items.Add($"{reader["CategoryName"]}");
        }
    }

    private void CategoriesForm_Load(object sender, EventArgs e)
    {
        Reload();
    }

    private void ListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        var categoryName = ListBoxCategories.SelectedItem!.ToString();
        ListBoxSubcategories.Items.Clear();

        using var cmd = new SqlCommand("dbo.uspGetSubcategoriesByCategoryName", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CategoryName", categoryName);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            ListBoxSubcategories.Items.Add($"{reader["SubcategoryName"]}");
        }
    }

    private void ListBoxCategories_MouseDoubleClick(object sender, EventArgs e)
    {
        if (ListBoxCategories.SelectedItem is null) return;
        string categoryName = ListBoxCategories.SelectedItem.ToString()!;
        if (categoryName == "All") return;
        var form = new CategoryDetailsForm(_connection, categoryName);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void ListBoxSubcategories_MouseDoubleClick(object sender, EventArgs e)
    {
        if (ListBoxSubcategories.SelectedItem is null) return;
        string subcategoryName = ListBoxSubcategories.SelectedItem.ToString()!;
        var form = new SubcategoryDetailsForm(_connection, subcategoryName);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void ButtonNewCategory_Click(object sender, EventArgs e)
    {
        var form = new CategoryCreateForm(_connection);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void ButtonNewSubcategory_Click(object sender, EventArgs e)
    {
        if (ListBoxCategories.SelectedItem is null) return;
        string categoryName = ListBoxCategories.SelectedItem.ToString()!;
        var form = new SubcategoryCreateForm(_connection, categoryName);
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
