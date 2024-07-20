using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaOrder.Domain.Entities;

namespace PizzaOrder.Domain.Data
{
    public class PizzaDBContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public PizzaDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connect to postgres with connection 
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DbContext"));
        }
        public PizzaDBContext(DbContextOptions<PizzaDBContext> options) : base(options) { }

        public DbSet<EPizzaDetails> PizzaDetails { get; set; }
        public DbSet<EOrderDetails> OrderDetails { get; set; }

    }
}
