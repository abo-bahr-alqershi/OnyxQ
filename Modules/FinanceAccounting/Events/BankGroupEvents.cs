using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BankGroup entity
/// </summary>
public sealed class BankGroupCreatedEvent : DomainEvent
{
    public BankGroupId BankGroupId { get; }

    public BankGroupCreatedEvent(BankGroupId bankgroupId)
    {
        BankGroupId = bankgroupId;
    }
}

public sealed class BankGroupUpdatedEvent : DomainEvent
{
    public BankGroupId BankGroupId { get; }

    public BankGroupUpdatedEvent(BankGroupId bankgroupId)
    {
        BankGroupId = bankgroupId;
    }
}

public sealed class BankGroupDeletedEvent : DomainEvent
{
    public BankGroupId BankGroupId { get; }

    public BankGroupDeletedEvent(BankGroupId bankgroupId)
    {
        BankGroupId = bankgroupId;
    }
}
}
