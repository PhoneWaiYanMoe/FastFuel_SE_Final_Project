using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WebStaff.Pages
{
    public class EditFoodModel : PageModel
    {
        private readonly ILogger<EditFoodModel> _logger;

        public EditFoodModel(ILogger<EditFoodModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public FoodItem Food { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string sql = "SELECT FoodId, Name, Description, Price, Category FROM Food WHERE FoodId = @FoodId";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FoodId", id);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                Food = new FoodItem
                                {
                                    FoodId = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2),
                                    Price = reader.GetDecimal(3),
                                    Category = reader.GetString(4)
                                };
                                _logger.LogInformation("Loaded food item with ID {Id}", Food.FoodId);
                                return Page();
                            }
                            else
                            {
                                _logger.LogWarning("No food item found with ID {Id}", id);
                                return NotFound();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the food item for editing.");
                return RedirectToPage("/Error");
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is invalid.");
                return Page();
            }

            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string sql = "UPDATE Food SET Name = @Name, Description = @Description, Price = @Price, Category = @Category WHERE FoodId = @FoodId";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Food.Name);
                        command.Parameters.AddWithValue("@Description", Food.Description);
                        command.Parameters.AddWithValue("@Price", Food.Price);
                        command.Parameters.AddWithValue("@Category", Food.Category);
                        command.Parameters.AddWithValue("@FoodId", Food.FoodId);

                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        _logger.LogInformation("Rows affected: {rowsAffected}", rowsAffected);

                        if (rowsAffected == 0)
                        {
                            _logger.LogWarning("No rows were updated for ID {Id}. Please check if the ID exists.", Food.FoodId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the food item in the database.");
                return RedirectToPage("/Error");
            }

            return RedirectToPage("/Menu");
        }
    }

    public class FoodItem
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
    }
}
