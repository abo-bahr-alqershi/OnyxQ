using FluentValidation;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateRoundingRule
{
    /// <summary>
    /// مدقق لأمر إنشاء قاعدة تقريب جديدة للعملة
    /// </summary>
    public class CreateRoundingRuleCommandValidator : AbstractValidator<CreateRoundingRuleCommand>
    {
        public CreateRoundingRuleCommandValidator()
        {
            RuleFor(v => v.CurrencyId)
                .NotEmpty().WithMessage("معرف العملة مطلوب");

            RuleFor(v => v.RoundingType)
                .NotEmpty().WithMessage("نوع التقريب مطلوب")
                .MaximumLength(50).WithMessage("نوع التقريب يجب أن لا يتجاوز 50 حرف");

            RuleFor(v => v.RoundingValue)
                .GreaterThan(0).WithMessage("قيمة التقريب يجب أن تكون أكبر من صفر");

            RuleFor(v => v.MinAmount)
                .GreaterThanOrEqualTo(0).WithMessage("الحد الأدنى للمبلغ يجب أن يكون أكبر من أو يساوي صفر");

            RuleFor(v => v.MaxAmount)
                .GreaterThan(v => v.MinAmount).WithMessage("الحد الأقصى للمبلغ يجب أن يكون أكبر من الحد الأدنى")
                .When(v => v.MaxAmount.HasValue && v.MinAmount.HasValue);

            RuleFor(v => v.Description)
                .MaximumLength(500).WithMessage("الوصف يجب أن لا يتجاوز 500 حرف");
        }
    }
} 