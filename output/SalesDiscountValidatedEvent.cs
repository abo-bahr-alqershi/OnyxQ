using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان
    /// </summary>
    public class SalesDiscountValidatedEvent : DomainEventBase
    {
    public SalesDiscountId SalesDiscountId { get; }

        public SalesDiscountValidatedEvent(SalesDiscountId salesdiscountId)
        {
        SalesDiscountId = salesdiscountId;
        }
    }
}