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
    public class IndexModel : PageModel
    {
        private readonly CVD_page.Data.ApplicationDbContext _db;

        public IndexModel(CVD_page.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _db.Products.ToListAsync();
        }
    }
}
