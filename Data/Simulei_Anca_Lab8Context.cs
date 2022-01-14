using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulei_Anca_Lab8.Models;

namespace Simulei_Anca_Lab8.Data
{
    public class Simulei_Anca_Lab8Context : DbContext
    {
        public Simulei_Anca_Lab8Context (DbContextOptions<Simulei_Anca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Simulei_Anca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Simulei_Anca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Simulei_Anca_Lab8.Models.Category> Category { get; set; }
    }
}
