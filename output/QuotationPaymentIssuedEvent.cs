using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إصدار دفعة
    /// </summary>
    public class QuotationPaymentIssuedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }
    public decimal Amount { get; }
    public string Currency { get; }

        public QuotationPaymentIssuedEvent(QuotationId quotationId, decimal amount, string currency)
        {
        QuotationId = quotationId;
        Amount = amount;
        Currency = currency;
        }
    }
}