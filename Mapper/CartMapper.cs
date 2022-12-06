using CarritoCompras.Core.Models.DTOs;
using CarritoCompras.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Mapper
{
    public class CartMapper
    {
        public static Cart toCart(CartDto cartDto)
        {
            Cart cart = new Cart();
            cart.Users.DNI = cartDto.DNI;
            return cart;
        }
    }
}
