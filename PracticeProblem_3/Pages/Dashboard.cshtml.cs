using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeProblem_3.Pages
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Perform logout logic here
            // Redirect to login page
            return RedirectToPage("/Login");
        }
    }
}
