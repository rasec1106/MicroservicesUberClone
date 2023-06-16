using BlogPost.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogPost.dbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Post> blogPosts { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<User> users{ get; set; }
    }
}
