using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformStaff
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            PopulateSizeComboBox();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Food (Name, Description, Price, Category, Size) VALUES (@Name, @Description, @Price, @Category, @Size)", conn);
                cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Description", Description.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(Price.Text));
                cmd.Parameters.AddWithValue("@Category", Category.Text);
                cmd.Parameters.AddWithValue("@Size", Size.SelectedItem.ToString());

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record added successfully.");
                    RefreshGrid(); // Update grid after adding
                }
                else
                {
                    MessageBox.Show("Failed to add record.");
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (FoodGrid.SelectedRows.Count > 0)
            {
                int selectedFoodID = Convert.ToInt32(FoodGrid.SelectedRows[0].Cells["FoodId"].Value);

                string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Food WHERE FoodId = @FoodId", conn);
                    cmd.Parameters.AddWithValue("@FoodId", selectedFoodID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        RefreshGrid(); // Update grid after deleting
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.");
                    }
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)FoodGrid.DataSource;

            if (dt != null && dt.Rows.Count > 0)
            {
                string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand clearCmd = new SqlCommand("TRUNCATE TABLE Food", conn);
                    clearCmd.ExecuteNonQuery();

                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        bulkCopy.DestinationTableName = "Food";

                        foreach (DataColumn column in dt.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                        }

                        bulkCopy.WriteToServer(dt);
                    }

                    MessageBox.Show("Table updated successfully.");
                    RefreshGrid(); // Update grid after updating
                }
            }
            else
            {
                MessageBox.Show("No data to update.");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            Description.Text = "";
            Price.Text = "";
            Category.Text = "";
            Size.SelectedIndex = -1; // Clear selection
        }

        private void RefreshGrid()
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Food", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                FoodGrid.DataSource = dt;
            }
        }

        private void PopulateSizeComboBox()
        {
            // Add predefined size options to the SizeComboBox
            Size.Items.AddRange(new object[] { "Small", "Medium", "Large" });
        }

        private void FoodGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click events here if necessary
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed events for NameTextBox here if necessary
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed events for DescriptionTextBox here if necessary
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed events for PriceTextBox here if necessary
        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed events for CategoryTextBox here if necessary
        }

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle size selection changes here if necessary
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            ChoosingOptions choosingOptions = new ChoosingOptions();

            choosingOptions.Show();

            this.Hide();
        }
    }
}
