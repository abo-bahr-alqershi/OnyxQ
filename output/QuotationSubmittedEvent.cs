using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تقديم الكيان للموافقة
    /// </summary>
    public class QuotationSubmittedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationSubmittedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}