using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Tea> Teas { get; set; }
        public DbSet<TeaOrder> TeaOrders { get; set; }
        public DbSet<TeaOrderTea> TeaOrderTeas { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tea>().HasData(new Tea { Id = Guid.NewGuid(), Name = "StrawberryTea", Price = 50000, Quantity = 150 });
            modelBuilder.Entity<Tea>().HasData(new Tea { Id = Guid.NewGuid(), Name = "PeachTea", Price = 45000, Quantity = 100 });
            modelBuilder.Entity<Tea>().HasData(new Tea { Id = Guid.NewGuid(), Name = "LycheeTea", Price = 55000, Quantity = 75 });

            modelBuilder.Entity<TeaOrder>()
                .HasOne(c => c.Customer)
                .WithMany(to => to.Orders)
                .HasForeignKey(to => to.CustomerId);

            modelBuilder.Entity<TeaOrderTea>().HasKey(to => new { to.TeaOrderId, to.TeaId });

            modelBuilder.Entity<TeaOrderTea>()
                .HasOne(sc => sc.TeaOrder)
                .WithMany(s => s.TeaOrderTeas)
                .HasForeignKey(sc => sc.TeaOrderId);

            modelBuilder.Entity<TeaOrderTea>()
                .HasOne(sc => sc.Tea)
                .WithMany(s => s.TeaOrderTeas)
                .HasForeignKey(sc => sc.TeaId);
        }

        public ApplicationDbContext()
        {

        }
    }
}
