﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCore_RazorPages.Data;

namespace AspNetCore_RazorPages.Pages.Aufgaben
{
    public class CreateModel : PageModel
    {
        private readonly AspNetCore_RazorPages.Data.AufgabenDbContext _context;

        public CreateModel(AspNetCore_RazorPages.Data.AufgabenDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Aufgabe Aufgabe { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Aufgabe.Add(Aufgabe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


        public void EasyBulkImport()
        {
            IList<Aufgabe> neueAufgaben = new List<Aufgabe>();

            //.... ganz viele Aufgaben werde der Liste hinzugefügt
            
            foreach (Aufgabe aufgabe in neueAufgaben)
            {
                _context.Aufgabe.Add(aufgabe);
            }
            _context.SaveChanges();


            
        }
    }
}
