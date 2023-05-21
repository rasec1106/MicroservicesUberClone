using ApiTrip.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTrip.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Trip> trips { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Driver> drivers { get; set; }
    }
}
