using System;
using FluentValidation;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateCurrency
{
    /// <summary>
    /// مدقق لأمر إنشاء عملة جديدة
    /// </summary>
    public class CreateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
    {
        public CreateCurrencyCommandValidator()
        {
            RuleFor(v => v.Code)
                .NotEmpty().WithMessage("رمز العملة مطلوب")
                .MaximumLength(10).WithMessage("رمز العملة يجب أن لا يتجاوز 10 أحرف")
                .Matches("^[A-Za-z0-9]*$").WithMessage("رمز العملة يجب أن يحتوي على أحرف وأرقام فقط");

            RuleFor(v => v.NameAr)
                .NotEmpty().WithMessage("اسم العملة بالعربية مطلوب")
                .MaximumLength(100).WithMessage("اسم العملة بالعربية يجب أن لا يتجاوز 100 حرف");

            RuleFor(v => v.NameEn)
                .MaximumLength(100).WithMessage("اسم العملة بالإنجليزية يجب أن لا يتجاوز 100 حرف");

            RuleFor(v => v.Symbol)
                .MaximumLength(10).WithMessage("رمز العملة المختصر يجب أن لا يتجاوز 10 أحرف");

            RuleFor(v => v.Country)
                .MaximumLength(100).WithMessage("اسم الدولة يجب أن لا يتجاوز 100 حرف");

            RuleFor(v => v.DecimalPlaces)
                .InclusiveBetween(0, 10).WithMessage("عدد المنازل العشرية يجب أن يكون بين 0 و 10");

            RuleFor(v => v.SubUnitValue)
                .GreaterThan(0).WithMessage("قيمة الوحدة الفرعية يجب أن تكون أكبر من صفر");

            RuleFor(v => v.ExchangeRate)
                .GreaterThan(0).WithMessage("سعر الصرف يجب أن يكون أكبر من صفر");

            RuleFor(v => v.SymbolPosition)
                .Must(position => position == "Before" || position == "After")
                .WithMessage("موقع رمز العملة يجب أن يكون 'Before' أو 'After'");
        }
    }
} 