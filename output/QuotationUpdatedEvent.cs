using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تحديث بيانات الكيان
    /// </summary>
    public class QuotationUpdatedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationUpdatedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}