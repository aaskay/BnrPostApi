using DemoPostApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoPostApi.PostsDAL
{
    public class PostsContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public PostsContext(DbContextOptions<PostsContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlite(@"Data Source=DemoPostDatabase.db;");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Post>().HasKey(p => new { p.Id });
        //}
    }
}
