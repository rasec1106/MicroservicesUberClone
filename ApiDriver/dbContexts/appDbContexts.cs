using ApiDriver.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDriver.dbContexts
{
    public class appDbContexts:DbContext
    {
        public appDbContexts(DbContextOptions options):base(options) 
        { 
        
        
        }
        public DbSet<Conductores> condu { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").
                Build();
            var connectionString = configuration.GetConnectionString("DriverDB");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
