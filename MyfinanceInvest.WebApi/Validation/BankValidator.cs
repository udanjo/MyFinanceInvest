using FluentValidation;
using MyfinanceInvest.WebApi.Request;

namespace MyfinanceInvest.WebApi.Infra.Validation
{
    public class BankValidator : AbstractValidator<BankRequest>
    {

        public BankValidator()
        {
            RuleFor(m => m.Code).NotEmpty().WithMessage("Código é campo obrigatório!").MinimumLength(2).MaximumLength(5);
            RuleFor(m => m.Description).NotEmpty().WithMessage("Descrição é campo obrigatório!").MinimumLength(1).MaximumLength(250); ;
        }
    }
}
