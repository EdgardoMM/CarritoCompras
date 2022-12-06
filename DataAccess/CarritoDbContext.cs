using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarritoCompras.Entities;

namespace CarritoCompras.DataAccess
{
    public class CarritoDbContext : DbContext
    {
        public CarritoDbContext (DbContextOptions<CarritoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductInCart> ProductInCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UsersSeed();
            modelBuilder.ProductsSeed();
            modelBuilder.CartsSeed();
            modelBuilder.ProductInCartsSeed();
        }
    }
}
