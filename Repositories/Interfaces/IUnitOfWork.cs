using CarritoCompras.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UsersRepository { get; }
        IGenericRepository<Cart> CartsRepository { get; }
        IGenericRepository<Product> ProductsRepository { get; }
    }
}
