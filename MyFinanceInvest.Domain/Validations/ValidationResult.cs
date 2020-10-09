using MyFinanceInvest.Domain.Enums;

namespace MyFinanceInvest.Domain.Entities
{
    public class ValidationResult
    {
        public string Message { get; set; }

        public TypeMessageEnum TypeMessage { get; set; }
    }
}
