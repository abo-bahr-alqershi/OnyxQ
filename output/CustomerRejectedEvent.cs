using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند رفض الكيان
    /// </summary>
    public class CustomerRejectedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerRejectedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}