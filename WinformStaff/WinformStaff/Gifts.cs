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
    public partial class Gifts : Form
    {
        public Gifts()
        {
            InitializeComponent();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }


        private void Gift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Gifts (Name, Description, Price) VALUES (@Name, @Description, @Price)", conn);
                cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Description", DescriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@Price", int.Parse(PriceTextBox.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Gift added successfully.");
                    RefreshGrid(); // Update grid after adding
                }
                else
                {
                    MessageBox.Show("Failed to add gift.");
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            // Assuming you have selected the row to delete in the DataGridView
            if (GiftGrid.SelectedRows.Count > 0)
            {
                int selectedGiftID = Convert.ToInt32(GiftGrid.SelectedRows[0].Cells["Id"].Value);

                string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Gifts WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", selectedGiftID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Gift removed successfully.");
                        RefreshGrid(); // Update grid after deleting
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove gift.");
                    }
                }
            }
        }

        private void RefreshGrid()
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Gifts", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GiftGrid.DataSource = dt;
            }
        }

        private void Gifts_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            ChoosingOptions choosingOptions = new ChoosingOptions();
            choosingOptions.Show();
            this.Hide();
        }
    }
}
