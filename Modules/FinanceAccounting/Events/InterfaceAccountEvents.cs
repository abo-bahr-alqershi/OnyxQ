using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to InterfaceAccount entity
/// </summary>
public sealed class InterfaceAccountCreatedEvent : DomainEvent
{
    public InterfaceAccountId InterfaceAccountId { get; }

    public InterfaceAccountCreatedEvent(InterfaceAccountId interfaceaccountId)
    {
        InterfaceAccountId = interfaceaccountId;
    }
}

public sealed class InterfaceAccountUpdatedEvent : DomainEvent
{
    public InterfaceAccountId InterfaceAccountId { get; }

    public InterfaceAccountUpdatedEvent(InterfaceAccountId interfaceaccountId)
    {
        InterfaceAccountId = interfaceaccountId;
    }
}

public sealed class InterfaceAccountDeletedEvent : DomainEvent
{
    public InterfaceAccountId InterfaceAccountId { get; }

    public InterfaceAccountDeletedEvent(InterfaceAccountId interfaceaccountId)
    {
        InterfaceAccountId = interfaceaccountId;
    }
}
}
