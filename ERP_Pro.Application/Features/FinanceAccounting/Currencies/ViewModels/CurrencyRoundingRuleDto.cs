using System;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels
{
    /// <summary>
    /// نموذج عرض قاعدة تقريب العملة
    /// </summary>
    public class CurrencyRoundingRuleDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }

        /// <summary>
        /// نوع التقريب
        /// </summary>
        public string RoundingType { get; set; }

        /// <summary>
        /// وصف قاعدة التقريب
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// قيمة التقريب
        /// </summary>
        public decimal RoundingValue { get; set; }

        /// <summary>
        /// عدد المنازل العشرية
        /// </summary>
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// مفعلة
        /// </summary>
        public bool IsActive { get; set; }
    }
} 