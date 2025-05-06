using System;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateCurrency
{
    /// <summary>
    /// أمر إنشاء عملة جديدة
    /// </summary>
    public class CreateCurrencyCommand : IRequest<Guid>
    {
        // المعلومات الأساسية
        public string Code { get; set; }
        public string InternationalCode { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Symbol { get; set; }
        public string Country { get; set; }
        public bool IsBaseCurrency { get; set; }
        public string Notes { get; set; }

        // خصائص العملة
        public int DecimalPlaces { get; set; } = 2;
        public string ThousandsSeparator { get; set; } = ",";
        public string DecimalSeparator { get; set; } = ".";
        public string SymbolPosition { get; set; } = "Before";
        public string SubUnit { get; set; }
        public decimal SubUnitValue { get; set; } = 0.01m;
        public bool ShowDecimalZeros { get; set; } = true;
        public bool AddSpaceBetweenSymbolAndAmount { get; set; } = false;

        // أسعار الصرف
        public decimal ExchangeRate { get; set; } = 1;
    }
} 