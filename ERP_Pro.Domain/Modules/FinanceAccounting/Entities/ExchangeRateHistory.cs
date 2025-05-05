using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// تاريخ أسعار الصرف
    /// </summary>
    public class ExchangeRateHistory : Entity<ExchangeRateHistoryId>
    {
        // Private constructor for EF Core
        private ExchangeRateHistory() { }

        /// <summary>
        /// إنشاء سجل تاريخي جديد لسعر الصرف
        /// </summary>
        public ExchangeRateHistory(
            ExchangeRateHistoryId id,
            CurrencyId currencyId,
            decimal rate,
            DateTime effectiveDate,
            ExchangeRateTypeEnum rateType,
            ExchangeRateSourceEnum source)
        {
            Id = id;
            CurrencyId = currencyId;
            Rate = rate;
            EffectiveDate = effectiveDate;
            RateType = rateType;
            Source = source;
            RecordedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public CurrencyId CurrencyId { get; private set; }

        /// <summary>
        /// سعر الصرف
        /// </summary>
        public decimal Rate { get; private set; }

        /// <summary>
        /// تاريخ سريان سعر الصرف
        /// </summary>
        public DateTime EffectiveDate { get; private set; }

        /// <summary>
        /// نوع سعر الصرف
        /// </summary>
        public ExchangeRateTypeEnum RateType { get; private set; }

        /// <summary>
        /// مصدر سعر الصرف
        /// </summary>
        public ExchangeRateSourceEnum Source { get; private set; }

        /// <summary>
        /// معرف المصدر الخارجي (إذا كان من API أو ملف مستورد)
        /// </summary>
        public string ExternalSourceId { get; private set; }

        /// <summary>
        /// المستخدم الذي سجل سعر الصرف
        /// </summary>
        public string RecordedBy { get; private set; }

        /// <summary>
        /// وقت تسجيل سعر الصرف
        /// </summary>
        public DateTime RecordedOn { get; private set; }

        /// <summary>
        /// ملاحظات إضافية
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// تعيين معرف المصدر الخارجي والملاحظات
        /// </summary>
        public void SetExternalSourceInfo(string externalSourceId, string notes)
        {
            ExternalSourceId = externalSourceId;
            Notes = notes;
        }
    }
} 