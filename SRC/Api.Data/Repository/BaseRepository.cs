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

        public Task<T> InsertAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> SelectAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
