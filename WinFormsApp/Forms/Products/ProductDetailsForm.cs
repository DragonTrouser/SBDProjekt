using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp.Forms.Products;

public partial class ProductDetailsForm : Form
{
    private readonly SqlConnection _connection;
    private readonly string _name;

    public ProductDetailsForm(SqlConnection connection, string name)
    {
        InitializeComponent();
        _connection = connection;
        _name = name;
    }

    private void ProductDetailsForm_Load(object sender, EventArgs e)
    {
        using var cmd = new SqlCommand("dbo.uspGetProductByName", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ProductName", _name);
        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            TextBoxName.Text = $"{reader["ProductName"]}";
            TextBoxProductNumber.Text = $"{reader["ProductNumber"]}";
            TextBoxColor.Text = $"{reader["ProductColor"]}";
            TextBoxCategory.Text = $"{reader["CategoryName"]}";
            TextBoxSubcategory.Text = $"{reader["SubcategoryName"]}";
            TextBoxSafetyStockLevel.Text = $"{reader["ProductSafetyStockLevel"]}";
            TextBoxReorderPoint.Text = $"{reader["ProductReorderPoint"]}";
            TextBoxStandardCost.Text = $"{reader["ProductStandardCost"]}";
            TextBoxListPrice.Text = $"{reader["ProductListPrice"]}";
            TextBoxWeight.Text = $"{reader["ProductWeight"]}";
            TextBoxWeightUnit.Text = $"{reader["ProductWeightUnit"]}";
            TextBoxSize.Text = $"{reader["ProductSize"]}";
            TextBoxSizeUnit.Text = $"{reader["ProductSizeUnit"]}";
            DateTimePickerSellStartDate.Text = $"{reader["ProductSellStartDate"]}";
        }
    }

    private void ButtonOK_Click(object sender, EventArgs e)
    {
        Close();
    }
}
