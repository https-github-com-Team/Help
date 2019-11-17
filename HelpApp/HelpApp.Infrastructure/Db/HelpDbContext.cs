using HelpApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelpApp.Infrastructure.Db
{
    public class HelpDbContext:DbContext
    {
        public HelpDbContext(DbContextOptions<HelpDbContext> dbContext):base(dbContext)
        {

        }
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries  { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
    }
}
