using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان
    /// </summary>
    public class QuotationValidatedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationValidatedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}