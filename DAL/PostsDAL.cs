using DemoPostApi.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPostApi.PostsDAL
{
    public class PostsContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public PostsContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=:memory");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasKey(p => new { p.Id });
        }
    }
}
