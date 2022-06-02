
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;



using Microsoft.EntityFrameworkCore;
using TestApi.Models;

namespace TestApi.database
{


    public class AppTestDbContext : DbContext
        {
            
            public AppTestDbContext(DbContextOptions<AppTestDbContext> options) : base(options)
            {

            }
            
            public DbSet<Category> Categories { get; set; }
        public DbSet<Title> Titles { get; set; }
        }
    
}
