using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCore_MVC.Models;

namespace AspNetCore_MVC.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext (DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCore_MVC.Models.Blog> Blog { get; set; }
        public DbSet<AspNetCore_MVC.Models.Comment> Comment { get; set; }
    }
}
