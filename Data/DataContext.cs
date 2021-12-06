using Basic_Web_API.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Data

{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public IConfiguration Configuration { get; }

        // ********* we have to tell the datacontext class about our models *********
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
        .HasMany(c => c.Contact)
        .WithOne(e => e.Company);


            modelBuilder.Entity<Country>()
        .HasMany(c => c.Contact)
        .WithOne(e => e.Country);

            base.OnModelCreating(modelBuilder);
        }


    }

}



