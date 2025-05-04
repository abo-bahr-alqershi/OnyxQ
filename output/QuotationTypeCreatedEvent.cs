using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إنشاء كيان جديد
    /// </summary>
    public class QuotationTypeCreatedEvent : DomainEventBase
    {
    public QuotationTypeId QuotationTypeId { get; }

        public QuotationTypeCreatedEvent(QuotationTypeId quotationtypeId)
        {
        QuotationTypeId = quotationtypeId;
        }
    }
}