using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace WebStaff.Pages
{
    public class EditModel : PageModel
    {
        private readonly ILogger<EditModel> _logger;

        public EditModel(ILogger<EditModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public AgentEditInfo AgentEdit { get; set; }

        public IActionResult OnGet(int id)
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT Id, Name, Email, Password, Location, CreationDate, Description FROM Agents WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AgentEdit = new AgentEditInfo
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Password = reader.GetString(3),
                                    Location = reader.GetString(4),
                                    CreationDate = reader.GetDateTime(5),
                                    Description = reader.GetString(6)
                                };
                                _logger.LogInformation("Loaded agent with ID {Id}", AgentEdit.Id);
                                return Page();
                            }
                            else
                            {
                                _logger.LogWarning("No agent found with ID {Id}", id);
                                return RedirectToPage("./Index");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while loading the agent from the database.");
                return RedirectToPage("./Error");
            }
        }

        public IActionResult OnPost()
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
                    connection.Open();
                    string sql = "UPDATE Agents SET Name = @Name, Email = @Email, Password = @Password, Location = @Location, CreationDate = @CreationDate, Description = @Description WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", AgentEdit.Id);
                        command.Parameters.AddWithValue("@Name", AgentEdit.Name);
                        command.Parameters.AddWithValue("@Email", AgentEdit.Email);
                        command.Parameters.AddWithValue("@Password", AgentEdit.Password);
                        command.Parameters.AddWithValue("@Location", AgentEdit.Location);
                        command.Parameters.AddWithValue("@CreationDate", AgentEdit.CreationDate);
                        command.Parameters.AddWithValue("@Description", AgentEdit.Description);

                        int rowsAffected = command.ExecuteNonQuery();
                        _logger.LogInformation("Rows affected: {rowsAffected}", rowsAffected);

                        if (rowsAffected == 0)
                        {
                            _logger.LogWarning("No rows were updated for ID {Id}. Please check if the ID exists.", AgentEdit.Id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the agent in the database.");
                return RedirectToPage("./Error");
            }

            return RedirectToPage("./Agents");
        }
    }

    public class AgentEditInfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public DateTime CreationDate { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
