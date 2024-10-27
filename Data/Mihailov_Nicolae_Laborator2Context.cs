using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mihailov_Nicolae_Laborator2.Models;

namespace Mihailov_Nicolae_Laborator2.Data
{
    public class Mihailov_Nicolae_Laborator2Context : DbContext
    {
        public Mihailov_Nicolae_Laborator2Context (DbContextOptions<Mihailov_Nicolae_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Mihailov_Nicolae_Laborator2.Models.Book> Book { get; set; } = default!;
        public DbSet<Mihailov_Nicolae_Laborator2.Models.Author> Author { get; set; } = default!;
        public DbSet<Mihailov_Nicolae_Laborator2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Mihailov_Nicolae_Laborator2.Models.Category> Category { get; set; } = default!;
    }
}
