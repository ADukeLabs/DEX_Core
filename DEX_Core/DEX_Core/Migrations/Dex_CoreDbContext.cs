using DEX_Core_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEX_Core_WebAPI.Migrations
{
    public class Dex_CoreDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DexCoreDB");
            base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Company>().HasData(
        //        new Company { Id = 1, Name = "Datacom"},
        //        new Company { Id = 2, Name = "Fujitsu"},
        //        new Company { Id = 3, Name = "MetLife"}
        //    );

        //    modelBuilder.Entity<Contact>().HasData(
        //        new Contact { Id = 1, Name = "Person 1", CompanyId = 1, EmailAddress = "johndoe@nowhere.com"},
        //        new Contact { Id = 2, Name = "Person 2", CompanyId = 1, EmailAddress = "johndoe@nowhere.com" }
        //    );
        //}
    }                      
}                                                                   