using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Dal
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-J1MPADH\\SABRI; database=DesignPattern7;integrated security=true");


        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
