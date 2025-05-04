using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCostCenterLimit entity
/// </summary>
public sealed class CustomerCostCenterLimitCreatedEvent : DomainEvent
{
    public CustomerCostCenterLimitId CustomerCostCenterLimitId { get; }

    public CustomerCostCenterLimitCreatedEvent(CustomerCostCenterLimitId customercostcenterlimitId)
    {
        CustomerCostCenterLimitId = customercostcenterlimitId;
    }
}

public sealed class CustomerCostCenterLimitUpdatedEvent : DomainEvent
{
    public CustomerCostCenterLimitId CustomerCostCenterLimitId { get; }

    public CustomerCostCenterLimitUpdatedEvent(CustomerCostCenterLimitId customercostcenterlimitId)
    {
        CustomerCostCenterLimitId = customercostcenterlimitId;
    }
}

public sealed class CustomerCostCenterLimitDeletedEvent : DomainEvent
{
    public CustomerCostCenterLimitId CustomerCostCenterLimitId { get; }

    public CustomerCostCenterLimitDeletedEvent(CustomerCostCenterLimitId customercostcenterlimitId)
    {
        CustomerCostCenterLimitId = customercostcenterlimitId;
    }
}
}
