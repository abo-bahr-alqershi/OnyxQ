using FluentValidation;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.ChangeCurrencyStatus
{
    /// <summary>
    /// مدقق لأمر تغيير حالة العملة
    /// </summary>
    public class ChangeCurrencyStatusCommandValidator : AbstractValidator<ChangeCurrencyStatusCommand>
    {
        public ChangeCurrencyStatusCommandValidator()
        {
            RuleFor(v => v.CurrencyId)
                .NotEmpty().WithMessage("معرف العملة مطلوب");
        }
    }
} 