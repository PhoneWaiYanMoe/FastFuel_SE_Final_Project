using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace WebStaff.Pages
{
    public class AddModel : PageModel
    {
        private readonly ILogger<AddModel> _logger;

        public AddModel(ILogger<AddModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public AgentAddInfo AgentAdd { get; set; }

        public IActionResult OnGet()
        {
            return Page();
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
                    string sql = "INSERT INTO Agents (Name, Email, Password, Location, CreationDate, Description) VALUES (@Name, @Email, @Password, @Location, @CreationDate, @Description)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", AgentAdd.Name);
                        command.Parameters.AddWithValue("@Email", AgentAdd.Email);
                        command.Parameters.AddWithValue("@Password", AgentAdd.Password);
                        command.Parameters.AddWithValue("@Location", AgentAdd.Location);
                        command.Parameters.AddWithValue("@CreationDate", AgentAdd.CreationDate);
                        command.Parameters.AddWithValue("@Description", AgentAdd.Description);

                        command.ExecuteNonQuery();
                        _logger.LogInformation("Agent added successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding the agent to the database.");
                return RedirectToPage("./Error");
            }

            return RedirectToPage("./Agents");
        }
    }

    public class AgentAddInfo
    {
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

        public DateTime CreationDate { get; set; } = DateTime.Now;

        [StringLength(255)]
        public string Description { get; set; }
    }
}
