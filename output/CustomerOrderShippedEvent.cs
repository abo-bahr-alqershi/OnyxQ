using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند شحن طلب
    /// </summary>
    public class CustomerOrderShippedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerOrderShippedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}