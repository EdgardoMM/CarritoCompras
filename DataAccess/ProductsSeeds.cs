using CarritoCompras.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.DataAccess
{
    public static class ProductsSeeds
    {
        public static void ProductsSeed(this ModelBuilder modelBuilder) {
            
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Arroz Oro Gallo 1Kg",
                    Price = 293,
                },
                new Product
                {
                    Id = 2,
                    Name = "Fideo Spaghetti",
                    Price = 199.90,
                }, 
                new Product
                {
                    Id = 3,
                    Name = "Fideo Tirabuzón",
                    Price = 154.96,
                },
                new Product
                {
                    Id = 4,
                    Name = "Pan Rayado Preferido 1Kg",
                    Price = 349,
                },
                new Product
                {
                    Id = 5,
                    Name = "Mayonesa Natura",
                    Price = 277,
                },
                new Product
                {
                    Id = 6,
                    Name = "Ketchup Hellmann's",
                    Price = 379,
                },
                new Product
                {
                    Id = 7,
                    Name = "Savora",
                    Price = 195.17,
                },
                new Product
                {
                    Id = 8,
                    Name = "Pepsi Cola 2.25l",
                    Price = 438.88,
                }, 
                new Product
                {
                    Id = 9,
                    Name = "Sprite 2.25l",
                    Price = 520,
                },
                new Product
                {
                    Id = 10,
                    Name = "Coca-Cola 2.25l",
                    Price = 520,
                }, 
                new Product
                {
                    Id = 11,
                    Name = "7 Up 2.25l",
                    Price = 435.76,
                },
                new Product
                {
                    Id = 12,
                    Name = "Milanesa Nalga 1Kg",
                    Price = 1362.74,
                }, 
                new Product
                {
                    Id = 13,
                    Name = "Fernet Branca 750cc",
                    Price = 1768,
                },
                new Product
                {
                    Id = 14,
                    Name = "Fernet 1882",
                    Price = 1300,
                }, 
                new Product
                {
                    Id = 15,
                    Name = "Hielo 4Kg",
                    Price = 591.14,
                }
            );
        }    
    }
}
