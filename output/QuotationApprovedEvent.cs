using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند الموافقة على الكيان
    /// </summary>
    public class QuotationApprovedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationApprovedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}