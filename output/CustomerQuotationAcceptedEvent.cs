using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند قبول عرض سعر
    /// </summary>
    public class CustomerQuotationAcceptedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerQuotationAcceptedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}