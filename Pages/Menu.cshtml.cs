using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace WebStaff.Pages
{
    [Authorize]
    public class MenuModel : PageModel
    {
        public List<Food> listFoods = new List<Food>();

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public decimal Price { get; set; }

        [BindProperty]
        public string Category { get; set; }

        [BindProperty]
        public string Size { get; set; }

        public void OnGet()
        {
            LoadMenu();
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
                        string sql = "INSERT INTO Food (Name, Description, Price, Category, Size) VALUES (@Name, @Description, @Price, @Category, @Size)";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                            command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
                            command.Parameters.AddWithValue("@Price", Price);
                            command.Parameters.AddWithValue("@Category", Category);

                            // Check if Size is empty or null, if so, set it to DBNull.Value
                            object sizeValue = (object)Size;
                            if (string.IsNullOrEmpty(Size))
                            {
                                sizeValue = DBNull.Value;
                            }
                            command.Parameters.AddWithValue("@Size", sizeValue);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while adding the food item.", ex);
                }
            }

            LoadMenu();
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
                    string sql = "DELETE FROM Food WHERE FoodId = @FoodId";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FoodId", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the food item.", ex);
            }

            LoadMenu();
            return RedirectToPage();
        }

        private void LoadMenu()
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT FoodId, Name, Description, Price, Category, Size FROM Food";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            listFoods.Clear();
                            while (reader.Read())
                            {
                                Food food = new Food
                                {
                                    FoodId = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2),
                                    Price = reader.GetDecimal(3),
                                    Category = reader.GetString(4),
                                    Size = reader.IsDBNull(5) ? null : reader.GetString(5)
                                };

                                listFoods.Add(food);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving menu items from the database.", ex);
            }
        }
    }

    public class Food
    {
        public int FoodId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(10)]
        public string Size { get; set; }
    }
}