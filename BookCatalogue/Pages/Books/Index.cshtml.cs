using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookCatalogue.Data;
using BookCatalogue.Models;

namespace BookCatalogue.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookCatalogue.Data.BookCatalogueContext _context;

        public IndexModel(BookCatalogue.Data.BookCatalogueContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
