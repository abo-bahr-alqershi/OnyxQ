using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PromotionCustomer entity
/// </summary>
public sealed class PromotionCustomerCreatedEvent : DomainEvent
{
    public PromotionCustomerId PromotionCustomerId { get; }

    public PromotionCustomerCreatedEvent(PromotionCustomerId promotioncustomerId)
    {
        PromotionCustomerId = promotioncustomerId;
    }
}

public sealed class PromotionCustomerUpdatedEvent : DomainEvent
{
    public PromotionCustomerId PromotionCustomerId { get; }

    public PromotionCustomerUpdatedEvent(PromotionCustomerId promotioncustomerId)
    {
        PromotionCustomerId = promotioncustomerId;
    }
}

public sealed class PromotionCustomerDeletedEvent : DomainEvent
{
    public PromotionCustomerId PromotionCustomerId { get; }

    public PromotionCustomerDeletedEvent(PromotionCustomerId promotioncustomerId)
    {
        PromotionCustomerId = promotioncustomerId;
    }
}
}
