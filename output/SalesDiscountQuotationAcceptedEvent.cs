using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند قبول عرض سعر
    /// </summary>
    public class SalesDiscountQuotationAcceptedEvent : DomainEventBase
    {
    public SalesDiscountId SalesDiscountId { get; }

        public SalesDiscountQuotationAcceptedEvent(SalesDiscountId salesdiscountId)
        {
        SalesDiscountId = salesdiscountId;
        }
    }
}