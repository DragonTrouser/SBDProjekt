using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using WinFormsApp.Forms.Sales;

namespace WinFormsApp.Forms;

public partial class SalesForm : Form
{
    private readonly SqlConnection _connection;

    public SalesForm(SqlConnection connection)
    {
        InitializeComponent();
        _connection = connection;
    }

    private void Reload()
    {
        DateTimePickerFrom.Value = DateTime.Now;

        ComboBoxLastName.Items.Clear();
        ComboBoxLastName.Items.Add("");
        {
            using var cmd = new SqlCommand("dbo.uspGetPeopleLastNames", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxLastName.Items.Add($"{reader["PersonLastName"]}");
            }
        }
        ComboBoxLastName.SelectedIndex = 0;

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

    private void ReloadOrders()
    {
        DateTime orderDateFrom = DateTimePickerFrom.Value;
        DateTime orderDateTo = DateTimePickerTo.Value;

        string categoryName = ComboBoxCategories.Text;
        string subcategoryName = ComboBoxSubcategories.Text;
        string productName = ComboBoxProducts.Text;

        string? personLastName = ComboBoxLastName.Text.IsNullOrEmpty() ? null : ComboBoxLastName.Text;
        string? personFirstName = ComboBoxFirstName.Text.IsNullOrEmpty() ? null : ComboBoxFirstName.Text;

        ListBoxOrders.Items.Clear();
        {
            using var cmd = new SqlCommand("dbo.uspGetOrders", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderDateFrom", orderDateFrom);
            cmd.Parameters.AddWithValue("@OrderDateTo", orderDateTo);
            cmd.Parameters.AddWithValue("@ProductCategoryName", categoryName);
            cmd.Parameters.AddWithValue("@ProductSubcategoryName", subcategoryName);
            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@PersonLastName", personLastName);
            cmd.Parameters.AddWithValue("@PersonFirstName", personFirstName);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListBoxOrders.Items.Add($"{reader["OrderNumber"]} --- {reader["PurchaseOrderNumber"]} --- {reader["OrderDate"]}");
            }
        }
    }

    private void SalesAnalyticsForm_Load(object sender, EventArgs e)
    {
        Reload();
    }

    private void DateTimePickerFrom_ValueChanged(object sender, EventArgs e)
    {
        if (DateTimePickerTo.Value < DateTimePickerFrom.Value)
        {
            DateTimePickerTo.Value = DateTimePickerFrom.Value;
        }
        else
        {
            ReloadOrders();
        }
    }

    private void DateTimePickerTo_ValueChanged(object sender, EventArgs e)
    {
        ReloadOrders();
    }

    private void ComboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        string categoryName = ComboBoxCategories.Text;
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
        ComboBoxProducts.Items.Clear();
        ComboBoxProducts.Items.Add("All");
        {
            using var cmd = new SqlCommand("uspGetProductsBySubcategoryName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubcategoryName", subcategoryName);
            cmd.Parameters.AddWithValue("@CategoryName", categoryName);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxProducts.Items.Add($"{reader["ProductName"]}");
            }
        }
        ComboBoxProducts.SelectedIndex = 0;
    }

    private void ComboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReloadOrders();
    }

    private void ComboBoxLastName_SelectedIndexChanged(object sender, EventArgs e)
    {
        string lastName = ComboBoxLastName.Text;
        ComboBoxFirstName.Items.Clear();
        {
            using var cmd = new SqlCommand("dbo.uspGetPeopleFirstNamesByLastName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LastName", lastName);
            using var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                ComboBoxFirstName.Items.Add("");
                ComboBoxFirstName.Enabled = false;
            }
            else while (reader.Read())
            {
                ComboBoxFirstName.Items.Add($"{reader["PersonFirstName"]}");
                ComboBoxFirstName.Enabled = true;
            }
        }
        ComboBoxFirstName.SelectedIndex = 0;
    }

    private void ComboBoxFirstName_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReloadOrders();
    }

    private void ListBoxOrders_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        string orderNumber = ListBoxOrders.Text.Split("---")[0].Trim();
        var form = new OrderDetailsForm(_connection, orderNumber);
        form.Show();
        form.FormClosed += delegate
        {
            ReloadOrders();
            Show();
        };
        Hide();
    }

    private void ButtonNewOrder_Click(object sender, EventArgs e)
    {
        /*
        var form = new OrderCreateForm(_connection);
        form.Show();
        form.FormClosed += delegate
        {
            ReloadOrders();
            Show();
        };
        Hide();
        */
    }

    private void ButtonGoBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}
