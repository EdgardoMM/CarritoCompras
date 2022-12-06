using CarritoCompras.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.DataAccess
{
    public static class CartsSeeds
    {
        public static void CartsSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasData(
                new Cart
                {
                    Id = 1,
                    Type = "Común",
                    Item = "Arroz Oro Gallo 1Kg, Pan Rayado Preferido 1Kg, Pepsi Cola 2.25l",
                    Promo = false,
                    Total = 293 + 349 + 438.88,
                    Discount = 0,
                    Date = new DateTime(2022,8,4),
                    UserID = 1,
                },
                new Cart
                {
                    Id = 2,
                    Type = "Fecha Especial",
                    Item = "Milanesa Nalga 1Kg, Pepsi Cola 2.25l, Mayonesa Natura, Fernet 1882, Hielo 4Kg",
                    Promo = false,
                    Total = 1362.74 + 438.88 + 277 + 1300 + 591.14,
                    Discount = 1362.74 + 438.88 + 277 + 1300 + 591.14 - ((1362.74 + 438.88 + 277 + 1300 + 591.14) * 0.20),
                    Date = new DateTime(2022, 4, 8),
                    UserID = 2,
                }, 
                new Cart
                {
                    Id = 3,
                    Type = "VIP",
                    Item = "Arroz Oro Gallo 1Kg, Pan Rayado Preferido 1Kg, Pepsi Cola 2.25l, Milanesa Nalga 1Kg, Savora, Fideo Spaghetti, Mayonesa Natura, Fernet 1882, Hielo 4Kg, Sprite 2.25l",
                    Promo = false,
                    Total = 293 + 349 + 438.88 + 1362.74 + 195.17 + 199.90 + 277 + 1300 + 591.14 + 520,
                    Discount = 293 + 349 + 438.88 + 1362.74 + 199.90 + 277 + 1300 + 591.14 + 520 - 3000,
                    Date = new DateTime(2022, 5, 5),
                    UserID = 3,
                },
                new Cart
                {
                    Id = 4,
                    Type = "Común",
                    Item = "Milanesa Nalga 1Kg, Mayonesa Natura ",
                    Promo = false,
                    Total = 1362.74 + 277,
                    Discount = 0,
                    Date = new DateTime(2022, 5, 5),
                    UserID = 5,
                },
                new Cart
                {
                    Id = 5,
                    Type = "VIP",
                    Item = "Coca-Cola 2.25l, Coca-Cola 2.25l, Fernet Branca 750cc, Hielo 4Kg, Hielo 4Kg ",
                    Promo = false,
                    Total = 520 + 520 + 1768 + 591.14 + 591.14,
                    Discount = 520 + 520 + 1768 + 591.14 + 591.14 - ((520 + 520 + 1768 + 591.14 + 591.14) * 0.20),
                    Date = new DateTime(2022, 12, 24),
                    UserID = 6,
                },
                new Cart
                {
                    Id = 6,
                    Type = "Fecha Especial",
                    Item = "Arroz Oro Gallo 1Kg, Pan Rayado Preferido 1Kg, Pepsi Cola 2.25l, Milanesa Nalga 1Kg, Savora, Fideo Spaghetti, Mayonesa Natura, Fernet 1882, Hielo 4Kg, Sprite 2.25l",
                    Promo = true,
                    Total = 293 + 349 + 438.88 + 1362.74 + 195.17 + 199.90 + 277 + 1300 + 591.14 + 520,
                    Discount = 293 + 349 + 438.88 + 1362.74 + 195.17 + 199.90 + 277 + 1300 + 591.14 + 520 - 2500,
                    Date = new DateTime(2022, 5, 25),
                    UserID = 5,
                }, 
                new Cart
                {
                    Id = 7,
                    Type = "Común",
                    Item = "Pepsi Cola 2.25l, Coca-Cola 2.25l",
                    Promo = false,
                    Total = 438.88 + 520,
                    Discount = 0,
                    Date = new DateTime(2022, 6, 6),
                    UserID = 1,
                },
                new Cart
                {
                    Id = 8,
                    Type = "Fecha Especial",
                    Item = "Fideo Spaghetti, Fideo Spaghetti, Milanesa Nalga 1Kg, Milanesa Nalga 1Kg, Sprite 2.25l, Mayonesa Natura, Ketchup Hellmann's, Pan Rayado Preferido 1Kg, Arroz Oro Gallo 1Kg, Arroz Oro Gallo 1Kg ",
                    Promo = false,
                    Total = 199.90 + 199.90 + 1362.74 + 1362.74 + 520 + 277 + 379 + 349 + 293 + 293,
                    Discount = 199.90 + 1362.74 + 1362.74 + 520 + 277 + 379 + 349 + 293 + 293 - 3000,
                    Date = new DateTime(2023, 1, 2),
                    UserID = 6,
                }
            );
        }
    }
}
