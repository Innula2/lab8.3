using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace lab8._3
{
    public class ApplicationContext : DbContext

 {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.

           UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=relationsdb7;Trusted_Connection=True;");
        }
    }

}
