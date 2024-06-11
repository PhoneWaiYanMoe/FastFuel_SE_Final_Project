using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebStaff.Pages
{
    [Authorize]
    public class GiftsModel : PageModel
    {
        public List<Gift> GiftList = new List<Gift>();

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public int Price { get; set; }

        public void OnGet()
        {
            LoadGifts();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "INSERT INTO Gifts (Name, Description, Price) VALUES (@Name, @Description, @Price)";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@Name", Name);

                            // Handle DBNull for Description
                            if (string.IsNullOrEmpty(Description))
                            {
                                command.Parameters.AddWithValue("@Description", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@Description", Description);
                            }

                            command.Parameters.AddWithValue("@Price", Price);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while adding the gift.", ex);
                }
            }

            LoadGifts();
            return Page();
        }


        public IActionResult OnPostDelete(int id)
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Gifts WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the gift.", ex);
            }

            LoadGifts();
            return RedirectToPage();
        }

        private void LoadGifts()
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT Id, Name, Description, Price FROM Gifts";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            GiftList.Clear();
                            while (reader.Read())
                            {
                                Gift gift = new Gift
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                    Price = reader.GetInt32(3)
                                };

                                GiftList.Add(gift);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving gifts from the database.", ex);
            }
        }
    }

    public class Gift
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
