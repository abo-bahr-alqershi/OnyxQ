using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغير الرصيد
    /// </summary>
    public class QuotationBalanceChangedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }
    public decimal Amount { get; }
    public string Currency { get; }

        public QuotationBalanceChangedEvent(QuotationId quotationId, decimal amount, string currency)
        {
        QuotationId = quotationId;
        Amount = amount;
        Currency = currency;
        }
    }
}