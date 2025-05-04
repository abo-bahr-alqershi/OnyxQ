using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إصدار دفعة
    /// </summary>
    public class CustomerPaymentIssuedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }
    public decimal Amount { get; }
    public string Currency { get; }

        public CustomerPaymentIssuedEvent(CustomerId customerId, decimal amount, string currency)
        {
        CustomerId = customerId;
        Amount = amount;
        Currency = currency;
        }
    }
}