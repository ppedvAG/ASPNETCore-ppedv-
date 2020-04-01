using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_RazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_RazorPages.Pages
{
    public class BlogModel : PageModel
    {
        private readonly AspNetCore_RazorPages.Data.BlogDbContext _context;

        public BlogModel(AspNetCore_RazorPages.Data.BlogDbContext context)
        {
            _context = context;
        }
        public IList<Blog> Blogs { get; set; }

        [BindProperty]
        public Comment Comment { get; set; }

        public async Task OnGetAsync()
        {
            Blogs = await _context.Blog.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Comment.CreatedAt = DateTime.Now;
            
            _context.Comment.Add(Comment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostCreateAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Comment.BlogId = id.Value;
            Comment.CreatedAt = DateTime.Now;

            _context.Comment.Add(Comment);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}