using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي)
    /// </summary>
    public class QuotationDeletedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationDeletedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}