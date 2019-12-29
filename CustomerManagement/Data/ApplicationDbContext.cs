using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.Models;
using CustomerManagement.Repositories;
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
        public DbSet<Car> Cars { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Car"});
            modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Bycicle" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Motor" });

            modelBuilder.Entity<ProductOrder>()
               .HasOne(x => x.Order)
               .WithMany(x => x.ProductOrders)
               .HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<ProductOrder>()
              .HasOne(x => x.Product)
              .WithMany(x => x.ProductOrders)
              .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<ProductOrder>().HasKey(to => new { to.OrderId, to.ProductId });


            modelBuilder.Entity<Tea>().HasData(new Tea { Id = Guid.NewGuid(), Name = "StrawberryTea", Price = 50000, Quantity = 150 });
            modelBuilder.Entity<Tea>().HasData(new Tea { Id = Guid.NewGuid(), Name = "PeachTea", Price = 45000, Quantity = 100 });
            modelBuilder.Entity<Tea>().HasData(new Tea { Id = Guid.NewGuid(), Name = "LycheeTea", Price = 55000, Quantity = 75 });

            modelBuilder.Entity<TeaOrder>()
                .HasOne(c => c.Customer)
                .WithMany(to => to.Orders)
                .HasForeignKey(to => to.AID);

            modelBuilder.Entity<TeaOrderTea>().HasKey(to => new { to.TeaOrderId, to.TeaId });

            modelBuilder.Entity<TeaOrderTea>()
                .HasOne(sc => sc.TeaOrder)
                .WithMany(s => s.TeaOrderTeas)
                .HasForeignKey(sc => sc.TeaOrderId);

            modelBuilder.Entity<TeaOrderTea>()
                .HasOne(sc => sc.Tea)
                .WithMany(s => s.TeaOrderTeas)
                .HasForeignKey(sc => sc.TeaId);

            modelBuilder.Entity<Ticket>()
                .HasOne(c => c.Car)
                .WithMany(t => t.Tickets)
                .HasForeignKey(fk => fk.CarId);

            modelBuilder.Entity<Ticket>()
               .HasOne(c => c.Resident)
               .WithMany(t => t.Tickets)
               .HasForeignKey(fk => fk.ResidentId);


        }
    }
}
