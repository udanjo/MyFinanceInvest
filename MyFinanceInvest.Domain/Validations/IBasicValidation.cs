using System.Threading.Tasks;

namespace MyFinanceInvest.Domain.Helper
{
    public interface IBasicValidation<T> where T : class
    {
        Task<bool> ValidateId(T info);
        Task<bool> ValidateSave(T info);

    }
}
