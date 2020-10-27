using Microsoft.EntityFrameworkCore;
using MyFinanceInvest.Data.Context.Config;
using MyFinanceInvest.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFinanceInvest.Repository.Bases
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ContextManager _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(ContextManager context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        protected DbSet<T> DbSet
        {
            get { return _dbSet; }
        }

        public Task<List<T>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Save(T info)
        {
            return Task.Run(() =>
            {
                DbSet.Add(info);
                _context.SaveChanges();

                return true;
            });

        }

        public Task<bool> Update(T info)
        {
            throw new NotImplementedException();
        }
    }
}
