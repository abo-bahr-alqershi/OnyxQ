using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تقديم الكيان للموافقة
    /// </summary>
    public class CustomerSubmittedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerSubmittedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}