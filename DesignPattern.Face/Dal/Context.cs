using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Face.Dal
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=DESKTOP-J1MPADH\\SABRI; database=DesignPattern10;integrated security=true");


       }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


  

    
    }
}
