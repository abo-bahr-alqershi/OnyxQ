using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان
    /// </summary>
    public class CustomerValidatedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerValidatedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}