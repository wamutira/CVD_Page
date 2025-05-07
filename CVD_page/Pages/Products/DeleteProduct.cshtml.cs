using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CVD_page.Data;
using CVD_page.Models;

namespace CVD_page.Pages.Products
{
    public class DeleteProductModel : PageModel
    {
        private readonly CVD_page.Data.ApplicationDbContext _db;

        public DeleteProductModel(CVD_page.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                TempData["warning"] = "are you sure you want to delete entry?";
                return NotFound();
            }

            var product = await _db.Products.FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
           
            if (id == null)
            {
                return NotFound();
            }

            var product = await _db.Products.FindAsync(id);
            if (product != null)
            {
                Product = product;
                _db.Products.Remove(Product);
                TempData["Warning"] = "Entry Deleted permanently";
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
