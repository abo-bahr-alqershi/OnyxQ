using System;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.Currencies.Dtos
{
    /// <summary>
    /// DTO العملة
    /// </summary>
    public class CurrencyDto
    {
        /// <summary>
        /// المعرف الفريد
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// الرمز
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// الرمز الدولي
        /// </summary>
        public string IsoCode { get; set; }

        /// <summary>
        /// الاسم بالعربية
        /// </summary>
        public string NameAr { get; set; }

        /// <summary>
        /// الاسم بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// الرمز المختصر
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// الدولة
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// هل هي العملة الأساسية
        /// </summary>
        public bool IsBaseCurrency { get; set; }

        /// <summary>
        /// حالة العملة
        /// </summary>
        public CurrencyStatusEnum Status { get; set; }

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

        /// <summary>
        /// سعر الصرف الحالي
        /// </summary>
        public decimal CurrentExchangeRate { get; set; }

        /// <summary>
        /// تاريخ آخر تحديث لسعر الصرف
        /// </summary>
        public DateTime LastExchangeRateUpdate { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 