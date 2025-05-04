using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تفعيل الكيان
    /// </summary>
    public class QuotationTypeActivatedEvent : DomainEventBase
    {
    public QuotationTypeId QuotationTypeId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public QuotationTypeActivatedEvent(QuotationTypeId quotationtypeId, string previousstatus, string newstatus)
        {
        QuotationTypeId = quotationtypeId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}