using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferOutBranchTemp entity
/// </summary>
public sealed class TransferOutBranchTempCreatedEvent : DomainEvent
{
    public TransferOutBranchTempId TransferOutBranchTempId { get; }

    public TransferOutBranchTempCreatedEvent(TransferOutBranchTempId transferoutbranchtempId)
    {
        TransferOutBranchTempId = transferoutbranchtempId;
    }
}

public sealed class TransferOutBranchTempUpdatedEvent : DomainEvent
{
    public TransferOutBranchTempId TransferOutBranchTempId { get; }

    public TransferOutBranchTempUpdatedEvent(TransferOutBranchTempId transferoutbranchtempId)
    {
        TransferOutBranchTempId = transferoutbranchtempId;
    }
}

public sealed class TransferOutBranchTempDeletedEvent : DomainEvent
{
    public TransferOutBranchTempId TransferOutBranchTempId { get; }

    public TransferOutBranchTempDeletedEvent(TransferOutBranchTempId transferoutbranchtempId)
    {
        TransferOutBranchTempId = transferoutbranchtempId;
    }
}
}
