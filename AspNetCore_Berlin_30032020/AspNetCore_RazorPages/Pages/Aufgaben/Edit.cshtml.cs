using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCore_RazorPages.Data;

namespace AspNetCore_RazorPages.Pages.Aufgaben
{
    public class EditModel : PageModel
    {
        private readonly AspNetCore_RazorPages.Data.AufgabenDbContext _context;

        public EditModel(AspNetCore_RazorPages.Data.AufgabenDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Aufgabe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AufgabeExists(Aufgabe.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AufgabeExists(int id)
        {
            return _context.Aufgabe.Any(e => e.Id == id);
        }
    }
}
