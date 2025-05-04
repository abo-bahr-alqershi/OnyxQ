using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إرجاع الكيان بعد المراجعة
    /// </summary>
    public class CustomerReturnedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerReturnedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}