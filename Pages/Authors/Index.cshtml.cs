using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihailov_Nicolae_Laborator2.Data;
using Mihailov_Nicolae_Laborator2.Models;

namespace Mihailov_Nicolae_Laborator2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Mihailov_Nicolae_Laborator2.Data.Mihailov_Nicolae_Laborator2Context _context;

        public IndexModel(Mihailov_Nicolae_Laborator2.Data.Mihailov_Nicolae_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
