using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند احتساب الضريبة
    /// </summary>
    public class CustomerTaxCalculatedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }
    public decimal Amount { get; }
    public string Currency { get; }

        public CustomerTaxCalculatedEvent(CustomerId customerId, decimal amount, string currency)
        {
        CustomerId = customerId;
        Amount = amount;
        Currency = currency;
        }
    }
}