using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinformStaff
{
    public partial class Vouchers : Form
    {
        public Vouchers()
        {
            InitializeComponent();
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text change event
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text change event
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if the voucher code already exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Vouchers WHERE VoucherCode = @VoucherCode", conn);
                checkCmd.Parameters.AddWithValue("@VoucherCode", Code.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Voucher code already exists. Please enter a unique code.");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Vouchers (VoucherCode, Valuess, Description, MinimumPurchaseAmount) VALUES (@VoucherCode, @Valuess, @Description, @MinimumPurchaseAmount)", conn);
                    cmd.Parameters.AddWithValue("@VoucherCode", Code.Text);
                    cmd.Parameters.AddWithValue("@Valuess", int.Parse(Value.Text));
                    cmd.Parameters.AddWithValue("@Description", Description.Text);
                    cmd.Parameters.AddWithValue("@MinimumPurchaseAmount", decimal.Parse(MinimumVal.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Voucher added successfully.");
                        RefreshGrid(); // Update grid after adding
                    }
                    else
                    {
                        MessageBox.Show("Failed to add voucher.");
                    }
                }
            }
        }


        private void Remove_Click(object sender, EventArgs e)
        {
            if (Voucher.SelectedRows.Count > 0)
            {
                int selectedVoucherID = Convert.ToInt32(Voucher.SelectedRows[0].Cells["VoucherId"].Value);

                string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Vouchers WHERE VoucherId = @VoucherId", conn);
                    cmd.Parameters.AddWithValue("@VoucherId", selectedVoucherID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Voucher removed successfully.");
                        RefreshGrid(); // Update grid after deleting
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove voucher.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a voucher to remove.");
            }
        }

        private void RefreshGrid()
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT VoucherId, VoucherCode, Valuess, Description, MinimumPurchaseAmount FROM Vouchers", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Voucher.DataSource = dt;
            }
        }

        private void Voucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell content click event
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChoosingOptions choosingOptions = new ChoosingOptions();
            choosingOptions.Show();
            this.Hide();
        }

        private void Vouchers_Load_1(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinimumVal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
