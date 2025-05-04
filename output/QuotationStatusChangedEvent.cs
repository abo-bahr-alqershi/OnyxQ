using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية
    /// </summary>
    public class QuotationStatusChangedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }
    public string PreviousStatus { get; }
    public string NewStatus { get; }

        public QuotationStatusChangedEvent(QuotationId quotationId, string previousstatus, string newstatus)
        {
        QuotationId = quotationId;
        PreviousStatus = previousstatus;
        NewStatus = newstatus;
        }
    }
}