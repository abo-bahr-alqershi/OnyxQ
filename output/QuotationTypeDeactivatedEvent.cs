using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان
    /// </summary>
    public class QuotationTypeDeactivatedEvent : DomainEventBase
    {
    public QuotationTypeId QuotationTypeId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public QuotationTypeDeactivatedEvent(QuotationTypeId quotationtypeId, string previousstatus, string newstatus)
        {
        QuotationTypeId = quotationtypeId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}