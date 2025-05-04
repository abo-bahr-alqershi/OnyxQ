using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferInBranchTemp entity
/// </summary>
public sealed class TransferInBranchTempCreatedEvent : DomainEvent
{
    public TransferInBranchTempId TransferInBranchTempId { get; }

    public TransferInBranchTempCreatedEvent(TransferInBranchTempId transferinbranchtempId)
    {
        TransferInBranchTempId = transferinbranchtempId;
    }
}

public sealed class TransferInBranchTempUpdatedEvent : DomainEvent
{
    public TransferInBranchTempId TransferInBranchTempId { get; }

    public TransferInBranchTempUpdatedEvent(TransferInBranchTempId transferinbranchtempId)
    {
        TransferInBranchTempId = transferinbranchtempId;
    }
}

public sealed class TransferInBranchTempDeletedEvent : DomainEvent
{
    public TransferInBranchTempId TransferInBranchTempId { get; }

    public TransferInBranchTempDeletedEvent(TransferInBranchTempId transferinbranchtempId)
    {
        TransferInBranchTempId = transferinbranchtempId;
    }
}
}
