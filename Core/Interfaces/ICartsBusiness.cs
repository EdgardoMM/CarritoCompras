using CarritoCompras.Core.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Core.Interfaces
{
    public interface ICartsBusiness
    {
        Task<bool> Insert(CartDto cartDto);
    }
}
