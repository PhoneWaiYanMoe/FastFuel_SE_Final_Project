using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace FastFoodPOS
{
    public class Database
    {
        private string connectionString;

        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FastFoodDB"].ConnectionString;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public List<FoodItem> GetFoodItems()
        {
            List<FoodItem> foodItems = new List<FoodItem>();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Food", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FoodItem item = new FoodItem
                    {
                        FoodId = (int)reader["FoodId"],
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString(),
                        Price = (decimal)reader["Price"],
                        Category = reader["Category"].ToString(),
                        Size = reader["Size"] as string // Handle null values for Size
                    };
                    foodItems.Add(item);
                }
            }

            return foodItems;
        }
    }


}
