using MyFinanceInvest.Domain.Entities;
using MyFinanceInvest.Repository.Interfaces;
using MyFinanceInvest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFinanceInvest.Service
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankService(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public Task<List<BankInfo>> All()
        {
            return _bankRepository.All();
        }

        public Task<bool> Delete(int id)
        {
            return Task.Run(() => _bankRepository.Delete(id).Result);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task<List<BankInfo>> Find(Expression<Func<BankInfo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<BankInfo> Get(int id)
        {
            return Task.Run(() => _bankRepository.Get(id).Result);
        }

        public Task<bool> Save(BankInfo info)
        {
            return Task.Run(() => _bankRepository.Save(info).Result);
        }

        public Task<bool> Update(BankInfo info)
        {
            return Task.Run(() => _bankRepository.Update(info).Result);
        }
    }
}