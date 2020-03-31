using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_RazorPages.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext (DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCore_RazorPages.Data.Blog> Blog { get; set; }
        public DbSet<AspNetCore_RazorPages.Data.Comment> Comment { get; set; }
    }
}
