using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp.Forms.Categories;

public partial class CategoryCreateForm : Form
{
    private readonly SqlConnection _connection;

    public CategoryCreateForm(SqlConnection connection)
    {
        InitializeComponent();
        _connection = connection;
    }

    private void ButtonCreate_Click(object sender, EventArgs e)
    {
        string name = TextBoxName.Text;

        using var cmd = new SqlCommand("dbo.uspCreateCategory", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Name", name);
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

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
