using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان
    /// </summary>
    public class SalesDiscountDeactivatedEvent : DomainEventBase
    {
    public SalesDiscountId SalesDiscountId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public SalesDiscountDeactivatedEvent(SalesDiscountId salesdiscountId, string previousstatus, string newstatus)
        {
        SalesDiscountId = salesdiscountId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}