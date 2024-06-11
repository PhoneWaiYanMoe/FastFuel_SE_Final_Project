using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinformStaff
{
    public partial class StaffsLoginForm : Form
    {
        public StaffsLoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string password = Password.Text;
            if (AuthenticateUser(email, password))
            {
                MessageBox.Show("Login successful!");

                // Create an instance of the ManageOrders form
                ChoosingOptions choosingOptions  = new ChoosingOptions();

                // Show the ManageOrders form
                choosingOptions.Show();

                // Hide the current form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            bool isAuthenticated = false;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FastFoodDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Staffs WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    isAuthenticated = true;
                }
            }

            return isAuthenticated;
        }

        private void StaffsLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
