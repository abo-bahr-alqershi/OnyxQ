using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند قفل الكيان
    /// </summary>
    public class SalesDiscountLockedEvent : DomainEventBase
    {
    public SalesDiscountId SalesDiscountId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public SalesDiscountLockedEvent(SalesDiscountId salesdiscountId, string previousstatus, string newstatus)
        {
        SalesDiscountId = salesdiscountId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}