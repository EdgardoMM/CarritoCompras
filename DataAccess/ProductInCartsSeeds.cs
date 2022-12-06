using CarritoCompras.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.DataAccess
{
    public static class ProductInCartsSeeds
    {
        public static void ProductInCartsSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductInCart>().HasData(
                new ProductInCart
                {
                    Id = 1,
                    CartID = 1,
                    ProductID = 1,
                },
                new ProductInCart
                {
                    Id = 2,
                    CartID = 1,
                    ProductID = 4,
                },
                new ProductInCart
                {
                    Id = 3,
                    CartID = 2,
                    ProductID = 12,
                },
                new ProductInCart
                {
                    Id = 4,
                    CartID = 2,
                    ProductID = 8,
                },
                new ProductInCart
                {
                    Id = 5,
                    CartID = 2,
                    ProductID = 5,
                },
                new ProductInCart
                {
                    Id = 6,
                    CartID = 2,
                    ProductID = 14,
                },
                new ProductInCart
                {
                    Id = 7,
                    CartID = 2,
                    ProductID = 15,
                },
                new ProductInCart
                {
                    Id = 8,
                    CartID = 3,
                    ProductID = 1,
                },
                new ProductInCart
                {
                    Id = 9,
                    CartID = 3,
                    ProductID = 4,
                },
                new ProductInCart
                {
                    Id = 10,
                    CartID = 3,
                    ProductID = 8,
                },
                new ProductInCart
                {
                    Id = 11,
                    CartID = 3,
                    ProductID = 13,
                },
                new ProductInCart
                {
                    Id = 12,
                    CartID = 3,
                    ProductID = 7,
                },
                new ProductInCart
                {
                    Id = 13,
                    CartID = 3,
                    ProductID = 2,
                },
                new ProductInCart
                {
                    Id = 14,
                    CartID = 3,
                    ProductID = 5,
                },
                new ProductInCart
                {
                    Id = 15,
                    CartID = 3,
                    ProductID = 14,
                },
                new ProductInCart
                {
                    Id = 16,
                    CartID = 3,
                    ProductID = 15,
                },
                new ProductInCart
                {
                    Id = 17,
                    CartID = 3,
                    ProductID = 9,
                },
                new ProductInCart
                {
                    Id = 18,
                    CartID = 7,
                    ProductID = 8,
                },
                new ProductInCart
                {
                    Id = 19,
                    CartID = 7,
                    ProductID = 10,
                }
            );                
        }
    }
}
