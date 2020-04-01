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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<AspNetCore_RazorPages.Data.Blog> Blog { get; set; }
        public DbSet<AspNetCore_RazorPages.Data.Comment> Comment { get; set; }
    }
}
