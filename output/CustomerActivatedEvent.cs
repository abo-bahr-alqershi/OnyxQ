using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تفعيل الكيان
    /// </summary>
    public class CustomerActivatedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public CustomerActivatedEvent(CustomerId customerId, string previousstatus, string newstatus)
        {
        CustomerId = customerId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}