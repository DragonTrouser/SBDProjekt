using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp.Forms.Categories;

public partial class SubcategoryCreateForm : Form
{
    private readonly SqlConnection _connection;
    private readonly string _categoryName;

    public SubcategoryCreateForm(SqlConnection connection, string categoryName)
    {
        InitializeComponent();
        _connection = connection;
        _categoryName = categoryName;
    }

    private void SubcategoryCreateForm_Load(object sender, EventArgs e)
    {
        ComboBoxCategories.Items.Clear();

        using var cmd = new SqlCommand("dbo.uspGetCategories", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            ComboBoxCategories.Items.Add($"{reader["CategoryName"]}");
        }

        ComboBoxCategories.SelectedItem = _categoryName != "All" ? _categoryName : ComboBoxCategories.Items[0];
    }

    private void ButtonCreate_Click(object sender, EventArgs e)
    {
        string newName = TextBoxName.Text.Trim();
        string selectedCategoryName = ComboBoxCategories.SelectedItem!.ToString()!;
        int selectedCategoryId = -1;
        {
            using var cmd = new SqlCommand("dbo.uspGetCategoryByName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName", selectedCategoryName);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                selectedCategoryId = Convert.ToInt32(reader["CategoryID"]);
            }
        }

        if (selectedCategoryId != -1)
        {
            using var cmd = new SqlCommand("dbo.uspCreateSubcategory", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryID", selectedCategoryId);
            cmd.Parameters.AddWithValue("@Name", newName);
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

    private void Cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
