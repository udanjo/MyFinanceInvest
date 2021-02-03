using MyFinanceInvest.Data.Context.Config;
using MyFinanceInvest.Domain.Entities;
using MyFinanceInvest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFinanceInvest.Repository
{
    public class BankRepository : IBankRepository
    {
        private readonly ContextManager _context;

        public BankRepository(ContextManager context)
        {
            _context = context;
        }

        public Task<List<BankInfo>> All()
        {
            return Task.Run(() => _context.Bank.OrderBy(o => o.Id).ToList());
        }

        public Task<bool> Delete(int id)
        {
            return Task.Run(() =>
            {
                BankInfo bank = _context.Bank.Where(w => w.Id == id).FirstOrDefault();

                _context.Remove(bank);
                _context.SaveChanges();

                return true;
            });
        }

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (_context == null) return;
            _context.Dispose();
        }

        #endregion Dispose

        public Task<List<BankInfo>> Find(Expression<Func<BankInfo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<BankInfo> Get(int id)
        {
            return Task.Run(() => _context.Bank.Where(w => w.Id == id).FirstOrDefault());
        }

        public Task<bool> Save(BankInfo info)
        {
            return Task.Run(() =>
            {
                _context.Add(info);
                _context.SaveChanges();

                return true;
            });
        }

        public Task<bool> Update(BankInfo info)
        {
            return Task.Run(() =>
            {
                _context.Update(info);
                _context.SaveChanges();

                return true;
            });
        }
    }
}