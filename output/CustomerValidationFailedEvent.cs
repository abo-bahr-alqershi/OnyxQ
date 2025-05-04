using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند فشل التحقق من الكيان
    /// </summary>
    public class CustomerValidationFailedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerValidationFailedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}