using Api.Data.Context;
using Api.Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Data.Rpository
{
   public class BaseRepository<T> : IRepository<T> where T : BaseEntities
    {

        protected readonly MyContext _context;

        private DbSet<T> _dataset;

        public BaseRepository(MyContext context)
        {

            _context = context;
            _dataset = context.Set<T>();


        }


        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }





        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id  == Guid.Empty)
                {

                    item.Id = Guid.NewGuid();

                }

                item.createAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return  item;
        }






        public Task<T> SelectAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null)
                    return null;

                item.UpdateAt = DateTime.UtcNow;
                item.createAt = result.createAt;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return item;
        }
    }
}
