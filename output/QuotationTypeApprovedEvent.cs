using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند الموافقة على الكيان
    /// </summary>
    public class QuotationTypeApprovedEvent : DomainEventBase
    {
    public QuotationTypeId QuotationTypeId { get; }

        public QuotationTypeApprovedEvent(QuotationTypeId quotationtypeId)
        {
        QuotationTypeId = quotationtypeId;
        }
    }
}