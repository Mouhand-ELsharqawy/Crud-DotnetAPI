using Crud.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        
        
    }
}
