using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marginean_Catalin_Lab8.Models;

namespace Marginean_Catalin_Lab8.Data
{
    public class Marginean_Catalin_Lab8Context : DbContext
    {
        public Marginean_Catalin_Lab8Context (DbContextOptions<Marginean_Catalin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Marginean_Catalin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Marginean_Catalin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Marginean_Catalin_Lab8.Models.Category> Category { get; set; }
    }
}
