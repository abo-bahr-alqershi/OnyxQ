using System;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels
{
    /// <summary>
    /// DTO لعرض بيانات أسعار صرف العملة
    /// </summary>
    public class CurrencyExchangeRateDto
    {
        public Guid Id { get; set; }
        public Guid CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string RateType { get; set; }
        public decimal Rate { get; set; }
        public string Source { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
    }
} 