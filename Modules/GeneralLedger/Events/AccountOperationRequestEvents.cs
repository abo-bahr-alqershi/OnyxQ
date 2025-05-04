using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountOperationRequest entity
/// </summary>
public sealed class AccountOperationRequestCreatedEvent : DomainEvent
{
    public AccountOperationRequestId AccountOperationRequestId { get; }

    public AccountOperationRequestCreatedEvent(AccountOperationRequestId accountoperationrequestId)
    {
        AccountOperationRequestId = accountoperationrequestId;
    }
}

public sealed class AccountOperationRequestUpdatedEvent : DomainEvent
{
    public AccountOperationRequestId AccountOperationRequestId { get; }

    public AccountOperationRequestUpdatedEvent(AccountOperationRequestId accountoperationrequestId)
    {
        AccountOperationRequestId = accountoperationrequestId;
    }
}

public sealed class AccountOperationRequestDeletedEvent : DomainEvent
{
    public AccountOperationRequestId AccountOperationRequestId { get; }

    public AccountOperationRequestDeletedEvent(AccountOperationRequestId accountoperationrequestId)
    {
        AccountOperationRequestId = accountoperationrequestId;
    }
}
}
