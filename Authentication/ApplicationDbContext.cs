using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EcoPowerAPI.Models;
using System.Reflection.Emit;

namespace JWTAuthentication.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


           // base.OnModelCreating(modelBuilder);
            builder.Entity<OrderDetail>()
            .HasKey(od => od.OrderDetailsId);

            //modelBuilder.Entity<OrderDetail>().HasNoKey();
            // entity.Property(e => e.OrderId).HasMaxLength(50);
        }
    }
}

