using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebStaff.Pages
{
    [Authorize]
    public class AgentsModel : PageModel
    {
        public List<AgentInfo> listAgents = new List<AgentInfo>();

        public void OnGet()
        {
            LoadAgents();
        }

        public IActionResult OnPostDelete(int id)
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Agents WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the agent.", ex);
            }

            return RedirectToPage();
        }

        private void LoadAgents()
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT Id, Name, Email, Password, Location, CreationDate, Description FROM Agents";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            listAgents.Clear();
                            while (reader.Read())
                            {
                                AgentInfo agent = new AgentInfo
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Password = reader.GetString(3),
                                    Location = reader.GetString(4),
                                    CreationDate = reader.GetDateTime(5),
                                    Description = reader.GetString(6)
                                };

                                listAgents.Add(agent);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving data from the database.", ex);
            }
        }
    }

    public class AgentInfo
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
