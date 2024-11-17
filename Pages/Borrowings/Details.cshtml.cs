using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihailov_Nicolae_Laborator2.Data;
using Mihailov_Nicolae_Laborator2.Models;

namespace Mihailov_Nicolae_Laborator2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Mihailov_Nicolae_Laborator2.Data.Mihailov_Nicolae_Laborator2Context _context;

        public DetailsModel(Mihailov_Nicolae_Laborator2.Data.Mihailov_Nicolae_Laborator2Context context)
        {
            _context = context;
        }

        public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.Include(i => i.Member).Include(c => c.Book).ThenInclude(bc => bc.Author).FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else
            {
                Borrowing = borrowing;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var borrowing = await _context.Borrowing.FindAsync(id);
            if (borrowing != null)
            {
                Borrowing = borrowing;
                _context.Borrowing.Remove(Borrowing);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
