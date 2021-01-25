using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formulaTopTen.Models
{
    public class ApplikationDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-AS8ODFC\SQLEXPRESS;Database=formula;Trusted_Connection=True;");
        //}

        public ApplikationDbContext(DbContextOptions<ApplikationDbContext> options) 
            : base(options) { }

        public DbSet<Driver> driver { set; get; }
        public DbSet<Coment> coment { set; get; }
    }
}
