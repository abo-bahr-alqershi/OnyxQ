using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند أرشفة الكيان
    /// </summary>
    public class SalesDiscountArchivedEvent : DomainEventBase
    {
    public SalesDiscountId SalesDiscountId { get; }

        public SalesDiscountArchivedEvent(SalesDiscountId salesdiscountId)
        {
        SalesDiscountId = salesdiscountId;
        }
    }
}