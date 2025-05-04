using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند احتساب الضريبة
    /// </summary>
    public class QuotationTypeTaxCalculatedEvent : DomainEventBase
    {
    public QuotationTypeId QuotationTypeId { get; }
    public decimal Amount { get; }
    public string Currency { get; }

        public QuotationTypeTaxCalculatedEvent(QuotationTypeId quotationtypeId, decimal amount, string currency)
        {
        QuotationTypeId = quotationtypeId;
        Amount = amount;
        Currency = currency;
        }
    }
}