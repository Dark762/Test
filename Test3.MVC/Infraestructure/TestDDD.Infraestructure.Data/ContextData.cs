
using Microsoft.EntityFrameworkCore;
using TestDDD.Domain.Entities;

namespace TestDDD.Infraestructure.Data
{
    public class ContextData : DbContext
    {
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["Context"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
            //modelBuilder.Entity<Clientes>().ToTable("Clientes");
        }





        public DbSet<Clientes> Cliente { get; set; }
    }
}
