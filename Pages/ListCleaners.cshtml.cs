using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CENG382.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CENG382.Pages
{
    public class ListCleanersModel : PageModel
    {
        private readonly CENG382Context _context;
        public ListCleanersModel(CENG382Context context)
        {
            _context = context;
        }
        public IList<Cleaner> Cleaners { get; set; }
        public async Task OnGetAsync()
        {
            Cleaners = await _context.Cleaners.ToListAsync();
        }
    }
}
