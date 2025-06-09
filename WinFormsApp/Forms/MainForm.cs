using Microsoft.Data.SqlClient;

namespace WinFormsApp.Forms;

public partial class MainForm : Form
{
    public readonly SqlConnection connection;

    public MainForm()
    {
        InitializeComponent();
        connection = new(Program.CONN_STR);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        connection.Open();
    }

    private void MainForm_FormClosed(object sender, EventArgs e)
    {
        connection.Close();
    }

    private void ButtonSales_Click(object sender, EventArgs e)
    {
        var orders = new SalesForm(connection);
        orders.Show();
        orders.FormClosing += delegate
        {
            Show();
        };
        Hide();
    }

    private void ButtonProducts_Click(object sender, EventArgs e)
    {
        var orders = new ProductsForm(connection);
        orders.Show();
        orders.FormClosing += delegate
        {
            Show();
        };
        Hide();
    }

    private void ButtonCategories_Click(object sender, EventArgs e)
    {
        var orders = new CategoriesForm(connection);
        orders.Show();
        orders.FormClosing += delegate
        {
            Show();
        };
        Hide();
    }

    private void ButtonExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
