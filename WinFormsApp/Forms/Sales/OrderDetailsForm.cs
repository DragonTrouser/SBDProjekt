using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp.Forms.Sales;

public partial class OrderDetailsForm : Form
{
    private readonly SqlConnection _connection;
    private readonly string _orderNumber;

    public OrderDetailsForm(SqlConnection connection, string orderNumber)
    {
        InitializeComponent();
        _connection = connection;
        _orderNumber = orderNumber;
    }

    private void OrderDetailsForm_Load(object sender, EventArgs e)
    {
        {
            using var cmd = new SqlCommand("dbo.uspGetOrderDetails", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderNumber", _orderNumber);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TextBoxOrderNumber.Text = $"{reader["OrderNumber"]}";
                DateTimeOderDate.Value = (DateTime)reader["OrderDate"];
                DateTimeDueDate.Value = (DateTime)reader["DueDate"];
                CheckBoxOnlineOrder.Checked = (bool)reader["OnlineOrderFlag"];
                TextBoxPurchaseNumber.Text = $"{reader["PurchaseNumber"]}";
                TextBoxCustomerName.Text = $"{reader["CustomerName"]}";

                TextBoxBillingAddress.Text = $"{reader["BillingAddress"]}";
                TextBoxBillingAddressL2.Text = $"{reader["BillingAddressL2"]}";
                TextBoxBillingCity.Text = $"{reader["BillingCityName"]}";
                TextBoxBillingState.Text = $"{reader["BillingStateName"]}";
                TextBoxBillingCountry.Text = $"{reader["BillingCountryName"]}";

                TextBoxShippingAddress.Text = $"{reader["ShippingAddress"]}";
                TextBoxShippingAddressL2.Text = $"{reader["ShippingAddressL2"]}";
                TextBoxShippingCity.Text = $"{reader["ShippingCityName"]}";
                TextBoxShippingState.Text = $"{reader["ShippingStateName"]}";
                TextBoxShippingCountry.Text = $"{reader["ShippingCountryName"]}";

                TextBoxTotal.Text = $"{reader["TotalDue"]}";
            }
        }
        ListBoxOrderedProducts.Items.Clear();
        {
            using var cmd = new SqlCommand("dbo.uspGetProductsInOrder", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderNumber", _orderNumber);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListBoxOrderedProducts.Items.Add($"{reader["Quantity"]}x {reader["ProductName"]} (total: {reader["LineTotal"]})");
            }
        }
    }

    private void ButtonOK_Click(object sender, EventArgs e)
    {
        Close();
    }
}
