using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إصدار عرض سعر
    /// </summary>
    public class CustomerQuotationIssuedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerQuotationIssuedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}