using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CENG382.Models.DB;

namespace CENG382.Pages
{
    public class CreateCleanerModel : PageModel
    {
        private readonly CENG382Context _context;
        public CreateCleanerModel(CENG382Context context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public new Cleaner Cleaner { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }
            _context.Cleaners.Add(Cleaner);
            await _context.SaveChangesAsync();
            return RedirectToPage("/.Index");
        }
    }
}
