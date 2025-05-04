using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إنشاء طلب
    /// </summary>
    public class CustomerOrderPlacedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerOrderPlacedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}