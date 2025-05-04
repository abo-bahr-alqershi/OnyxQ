using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند أرشفة الكيان
    /// </summary>
    public class QuotationArchivedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationArchivedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}