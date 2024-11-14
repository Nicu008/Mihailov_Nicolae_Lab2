using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihailov_Nicolae_Laborator2.Data;
using Mihailov_Nicolae_Laborator2.Models;
using Mihailov_Nicolae_Laborator2.Models.ViewModels;

namespace Mihailov_Nicolae_Laborator2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Mihailov_Nicolae_Laborator2.Data.Mihailov_Nicolae_Laborator2Context _context;

        public IndexModel(Mihailov_Nicolae_Laborator2.Data.Mihailov_Nicolae_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();
            var categoriesQuery = _context.Category
                .Include(c => c.BookCategories)
                .ThenInclude(bc => bc.Book)
                .ThenInclude(b => b.Author)
                .OrderBy(c => c.CategoryName);

            CategoryData.Categories = await categoriesQuery.ToListAsync();

            if (id.HasValue)
            {
                CategoryID = id.Value;

                var selectedCategory = CategoryData.Categories
                    .FirstOrDefault(c => c.ID == id.Value);

                CategoryData.Books = selectedCategory?.BookCategories
                    .Select(bc => bc.Book)
                    .ToList();
            }
        }
    }
}
