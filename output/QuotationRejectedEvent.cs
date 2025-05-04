using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند رفض الكيان
    /// </summary>
    public class QuotationRejectedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationRejectedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}