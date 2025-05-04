using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء قفل الكيان
    /// </summary>
    public class QuotationUnlockedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public QuotationUnlockedEvent(QuotationId quotationId, string previousstatus, string newstatus)
        {
        QuotationId = quotationId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}