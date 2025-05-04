using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان
    /// </summary>
    public class QuotationDeactivatedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public QuotationDeactivatedEvent(QuotationId quotationId, string previousstatus, string newstatus)
        {
        QuotationId = quotationId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}