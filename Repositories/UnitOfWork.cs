using CarritoCompras.DataAccess;
using CarritoCompras.Entities;
using CarritoCompras.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarritoDbContext _context;
        public IGenericRepository<User> _usersRepository;
        public IGenericRepository<Product> _productsRepository;
        public IGenericRepository<Cart> _cartsRepository;
        public UnitOfWork(CarritoDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<User> UsersRepository
        {
            get
            {
                if (_usersRepository == null)
                {
                    _usersRepository = new GenericRepository<User>(_context);

                }
                return _usersRepository;
            }
        }

        public IGenericRepository<Product> ProductsRepository
        {
            get
            {
                if (_productsRepository == null)
                {
                    _productsRepository = new GenericRepository<Product>(_context);

                }
                return _productsRepository;
            }
        }

        public IGenericRepository<Cart> CartsRepository
        {
            get
            {
                if (_cartsRepository == null)
                {
                    _cartsRepository = new GenericRepository<Cart>(_context);

                }
                return _cartsRepository;
            }
        }
    }
}
