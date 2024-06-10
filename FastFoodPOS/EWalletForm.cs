using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace FastFoodPOS
{
    public partial class EWalletForm : Form
    {
        private List<FoodItem> selectedItems;
        private decimal totalAmount;
        private int orderId;

        public EWalletForm(List<FoodItem> selectedItems, int orderId, decimal totalAmount)
        {
            InitializeComponent();
            this.selectedItems = selectedItems;
            this.orderId = orderId;
            this.totalAmount = totalAmount;
        }

        private void buttonBankingQR_Click(object sender, EventArgs e)
        {
            SimulateEWalletPayment("Banking QR");
        }

        private void buttonCreditCard_Click(object sender, EventArgs e)
        {
            SimulateEWalletPayment("Credit Card");
        }

        private void buttonVNPay_Click(object sender, EventArgs e)
        {
            SimulateEWalletPayment("VNPay");
        }

        private void buttonPayPal_Click(object sender, EventArgs e)
        {
            SimulateEWalletPayment("PayPal");
        }

        private void SimulateEWalletPayment(string paymentMethod)
        {
            // Simulate the e-wallet payment process
            MessageBox.Show($"Simulating {paymentMethod} payment...");

            ProcessPayment(paymentMethod);
        }

        private void ProcessPayment(string paymentMethod)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FastFoodDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertPaymentQuery = "INSERT INTO Payments (OrderId, PaymentMethod, PaymentDate, Amount) VALUES (@OrderId, @PaymentMethod, @PaymentDate, @Amount)";
                using (SqlCommand cmd = new SqlCommand(insertPaymentQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Amount", totalAmount);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Payment processed successfully!");
            this.Close();
            StartForm startForm = new StartForm();
            startForm.Show();

            this.Close();

        }
    }
}
