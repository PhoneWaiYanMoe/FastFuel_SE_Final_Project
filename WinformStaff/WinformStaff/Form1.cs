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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO agents (Name, Email, Password, Location, CreationDate, Description) VALUES (@Name, @Email, @Password, @Location, @CreationDate, @Description)", conn);
                cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                cmd.Parameters.AddWithValue("@Location", Location.Text);
                cmd.Parameters.AddWithValue("@CreationDate", CreationDate.Value);
                cmd.Parameters.AddWithValue("@Description", Description.Text);

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

        private void Remove_Click_1(object sender, EventArgs e)
        {
            // Assuming you have selected the row to delete in the DataGridView
            if (AgentsGrid.SelectedRows.Count > 0)
            {
                int selectedAgentID = Convert.ToInt32(AgentsGrid.SelectedRows[0].Cells["Id"].Value); // Updated column name

                string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM agents WHERE Id = @Id", conn); // Updated column name
                    cmd.Parameters.AddWithValue("@Id", selectedAgentID); // Updated parameter name

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



        private void Update_Click_1(object sender, EventArgs e)
        {
            // Get the data from the DataGridView
            DataTable dt = (DataTable)AgentsGrid.DataSource;

            // Ensure the DataTable is not null and contains data
            if (dt != null && dt.Rows.Count > 0)
            {
                string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Clear the existing data in the database table
                    SqlCommand clearCmd = new SqlCommand("TRUNCATE TABLE agents", conn);
                    clearCmd.ExecuteNonQuery();

                    // Insert the new data into the database table
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        bulkCopy.DestinationTableName = "agents"; // Table name in the database

                        // Map the DataTable columns with the database table columns
                        foreach (DataColumn column in dt.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                        }

                        // Write the data from the DataTable to the database
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



        private void Clear_Click_1(object sender, EventArgs e)
        {
            // Clear input fields
            NameTextBox.Text = "";
            Email.Text = "";
            Password.Text = "";
            Location.Text = "";
            CreationDate.Value = DateTime.Now;
            Description.Text = "";
        }

        private void RefreshGrid()
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM agents", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AgentsGrid.DataSource = dt;
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Location_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreationDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            ChoosingOptions choosingOptions = new ChoosingOptions();

            choosingOptions.Show();

            this.Hide();
        }
    }
}
