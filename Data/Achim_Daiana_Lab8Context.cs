using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Achim_Daiana_Lab8.Models;

namespace Achim_Daiana_Lab8.Data
{
    public class Achim_Daiana_Lab8Context : DbContext
    {
        public Achim_Daiana_Lab8Context (DbContextOptions<Achim_Daiana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Achim_Daiana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Achim_Daiana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Achim_Daiana_Lab8.Models.Category> Category { get; set; }
    }
}
