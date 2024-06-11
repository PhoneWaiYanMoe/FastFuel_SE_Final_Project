using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Threading.Tasks;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }

    private string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";

    public async Task<IActionResult> OnPostAsync()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            await connection.OpenAsync();

            string query = "SELECT COUNT(1) FROM Staffs WHERE Username = @Username AND Password = @Password";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);

                var result = (int)await command.ExecuteScalarAsync();

                if (result == 1)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, Username)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Sign in user
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity));

                    // Redirect to home or desired page after successful login
                    return RedirectToPage("/Index");
                }

                // Invalid login attempt
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }
        }
    }
}
