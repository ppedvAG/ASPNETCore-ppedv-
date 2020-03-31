using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_RazorPages.Data
{
    public class AufgabenDbContext : DbContext
    {
        public AufgabenDbContext (DbContextOptions<AufgabenDbContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCore_RazorPages.Data.Aufgabe> Aufgabe { get; set; }
    }
}
