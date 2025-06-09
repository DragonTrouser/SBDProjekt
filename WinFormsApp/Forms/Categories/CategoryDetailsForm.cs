using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp.Forms.Categories;

public partial class CategoryDetailsForm : Form
{
    private readonly SqlConnection _connection;
    private readonly string _categoryName;

    public CategoryDetailsForm(SqlConnection connection, string categoryName)
    {
        InitializeComponent();
        _connection = connection;
        _categoryName = categoryName;
    }

    private void EditCategoryForm_Load(object sender, EventArgs e)
    {
        using var cmd = new SqlCommand("dbo.uspGetCategoryByName", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CategoryName", _categoryName);
        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            TextBoxID.Text = reader["CategoryID"].ToString();
            TextBoxName.Text = reader["CategoryName"].ToString();
        }
    }

    private void ButtonUpdate_Click(object sender, EventArgs e)
    {
        int id = int.Parse(TextBoxID.Text);
        string newName = TextBoxName.Text;

        using var cmd = new SqlCommand("dbo.uspUpdateCategory", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CategoryID", id);
        cmd.Parameters.AddWithValue("@NewName", newName);
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

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        int id = int.Parse(TextBoxID.Text);

        using var cmd = new SqlCommand("dbo.uspDeleteCategory", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CategoryID", id);
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
