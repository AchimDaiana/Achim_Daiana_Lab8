using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Achim_Daiana_Lab8.Data;
using Achim_Daiana_Lab8.Models;

namespace Achim_Daiana_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Achim_Daiana_Lab8.Data.Achim_Daiana_Lab8Context _context;

        public DetailsModel(Achim_Daiana_Lab8.Data.Achim_Daiana_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
