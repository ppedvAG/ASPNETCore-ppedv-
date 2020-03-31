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
    public class IndexModel : PageModel
    {
        private readonly AspNetCore_RazorPages.Data.AufgabenDbContext _context;

        public IndexModel(AspNetCore_RazorPages.Data.AufgabenDbContext context)
        {
            _context = context;
        }

        public IList<Aufgabe> Aufgabe { get;set; }

        public async Task OnGetAsync()
        {
            Aufgabe = await _context.Aufgabe.ToListAsync();
        }
    }
}
