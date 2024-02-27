using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeProblem_3.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Check credentials and perform login logic here
            // Redirect to dashboard if login successful, otherwise show error
            return RedirectToPage("/Dashboard");
        }
    }
}
