using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFinanceInvest.Repository.Base
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        Task<T> Get(int id);

        Task<List<T>> All();

        Task<List<T>> Find(Expression<Func<T, bool>> predicate);

        Task<bool> Save(T info);

        Task<bool> Update(T info);

        Task<bool> Delete(int id);
    }
}
