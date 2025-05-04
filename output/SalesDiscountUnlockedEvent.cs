using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء قفل الكيان
    /// </summary>
    public class SalesDiscountUnlockedEvent : DomainEventBase
    {
    public SalesDiscountId SalesDiscountId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public SalesDiscountUnlockedEvent(SalesDiscountId salesdiscountId, string previousstatus, string newstatus)
        {
        SalesDiscountId = salesdiscountId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}