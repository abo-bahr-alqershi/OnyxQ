using System;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels
{
    /// <summary>
    /// نموذج عرض حد مخاطر العملة
    /// </summary>
    public class CurrencyRiskLimitDto
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
        /// رمز العملة
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// الحد الأدنى لسعر الصرف
        /// </summary>
        public decimal MinRate { get; set; }

        /// <summary>
        /// الحد الأعلى لسعر الصرف
        /// </summary>
        public decimal MaxRate { get; set; }

        /// <summary>
        /// نسبة التحذير (%)
        /// </summary>
        public decimal WarningThreshold { get; set; }

        /// <summary>
        /// سعر المستهدف
        /// </summary>
        public decimal TargetRate { get; set; }

        /// <summary>
        /// هل التنبيه مفعل؟
        /// </summary>
        public bool AlertEnabled { get; set; }

        /// <summary>
        /// تاريخ آخر تحديث
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// محدث بواسطة
        /// </summary>
        public string UpdatedBy { get; set; }
    }
} 