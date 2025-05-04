using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تطبيق خصم
    /// </summary>
    public class CustomerDiscountAppliedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerDiscountAppliedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}