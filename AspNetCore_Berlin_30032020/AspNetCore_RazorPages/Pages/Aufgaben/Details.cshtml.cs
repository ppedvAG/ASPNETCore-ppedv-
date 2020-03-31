using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCore_RazorPages.Data;

namespace AspNetCore_RazorPages.Pages.Aufgaben
{
    public class DetailsModel : PageModel
    {
        private readonly AspNetCore_RazorPages.Data.AufgabenDbContext _context;

        public DetailsModel(AspNetCore_RazorPages.Data.AufgabenDbContext context)
        {
            _context = context;
        }

        public Aufgabe Aufgabe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aufgabe = await _context.Aufgabe.FirstOrDefaultAsync(m => m.Id == id);

            if (Aufgabe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
