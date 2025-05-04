using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند توصيل طلب
    /// </summary>
    public class CustomerOrderDeliveredEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerOrderDeliveredEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}