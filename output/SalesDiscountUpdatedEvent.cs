using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تحديث بيانات الكيان
    /// </summary>
    public class SalesDiscountUpdatedEvent : DomainEventBase
    {
    public SalesDiscountId SalesDiscountId { get; }

        public SalesDiscountUpdatedEvent(SalesDiscountId salesdiscountId)
        {
        SalesDiscountId = salesdiscountId;
        }
    }
}