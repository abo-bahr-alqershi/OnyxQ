using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إنشاء كيان جديد
    /// </summary>
    public class CustomerCreatedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerCreatedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}