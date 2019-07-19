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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Intitial Catalog=DexCoreDB");
        }
    }                      
}
