using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace WinFormsApp.Forms.Products;

public partial class ProductCreateForm : Form
{
    private readonly SqlConnection _connection;

    public ProductCreateForm(SqlConnection connection)
    {
        InitializeComponent();
        _connection = connection;
    }

    private void ProductCreateForm_Load(object sender, EventArgs e)
    {
        ComboBoxCategories.Items.Clear();
        {
            using var cmd = new SqlCommand("dbo.uspGetCategories", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxCategories.Items.Add($"{reader["CategoryName"]}");
            }
        }
        ComboBoxCategories.SelectedItem = ComboBoxCategories.Items[0];

        ComboBoxSizeUnit.Items.Clear();
        {
            using var cmd = new SqlCommand("dbo.uspGetSizeUnitMeasureCodes", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxSizeUnit.Items.Add($"{reader["SizeUnitMeasureCode"]}");
            }
        }
        ComboBoxSizeUnit.SelectedItem = ComboBoxSizeUnit.Items[0];

        ComboBoxWeightUnit.Items.Clear();
        {
            using var cmd = new SqlCommand("dbo.uspGetWeightUnitMeasureCodes", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxWeightUnit.Items.Add($"{reader["WeightUnitMeasureCode"]}");
            }
        }
        ComboBoxWeightUnit.SelectedItem = ComboBoxWeightUnit.Items[0];
    }

    private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        ComboBoxSubcategories.Items.Clear();
        {
            using var cmd = new SqlCommand("dbo.uspGetSubcategoriesByCategoryName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName", ComboBoxCategories.SelectedItem);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxSubcategories.Items.Add($"{reader["SubcategoryName"]}");
            }
        }
        ComboBoxSubcategories.SelectedItem = ComboBoxSubcategories.Items[0];
    }

    private void ButtonCreate_Click(object sender, EventArgs e)
    {
        string categoryName = ComboBoxCategories.Text;
        int? categoryId = null;
        {
            using var cmd = new SqlCommand("dbo.uspGetCategoryByName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName", categoryName);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                categoryId = int.Parse($"{reader["CategoryID"]}");
            }
        }

        string subcategoryName = ComboBoxSubcategories.Text;
        int? subcategoryId = null;
        {
            using var cmd = new SqlCommand("dbo.uspGetSubcategoryByName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubcategoryName", subcategoryName);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                subcategoryId = int.Parse($"{reader["SubcategoryID"]}");
            }
        }

        string? name = TextBoxName.Text.IsNullOrEmpty() ? null : TextBoxName.Text;
        string? productNumber = TextBoxProductNumber.Text.IsNullOrEmpty() ? null : TextBoxProductNumber.Text;
        string? color = TextBoxColor.Text.IsNullOrEmpty() ? null : TextBoxColor.Text;

        short safetyStockLevel = (short)NumericSafetyStockLevel.Value;
        short reorderPoint = (short)NumericReorderPoint.Value;

        decimal standardCost = NumericStandardCost.Value;
        decimal listPrice = NumericListPrice.Value;

        decimal? weight = NumericWeight.Value == 0 ? null : NumericWeight.Value;
        string? weightUnit = ComboBoxWeightUnit.Text.IsNullOrEmpty() ? null : ComboBoxWeightUnit.Text;

        string? size = TextBoxSize.Text.IsNullOrEmpty() ? null : TextBoxSize.Text;
        string? sizeUnit = ComboBoxSizeUnit.Text.IsNullOrEmpty() ? null : ComboBoxSizeUnit.Text;

        DateTime sellStartDate = DateTimePickerSellStartDate.Value;

        {
            using var cmd = new SqlCommand("dbo.uspCreateProduct", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@ProductNumber", productNumber);
            cmd.Parameters.AddWithValue("@CategoryID", categoryId);
            cmd.Parameters.AddWithValue("@SubcategoryID", subcategoryId);
            cmd.Parameters.AddWithValue("@Color", color);
            cmd.Parameters.AddWithValue("@SafetyStockLevel", safetyStockLevel);
            cmd.Parameters.AddWithValue("@ReorderPoint", reorderPoint);
            cmd.Parameters.AddWithValue("@StandardCost", standardCost);
            cmd.Parameters.AddWithValue("@ListPrice", listPrice);
            cmd.Parameters.AddWithValue("@Weight", weight);
            cmd.Parameters.AddWithValue("@WeightUnit", weightUnit);
            cmd.Parameters.AddWithValue("@Size", size);
            cmd.Parameters.AddWithValue("@SizeUnit", sizeUnit);
            cmd.Parameters.AddWithValue("@SellStartDate", sellStartDate);
            try
            {
                cmd.ExecuteNonQuery();
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
