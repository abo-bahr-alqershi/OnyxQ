using System;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.AddExchangeRate
{
    /// <summary>
    /// أمر إضافة سعر صرف جديد للعملة
    /// </summary>
    public class AddExchangeRateCommand : IRequest<Guid>
    {
        public Guid CurrencyId { get; set; }
        public DateTime EffectiveDate { get; set; } = DateTime.UtcNow;
        public string RateType { get; set; } = "Base";
        public decimal Rate { get; set; }
        public string Source { get; set; } = "Manual";
        public string Notes { get; set; }
    }
} 