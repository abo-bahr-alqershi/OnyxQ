using FluentValidation;
using System;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateExchangeRate
{
    /// <summary>
    /// مدقق لأمر إنشاء سعر صرف جديد
    /// </summary>
    public class CreateExchangeRateCommandValidator : AbstractValidator<CreateExchangeRateCommand>
    {
        public CreateExchangeRateCommandValidator()
        {
            RuleFor(v => v.CurrencyId)
                .NotEmpty().WithMessage("معرف العملة مطلوب");

            RuleFor(v => v.Rate)
                .GreaterThan(0).WithMessage("سعر الصرف يجب أن يكون أكبر من صفر");

            RuleFor(v => v.EffectiveDate)
                .NotEmpty().WithMessage("تاريخ بدء سريان سعر الصرف مطلوب");

            RuleFor(v => v.RateType)
                .NotEmpty().WithMessage("نوع سعر الصرف مطلوب")
                .MaximumLength(50).WithMessage("نوع سعر الصرف يجب أن لا يتجاوز 50 حرف");

            RuleFor(v => v.Notes)
                .MaximumLength(500).WithMessage("الملاحظات يجب أن لا تتجاوز 500 حرف");
        }
    }
} 