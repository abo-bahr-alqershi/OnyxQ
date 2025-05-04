using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند استلام دفعة
    /// </summary>
    public class QuotationPaymentReceivedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }
    public decimal Amount { get; }
    public string Currency { get; }

        public QuotationPaymentReceivedEvent(QuotationId quotationId, decimal amount, string currency)
        {
        QuotationId = quotationId;
        Amount = amount;
        Currency = currency;
        }
    }
}