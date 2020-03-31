﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCore_RazorPages.Data;

namespace AspNetCore_RazorPages.Pages.BlogComments
{
    public class IndexModel : PageModel
    {
        private readonly AspNetCore_RazorPages.Data.BlogDbContext _context;

        public IndexModel(AspNetCore_RazorPages.Data.BlogDbContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get;set; }

        public async Task OnGetAsync()
        {
            Comment = await _context.Comment
                .Include(c => c.Blog).ToListAsync();
        }
    }
}
