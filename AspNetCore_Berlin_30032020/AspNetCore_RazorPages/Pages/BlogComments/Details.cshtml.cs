using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCore_RazorPages.Data;

namespace AspNetCore_RazorPages.Pages.BlogComments
{
    public class DetailsModel : PageModel
    {
        private readonly AspNetCore_RazorPages.Data.BlogDbContext _context;

        public DetailsModel(AspNetCore_RazorPages.Data.BlogDbContext context)
        {
            _context = context;
        }

        public Comment Comment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Comment = await _context.Comment
                .Include(c => c.Blog).FirstOrDefaultAsync(m => m.Id == id);




            if (Comment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
