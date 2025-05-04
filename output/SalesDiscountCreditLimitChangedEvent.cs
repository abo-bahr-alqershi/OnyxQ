using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغيير حد الائتمان
    /// </summary>
    public class SalesDiscountCreditLimitChangedEvent : DomainEventBase
    {
    public SalesDiscountId SalesDiscountId { get; }
    public decimal Amount { get; }
    public string Currency { get; }

        public SalesDiscountCreditLimitChangedEvent(SalesDiscountId salesdiscountId, decimal amount, string currency)
        {
        SalesDiscountId = salesdiscountId;
        Amount = amount;
        Currency = currency;
        }
    }
}