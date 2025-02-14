using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Final_Project.Views.Home
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;

        public string Title { get; set; } = "Login";
        public string Message { get; set; } = string.Empty;
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                Message = "Please enter email and password";
                return Page();
            }

            if (Email == "admin@example.com" && Password == "password")
            {
                return RedirectToPage("/Index");
            }
            else
            {
                Message = "Invalid email or password";
                return Page();
            }
        }
    }
}
