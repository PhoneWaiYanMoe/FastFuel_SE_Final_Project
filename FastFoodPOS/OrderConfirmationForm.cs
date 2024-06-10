using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration; // Add this using directive

namespace FastFoodPOS
{
    public partial class OrderConfirmationForm : Form
    {
        private List<FoodItem> selectedItems;

        public OrderConfirmationForm(List<FoodItem> selectedItems)
        {
            InitializeComponent();
            this.selectedItems = selectedItems ?? new List<FoodItem>(); // Ensure selectedItems is not null
            LoadOrderDetails();
            CalculateTotalPrice();
        }

        private void LoadOrderDetails()
        {
            // Ensure the DataGridView has columns before adding rows
            if (dataGridViewOrderDetails.Columns.Count == 0)
            {
                dataGridViewOrderDetails.Columns.Add("FoodNameColumn", "Food Item");
                dataGridViewOrderDetails.Columns.Add("SizeColumn", "Size");
                dataGridViewOrderDetails.Columns.Add("PriceColumn", "Price");
            }

            foreach (var item in selectedItems)
            {
                dataGridViewOrderDetails.Rows.Add(item.Name, item.Size, item.Price);
            }
        }

        private void CalculateTotalPrice()
        {
            decimal totalPrice = selectedItems.Sum(item => item.Price);
            labelTotalPrice.Text = $"Total Price: {totalPrice:C} đ";
        }

        private void OrderConfirmationForm_Load(object sender, EventArgs e)
        {
            // Additional logic on form load if needed
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            // Handle cancel button click event
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Close();
        }

        private void buttonConfirm_Click_1(object sender, EventArgs e)
        {
            // Handle confirm button click event
            int orderId = SaveOrder();
            PaymentForm paymentForm = new PaymentForm(selectedItems, orderId, selectedItems.Sum(item => item.Price));
            paymentForm.Show();
            this.Close();
        }

        private int SaveOrder()
        {
            int orderId;
            string connectionString = ConfigurationManager.ConnectionStrings["FastFoodDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertOrderQuery = "INSERT INTO Orders (UserId, OrderDate, TotalAmount) OUTPUT INSERTED.OrderId VALUES (NULL, @OrderDate, @TotalAmount)";
                using (SqlCommand cmd = new SqlCommand(insertOrderQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TotalAmount", selectedItems.Sum(item => item.Price));

                    orderId = (int)cmd.ExecuteScalar();
                }
            }

            return orderId;
        }
    }
}
