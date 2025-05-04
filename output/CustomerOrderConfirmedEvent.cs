using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Events
{
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تأكيد طلب
    /// </summary>
    public class CustomerOrderConfirmedEvent : DomainEventBase
    {
    public CustomerId CustomerId { get; }

        public CustomerOrderConfirmedEvent(CustomerId customerId)
        {
        CustomerId = customerId;
        }
    }
}