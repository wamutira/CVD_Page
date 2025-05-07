using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CVD_page.Data;
using CVD_page.Models;

namespace CVD_page.Pages.Products
{
    public class EnquiriesModel : PageModel
    {
        private readonly CVD_page.Data.ApplicationDbContext _context;

        public EnquiriesModel(CVD_page.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Userinfo Userinfo { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Userinfo.Add(Userinfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
