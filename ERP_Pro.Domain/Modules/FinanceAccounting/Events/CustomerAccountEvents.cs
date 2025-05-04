using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CustomerAccount entity
/// </summary>
public sealed class CustomerAccountCreatedEvent : DomainEvent
{
    public CustomerAccountId CustomerAccountId { get; }

    public CustomerAccountCreatedEvent(CustomerAccountId customeraccountId)
    {
        CustomerAccountId = customeraccountId;
    }
}

public sealed class CustomerAccountUpdatedEvent : DomainEvent
{
    public CustomerAccountId CustomerAccountId { get; }

    public CustomerAccountUpdatedEvent(CustomerAccountId customeraccountId)
    {
        CustomerAccountId = customeraccountId;
    }
}

public sealed class CustomerAccountDeletedEvent : DomainEvent
{
    public CustomerAccountId CustomerAccountId { get; }

    public CustomerAccountDeletedEvent(CustomerAccountId customeraccountId)
    {
        CustomerAccountId = customeraccountId;
    }
}
}
