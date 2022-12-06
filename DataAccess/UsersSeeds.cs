using CarritoCompras.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.DataAccess
{
    public static class UsersSeeds
    {
        public static void UsersSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    DNI = 12345678,
                    FirstName = "Maria",
                    LastName = "Irola",
                    Address = "Av 25 de Mayo 123",
                    Phone = 111111111,
                    Vip = false
                },
                new User
                {
                    Id = 2,
                    DNI = 23456789,
                    FirstName = "Marita",
                    LastName = "Gomez",
                    Address = "9 de Julio 1000",
                    Phone = 222222222,
                    Vip = false
                },
                new User
                {
                    Id = 3,
                    DNI = 34567890,
                    FirstName = "David",
                    LastName = "Campos",
                    Address = "Fray Bertaca 1024",
                    Phone = 333333333,
                    Vip = true
                },
                new User
                {
                    Id = 4,
                    DNI = 45678901,
                    FirstName = "Sergio",
                    LastName = "Aguilar",
                    Address = "Dodero 2933",
                    Phone = 444444444,
                    Vip = true
                },
                new User
                {
                    Id = 5,
                    DNI = 56789012,
                    FirstName = "Carolina",
                    LastName = "Cano",
                    Address = "Seitor 45",
                    Phone = 555555555,
                    Vip = false
                },
                new User
                {
                    Id = 6,
                    DNI = 67890123,
                    FirstName = "Jose",
                    LastName = "Salvatierra",
                    Address = "Moreno 54",
                    Phone = 666666666,
                    Vip = true
                }
            );
        }
    }
}
