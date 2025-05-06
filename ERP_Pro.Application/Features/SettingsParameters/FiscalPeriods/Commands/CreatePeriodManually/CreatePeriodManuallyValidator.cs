using System;
using FluentValidation;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodManually
{
    /// <summary>
    /// مدقق أمر إنشاء فترة محاسبية يدوياً
    /// </summary>
    public class CreatePeriodManuallyValidator : AbstractValidator<CreatePeriodManuallyCommand>
    {
        /// <summary>
        /// المنشئ
        /// </summary>
        public CreatePeriodManuallyValidator()
        {
            RuleFor(c => c.FiscalYearId)
                .NotEmpty().WithMessage("معرف السنة المالية مطلوب");

            RuleFor(c => c.PeriodNumber)
                .GreaterThan(0).WithMessage("يجب أن يكون رقم الفترة أكبر من صفر");

            RuleFor(c => c.Code)
                .NotEmpty().WithMessage("رمز الفترة مطلوب")
                .MaximumLength(20).WithMessage("يجب ألا يتجاوز رمز الفترة 20 حرفاً")
                .Matches("^[a-zA-Z0-9-_]+$").WithMessage("يجب أن يحتوي رمز الفترة على أحرف وأرقام وشرطات ومسافات فقط");

            RuleFor(c => c.NameAr)
                .NotEmpty().WithMessage("اسم الفترة بالعربية مطلوب")
                .MaximumLength(100).WithMessage("يجب ألا يتجاوز اسم الفترة بالعربية 100 حرف");

            RuleFor(c => c.NameEn)
                .NotEmpty().WithMessage("اسم الفترة بالإنجليزية مطلوب")
                .MaximumLength(100).WithMessage("يجب ألا يتجاوز اسم الفترة بالإنجليزية 100 حرف");

            RuleFor(c => c.StartDate)
                .NotEmpty().WithMessage("تاريخ بداية الفترة مطلوب")
                .LessThanOrEqualTo(c => c.EndDate).WithMessage("تاريخ بداية الفترة يجب أن يكون أقل من أو يساوي تاريخ نهايتها");

            RuleFor(c => c.EndDate)
                .NotEmpty().WithMessage("تاريخ نهاية الفترة مطلوب")
                .GreaterThanOrEqualTo(c => c.StartDate).WithMessage("تاريخ نهاية الفترة يجب أن يكون أكبر من أو يساوي تاريخ بدايتها");

            RuleFor(c => c.PeriodType)
                .IsInEnum().WithMessage("نوع الفترة غير صالح")
                .NotEqual(FiscalPeriodTypeEnum.Unknown).WithMessage("يجب اختيار نوع صالح للفترة");

            RuleFor(c => c.Notes)
                .MaximumLength(500).WithMessage("يجب ألا تتجاوز الملاحظات 500 حرف");
        }
    }
} 