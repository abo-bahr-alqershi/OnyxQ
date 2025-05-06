using FluentValidation;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateRiskLimit
{
    /// <summary>
    /// مدقق لأمر إنشاء حد مخاطر جديد للعملة
    /// </summary>
    public class CreateRiskLimitCommandValidator : AbstractValidator<CreateRiskLimitCommand>
    {
        public CreateRiskLimitCommandValidator()
        {
            RuleFor(v => v.CurrencyId)
                .NotEmpty().WithMessage("معرف العملة مطلوب");

            RuleFor(v => v.MinRate)
                .GreaterThan(0).WithMessage("الحد الأدنى لسعر الصرف يجب أن يكون أكبر من صفر");

            RuleFor(v => v.MaxRate)
                .GreaterThan(v => v.MinRate).WithMessage("الحد الأقصى لسعر الصرف يجب أن يكون أكبر من الحد الأدنى");

            RuleFor(v => v.TargetRate)
                .GreaterThan(0).WithMessage("سعر الصرف المستهدف يجب أن يكون أكبر من صفر")
                .Must((command, targetRate) => targetRate >= command.MinRate && targetRate <= command.MaxRate)
                .WithMessage("سعر الصرف المستهدف يجب أن يكون بين الحد الأدنى والحد الأقصى");

            RuleFor(v => v.WarningThreshold)
                .GreaterThanOrEqualTo(0).WithMessage("عتبة التحذير يجب أن تكون أكبر من أو تساوي صفر")
                .LessThanOrEqualTo(100).WithMessage("عتبة التحذير يجب أن تكون أقل من أو تساوي 100");
        }
    }
} 