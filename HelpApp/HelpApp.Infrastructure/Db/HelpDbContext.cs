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
    }
}
