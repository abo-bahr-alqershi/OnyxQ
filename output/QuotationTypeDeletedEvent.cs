using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي)
    /// </summary>
    public class QuotationTypeDeletedEvent : DomainEventBase
    {
    public QuotationTypeId QuotationTypeId { get; }

        public QuotationTypeDeletedEvent(QuotationTypeId quotationtypeId)
        {
        QuotationTypeId = quotationtypeId;
        }
    }
}