using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.Dal
{
    public class Context : DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-J1MPADH\\SABRI; database=DesignPattern8;integrated security=true");
        }

       
        public DbSet<Product> Products { get; set; }
    
    
    }
}
