using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// حدود مخاطر العملة
    /// </summary>
    public class CurrencyRiskLimit : Entity<CurrencyRiskLimitId>
    {
        // Private constructor for EF Core
        private CurrencyRiskLimit() { }

        /// <summary>
        /// إنشاء حد مخاطر جديد للعملة
        /// </summary>
        public CurrencyRiskLimit(
            CurrencyRiskLimitId id,
            CurrencyId currencyId,
            decimal maxDailyFluctuation,
            decimal alertThreshold,
            decimal maxExposure,
            string notes)
        {
            Id = id;
            CurrencyId = currencyId;
            MaxDailyFluctuation = maxDailyFluctuation;
            AlertThreshold = alertThreshold;
            MaxExposure = maxExposure;
            Notes = notes;
            IsActive = true;
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public CurrencyId CurrencyId { get; private set; }

        /// <summary>
        /// الحد الأقصى للتقلب اليومي (النسبة المئوية)
        /// </summary>
        public decimal MaxDailyFluctuation { get; private set; }

        /// <summary>
        /// عتبة التنبيه (النسبة المئوية)
        /// </summary>
        public decimal AlertThreshold { get; private set; }

        /// <summary>
        /// الحد الأقصى للتعرض للمخاطر
        /// </summary>
        public decimal MaxExposure { get; private set; }

        /// <summary>
        /// هل الحد نشط
        /// </summary>
        public bool IsActive { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ الحد
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime LastModifiedOn { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل
        /// </summary>
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// تحديث حدود المخاطر
        /// </summary>
        public void Update(
            decimal maxDailyFluctuation,
            decimal alertThreshold,
            decimal maxExposure,
            string notes)
        {
            MaxDailyFluctuation = maxDailyFluctuation;
            AlertThreshold = alertThreshold;
            MaxExposure = maxExposure;
            Notes = notes;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// تفعيل حد المخاطر
        /// </summary>
        public void Activate()
        {
            IsActive = true;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// تعطيل حد المخاطر
        /// </summary>
        public void Deactivate()
        {
            IsActive = false;
            LastModifiedOn = DateTime.UtcNow;
        }
    }
} 