using System;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.Currencies.Dtos
{
    /// <summary>
    /// DTO تاريخ سعر الصرف
    /// </summary>
    public class ExchangeRateHistoryDto
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
        /// سعر الصرف
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// تاريخ سريان سعر الصرف
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// نوع سعر الصرف
        /// </summary>
        public ExchangeRateTypeEnum RateType { get; set; }

        /// <summary>
        /// مصدر سعر الصرف
        /// </summary>
        public ExchangeRateSourceEnum Source { get; set; }

        /// <summary>
        /// معرف المصدر الخارجي
        /// </summary>
        public string ExternalSourceId { get; set; }

        /// <summary>
        /// المستخدم الذي سجل سعر الصرف
        /// </summary>
        public string RecordedBy { get; set; }

        /// <summary>
        /// وقت تسجيل سعر الصرف
        /// </summary>
        public DateTime RecordedOn { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 