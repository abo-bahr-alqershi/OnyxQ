using System;
using System.Collections.Generic;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels
{
    /// <summary>
    /// DTO لعرض التفاصيل الكاملة للعملة
    /// </summary>
    public class CurrencyDetailsDto
    {
        // المعلومات الأساسية
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string InternationalCode { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Symbol { get; set; }
        public string Country { get; set; }
        public bool IsBase { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }

        // خصائص العملة
        public int DecimalPlaces { get; set; }
        public string ThousandsSeparator { get; set; }
        public string DecimalSeparator { get; set; }
        public string SymbolPosition { get; set; }
        public string SubUnit { get; set; }
        public decimal SubUnitValue { get; set; }
        public bool ShowDecimalZeros { get; set; }
        public bool AddSpaceBetweenSymbolAndAmount { get; set; }

        // قواعد التقريب
        public string RoundingType { get; set; }
        public decimal RoundingUnit { get; set; }
        public string RoundingAppliedTo { get; set; }
        public decimal? MinRoundingAmount { get; set; }
        public decimal? MaxRoundingAmount { get; set; }
        public Guid? RoundingDifferenceAccountId { get; set; }
        public string RoundingDifferenceAccountName { get; set; }

        // تحويل المبالغ لكلمات
        public string AmountToWordsTemplateAr { get; set; }
        public string AmountToWordsTemplateEn { get; set; }
        public bool WriteSubUnitInWords { get; set; }
        public string SubUnitSeparator { get; set; }
        public string GenderOptions { get; set; }

        // الحسابات المرتبطة
        public Guid? ExchangeRateGainAccountId { get; set; }
        public string ExchangeRateGainAccountName { get; set; }
        public Guid? ExchangeRateLossAccountId { get; set; }
        public string ExchangeRateLossAccountName { get; set; }
        public Guid? CurrencyRevaluationAccountId { get; set; }
        public string CurrencyRevaluationAccountName { get; set; }
        public Guid? RoundingAccountId { get; set; }
        public string RoundingAccountName { get; set; }
        public Guid? CurrencySettlementAccountId { get; set; }
        public string CurrencySettlementAccountName { get; set; }

        // أسعار الصرف
        public List<CurrencyExchangeRateDto> ExchangeRates { get; set; }

        // معلومات النظام
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public CurrencyDetailsDto()
        {
            ExchangeRates = new List<CurrencyExchangeRateDto>();
        }
    }
} 