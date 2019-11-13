using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Tea> Teas { get; set; }
        public DbSet<TeaOrder> TeaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeaOrder>()
                .HasOne(c => c.Customer)
                .WithMany(to => to.Orders)
                .HasForeignKey(to => to.CustomerId);
        }

        public ApplicationDbContext()
        {

        }
    }
}
