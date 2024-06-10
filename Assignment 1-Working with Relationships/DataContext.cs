using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;


namespace Assignment_1_Working_with_Relationships
{
    public class DataContext : DbContext
    {


        public string DbPath { get; set; }


        public DbSet<User> Users { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            Console.WriteLine(path);
            DbPath = Path.Combine(path, "Assignment.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source = {DbPath}");
        }

    }

}