using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية
    /// </summary>
    public class CustomerStatusChangedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public CustomerStatusChangedEvent(CustomerId customerId, string previousstatus, string newstatus)
        {
        CustomerId = customerId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}