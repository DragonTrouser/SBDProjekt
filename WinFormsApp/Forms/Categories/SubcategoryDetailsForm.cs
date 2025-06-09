using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp.Forms.Categories;

public partial class SubcategoryDetailsForm : Form
{
    private readonly SqlConnection _connection;
    private readonly string _subcategoryName;

    public SubcategoryDetailsForm(SqlConnection connection, string subcategoryName)
    {
        InitializeComponent();
        _connection = connection;
        _subcategoryName = subcategoryName;
    }

    private void EditSubcategoryForm_Load(object sender, EventArgs e)
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

        {
            using var cmd = new SqlCommand("dbo.uspGetSubcategoryByName", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubcategoryName", _subcategoryName);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TextBoxID.Text = reader["SubcategoryID"].ToString();
                ComboBoxCategories.SelectedItem = reader["CategoryName"];
            }
        }

        TextBoxName.Text = _subcategoryName;
    }

    private void ButtonUpdate_Click(object sender, EventArgs e)
    {
        int id = int.Parse(TextBoxID.Text);
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
            using var cmd = new SqlCommand("dbo.uspUpdateSubcategory", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubcategoryID", id);
            cmd.Parameters.AddWithValue("@NewCategoryID", selectedCategoryId);
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
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        int id = int.Parse(TextBoxID.Text);

        using var cmd = new SqlCommand("dbo.uspDeleteSubcategory", _connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@SubcategoryID", id);
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

    private void Cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
