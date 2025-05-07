using CVD_page.Models;
using Microsoft.EntityFrameworkCore;

namespace CVD_page.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<CVD_page.Models.Userinfo> Userinfo { get; set; } = default!;
    }
}
