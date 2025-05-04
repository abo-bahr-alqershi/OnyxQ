using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerBankAccount entity
/// </summary>
public sealed class CustomerBankAccountCreatedEvent : DomainEvent
{
    public CustomerBankAccountId CustomerBankAccountId { get; }

    public CustomerBankAccountCreatedEvent(CustomerBankAccountId customerbankaccountId)
    {
        CustomerBankAccountId = customerbankaccountId;
    }
}

public sealed class CustomerBankAccountUpdatedEvent : DomainEvent
{
    public CustomerBankAccountId CustomerBankAccountId { get; }

    public CustomerBankAccountUpdatedEvent(CustomerBankAccountId customerbankaccountId)
    {
        CustomerBankAccountId = customerbankaccountId;
    }
}

public sealed class CustomerBankAccountDeletedEvent : DomainEvent
{
    public CustomerBankAccountId CustomerBankAccountId { get; }

    public CustomerBankAccountDeletedEvent(CustomerBankAccountId customerbankaccountId)
    {
        CustomerBankAccountId = customerbankaccountId;
    }
}
}
