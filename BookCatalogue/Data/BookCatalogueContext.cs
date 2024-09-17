using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookCatalogue.Models;

namespace BookCatalogue.Data
{
    public class BookCatalogueContext : DbContext
    {
        public BookCatalogueContext (DbContextOptions<BookCatalogueContext> options)
            : base(options)
        {
        }

        public DbSet<BookCatalogue.Models.Book> Book { get; set; } = default!;
    }
}
