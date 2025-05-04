using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند أرشفة الكيان
    /// </summary>
    public class CustomerArchivedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerArchivedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}