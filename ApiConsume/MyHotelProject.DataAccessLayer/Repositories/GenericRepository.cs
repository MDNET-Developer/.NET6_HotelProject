using Microsoft.EntityFrameworkCore;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        protected readonly MyContext? _context;
        protected readonly DbSet<T>? _dbSet;

        public GenericRepository(MyContext? context)
        {
            _context = context;
            _dbSet = _context?.Set<T>();
        }

        public async Task DeleteAsync(T t)
        {
            _context?.Remove(t);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
          return  await _dbSet.FindAsync(id);
        }

        public async Task InsertAsync(T t)
        {
          await  _context.AddAsync(t);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T t)
        {
            _context.Update(t);
            await _context.SaveChangesAsync();
        }
    }
}
