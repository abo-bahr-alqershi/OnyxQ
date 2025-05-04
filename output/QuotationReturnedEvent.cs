using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إرجاع الكيان بعد المراجعة
    /// </summary>
    public class QuotationReturnedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationReturnedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}