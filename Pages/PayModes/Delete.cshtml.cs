using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.PayModes
{
    public class DeleteModel : PageModel
    {
        private readonly SupermarketContext _context;

        public DeleteModel(SupermarketContext context)
        {
            _context = context;
        }


        [BindProperty]

        public PayMode PayMode { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var paymode = await _context.PayModes.FindAsync(id);

            if (paymode != null)
            {
                PayMode = PayMode;
                _context.PayModes.Remove(PayMode);
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("./Index");
        }
        
    }
}
