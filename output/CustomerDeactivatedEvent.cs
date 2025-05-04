using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان
    /// </summary>
    public class CustomerDeactivatedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public CustomerDeactivatedEvent(CustomerId customerId, string previousstatus, string newstatus)
        {
        CustomerId = customerId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}