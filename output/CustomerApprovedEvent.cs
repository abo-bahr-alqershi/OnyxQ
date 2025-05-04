using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند الموافقة على الكيان
    /// </summary>
    public class CustomerApprovedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerApprovedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}