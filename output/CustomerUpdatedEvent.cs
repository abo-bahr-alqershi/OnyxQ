using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تحديث بيانات الكيان
    /// </summary>
    public class CustomerUpdatedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerUpdatedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}