using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند أرشفة الكيان
    /// </summary>
    public class QuotationTypeArchivedEvent : DomainEventBase
    {
    public QuotationTypeId QuotationTypeId { get; }

        public QuotationTypeArchivedEvent(QuotationTypeId quotationtypeId)
        {
        QuotationTypeId = quotationtypeId;
        }
    }
}