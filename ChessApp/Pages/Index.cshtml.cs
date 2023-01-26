using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChessApp.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnPostLogin()
        {
            return RedirectToPage("Login");
        }

        public IActionResult OnPostRegister()
        {
            return RedirectToPage("Register");
        }
    }
}