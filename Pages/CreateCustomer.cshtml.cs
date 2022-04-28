using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CENG382.Models.DB;

namespace CENG382.Pages
{
    public class CreateCustomerModel : PageModel
    {
        private readonly CENG382Context _context;
        public CreateCustomerModel(CENG382Context context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public new Customer Customer { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }
            _context.Customers.Add(Customer);
             await _context.SaveChangesAsync();
            return RedirectToPage("/.Index");
        }
    }
}
