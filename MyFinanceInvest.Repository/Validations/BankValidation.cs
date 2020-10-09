using MyFinanceInvest.Domain.Entities;
using MyFinanceInvest.Domain.Validation.Interfaces;
using System.Threading.Tasks;

namespace MyFinanceInvest.Domain.Validation
{
    public class BankValidation : IBankValidation
    {
        public Task<bool> ValidateId(BankInfo info)
        {
            return Task.Run(() =>
            {
                if (info.Id == 0)
                {
                    //info.Message = "Informe o Código!";
                    //info.TypeMessage = Enums.TypeMessageEnum.Warning;
                    return false;
                }

                //info.Message = string.Empty;
                //info.TypeMessage = Enums.TypeMessageEnum.None;
                return true;
            });
        }

        public Task<bool> ValidateSave(BankInfo info)
        {
            return Task.Run(() =>
            {
                bool valid = true;

                if (string.IsNullOrEmpty(info.Code))
                {
                    //info.Message = "Informe o Código!";
                    //info.TypeMessage = Enums.TypeMessageEnum.Warning;
                    valid = false;
                }
                else if (string.IsNullOrEmpty(info.Description))
                {
                    //info.Message = "Informe a Descrição!";
                    //info.TypeMessage = Enums.TypeMessageEnum.Warning;
                    valid = false;
                }

                return valid;
            });
        }
    }
}
