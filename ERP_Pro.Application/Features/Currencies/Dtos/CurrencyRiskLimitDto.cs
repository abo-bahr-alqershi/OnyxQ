using System;

namespace ERP_Pro.Application.Features.Currencies.Dtos
{
    /// <summary>
    /// DTO حدود مخاطر العملة
    /// </summary>
    public class CurrencyRiskLimitDto
    {
        /// <summary>
        /// المعرف الفريد
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
        /// اسم العملة
        /// </summary>
        public string CurrencyName { get; set; }

        /// <summary>
        /// الحد الأقصى للتقلب اليومي (النسبة المئوية)
        /// </summary>
        public decimal MaxDailyFluctuation { get; set; }

        /// <summary>
        /// عتبة التنبيه (النسبة المئوية)
        /// </summary>
        public decimal AlertThreshold { get; set; }

        /// <summary>
        /// الحد الأقصى للتعرض للمخاطر
        /// </summary>
        public decimal MaxExposure { get; set; }

        /// <summary>
        /// هل الحد نشط
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// المستخدم الذي أنشأ الحد
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime LastModifiedOn { get; set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل
        /// </summary>
        public string LastModifiedBy { get; set; }
    }
} 