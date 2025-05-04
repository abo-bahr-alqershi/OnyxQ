using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إرجاع طلب
    /// </summary>
    public class CustomerOrderReturnedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerOrderReturnedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}