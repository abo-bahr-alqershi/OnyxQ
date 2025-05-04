using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند فشل التحقق من الكيان
    /// </summary>
    public class QuotationValidationFailedEvent : DomainEventBase
    {
    public QuotationId QuotationId { get; }

        public QuotationValidationFailedEvent(QuotationId quotationId)
        {
        QuotationId = quotationId;
        }
    }
}