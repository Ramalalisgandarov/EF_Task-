using Microsoft.EntityFrameworkCore;

namespace WinFormsApp4
{
    public class appDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-43RK2G1\SQLEXPRESS;Initial Catalog=InhaIt;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
