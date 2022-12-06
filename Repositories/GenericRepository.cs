using CarritoCompras.DataAccess;
using CarritoCompras.Entities;
using CarritoCompras.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CarritoDbContext _context;

        public GenericRepository(CarritoDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(int Id)
        {
            try
            {
                T entity = await _context.Set<T>().FindAsync(Id);
                if (entity == null)
                {
                    throw new Exception("Entity not found or already deleted.");
                }
                else
                {
                    _context.Set<T>().Update(entity);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Insert(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
