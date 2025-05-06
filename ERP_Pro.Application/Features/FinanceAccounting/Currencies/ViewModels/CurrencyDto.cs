using System;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels
{
    /// <summary>
    /// DTO لعرض بيانات العملة في القوائم
    /// </summary>
    public class CurrencyDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Symbol { get; set; }
        public string Country { get; set; }
        public bool IsBase { get; set; }
        public bool IsActive { get; set; }
        public int DecimalPlaces { get; set; }
        public decimal? ExchangeRate { get; set; }
        public DateTime? LastExchangeRateUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
} 