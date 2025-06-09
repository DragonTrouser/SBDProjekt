using Microsoft.Data.SqlClient;

namespace WinFormsApp.Forms.Sales;

public partial class OrderCreateFormUnfinished : Form
{
    private readonly SqlConnection _connection;

    public OrderCreateFormUnfinished(SqlConnection connection)
    {
        InitializeComponent();
        _connection = connection;
    }
}
