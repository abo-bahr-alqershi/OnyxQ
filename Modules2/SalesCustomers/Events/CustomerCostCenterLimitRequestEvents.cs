using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCostCenterLimitRequest entity
/// </summary>
public sealed class CustomerCostCenterLimitRequestCreatedEvent : DomainEvent
{
    public CustomerCostCenterLimitRequestId CustomerCostCenterLimitRequestId { get; }

    public CustomerCostCenterLimitRequestCreatedEvent(CustomerCostCenterLimitRequestId customercostcenterlimitrequestId)
    {
        CustomerCostCenterLimitRequestId = customercostcenterlimitrequestId;
    }
}

public sealed class CustomerCostCenterLimitRequestUpdatedEvent : DomainEvent
{
    public CustomerCostCenterLimitRequestId CustomerCostCenterLimitRequestId { get; }

    public CustomerCostCenterLimitRequestUpdatedEvent(CustomerCostCenterLimitRequestId customercostcenterlimitrequestId)
    {
        CustomerCostCenterLimitRequestId = customercostcenterlimitrequestId;
    }
}

public sealed class CustomerCostCenterLimitRequestDeletedEvent : DomainEvent
{
    public CustomerCostCenterLimitRequestId CustomerCostCenterLimitRequestId { get; }

    public CustomerCostCenterLimitRequestDeletedEvent(CustomerCostCenterLimitRequestId customercostcenterlimitrequestId)
    {
        CustomerCostCenterLimitRequestId = customercostcenterlimitrequestId;
    }
}
}
