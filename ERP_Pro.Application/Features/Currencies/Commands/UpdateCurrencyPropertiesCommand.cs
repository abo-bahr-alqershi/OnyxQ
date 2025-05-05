using System;
using MediatR;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر تحديث خصائص العملة
    /// </summary>
    public class UpdateCurrencyPropertiesCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// عدد الخانات العشرية
        /// </summary>
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// فاصل الآلاف
        /// </summary>
        public string ThousandsSeparator { get; set; }

        /// <summary>
        /// فاصل الكسور العشرية
        /// </summary>
        public string DecimalSeparator { get; set; }

        /// <summary>
        /// موقع عرض الرمز
        /// </summary>
        public CurrencySymbolPositionEnum SymbolPosition { get; set; }

        /// <summary>
        /// الوحدة الفرعية للعملة
        /// </summary>
        public string FractionName { get; set; }

        /// <summary>
        /// قيمة الوحدة الفرعية
        /// </summary>
        public decimal FractionValue { get; set; }

        /// <summary>
        /// إضافة فراغ بين الرمز والقيمة
        /// </summary>
        public bool UseSpaceBetweenSymbolAndValue { get; set; }

        /// <summary>
        /// إظهار الأصفار العشرية
        /// </summary>
        public bool ShowTrailingZeros { get; set; }
    }
} 