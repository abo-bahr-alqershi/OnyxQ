using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان
    /// </summary>
    public class QuotationTypeValidatedEvent : DomainEventBase
    {
    public QuotationTypeId QuotationTypeId { get; }

        public QuotationTypeValidatedEvent(QuotationTypeId quotationtypeId)
        {
        QuotationTypeId = quotationtypeId;
        }
    }
}