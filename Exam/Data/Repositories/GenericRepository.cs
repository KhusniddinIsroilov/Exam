using Exam.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {

#pragma warning disable 

        MusicDbContext _unDb;
        private DbSet<T> dbset;

        public GenericRepository()
        {
            _unDb = new MusicDbContext();
            this.dbset = _unDb.Set<T>();

        }

        public async Task<T> CreateAsync(T entity)
        {
             var result  =  dbset.Add(entity);
            await _unDb.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var pred =   dbset.Find(predicate);
            if (pred is null)
                return false;

                dbset.Remove(pred);
          await  _unDb.SaveChangesAsync();

            return true;


        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null ? dbset : dbset.Where(predicate);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return  dbset.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var result = dbset.Find(entity);

            dbset.Update(result);
          await  _unDb.SaveChangesAsync();

            return result;
        }
    }
}
