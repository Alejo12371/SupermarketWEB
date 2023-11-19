using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SupermarketWEB.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult>OnPostAsync()
        {
            await HttpContext.SignInAsync("MyCookieAuth");
            return RedirectToPage("/Index");
        }
        public void OnGet()
        {
        }
    }
}
