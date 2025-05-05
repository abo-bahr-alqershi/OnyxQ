using System;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.Currencies.Dtos
{
    /// <summary>
    /// DTO قاعدة تقريب العملة
    /// </summary>
    public class CurrencyRoundingRuleDto
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
        /// نوع التقريب
        /// </summary>
        public CurrencyRoundingTypeEnum RoundingType { get; set; }

        /// <summary>
        /// وحدة التقريب
        /// </summary>
        public decimal RoundingUnit { get; set; }

        /// <summary>
        /// الحد الأدنى للمبلغ الذي تنطبق عليه القاعدة
        /// </summary>
        public decimal? MinAmount { get; set; }

        /// <summary>
        /// الحد الأقصى للمبلغ الذي تنطبق عليه القاعدة
        /// </summary>
        public decimal? MaxAmount { get; set; }

        /// <summary>
        /// رقم حساب فروق التقريب
        /// </summary>
        public string RoundingAccount { get; set; }
    }
} 