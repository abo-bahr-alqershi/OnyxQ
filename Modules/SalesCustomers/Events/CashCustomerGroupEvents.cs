using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CashCustomerGroup entity
/// </summary>
public sealed class CashCustomerGroupCreatedEvent : DomainEvent
{
    public CashCustomerGroupId CashCustomerGroupId { get; }

    public CashCustomerGroupCreatedEvent(CashCustomerGroupId cashcustomergroupId)
    {
        CashCustomerGroupId = cashcustomergroupId;
    }
}

public sealed class CashCustomerGroupUpdatedEvent : DomainEvent
{
    public CashCustomerGroupId CashCustomerGroupId { get; }

    public CashCustomerGroupUpdatedEvent(CashCustomerGroupId cashcustomergroupId)
    {
        CashCustomerGroupId = cashcustomergroupId;
    }
}

public sealed class CashCustomerGroupDeletedEvent : DomainEvent
{
    public CashCustomerGroupId CashCustomerGroupId { get; }

    public CashCustomerGroupDeletedEvent(CashCustomerGroupId cashcustomergroupId)
    {
        CashCustomerGroupId = cashcustomergroupId;
    }
}
}
