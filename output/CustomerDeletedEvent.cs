using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي)
    /// </summary>
    public class CustomerDeletedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerDeletedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}