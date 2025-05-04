using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to BranchDocument entity
/// </summary>
public sealed class BranchDocumentCreatedEvent : DomainEvent
{
    public BranchDocumentId BranchDocumentId { get; }

    public BranchDocumentCreatedEvent(BranchDocumentId branchdocumentId)
    {
        BranchDocumentId = branchdocumentId;
    }
}

public sealed class BranchDocumentUpdatedEvent : DomainEvent
{
    public BranchDocumentId BranchDocumentId { get; }

    public BranchDocumentUpdatedEvent(BranchDocumentId branchdocumentId)
    {
        BranchDocumentId = branchdocumentId;
    }
}

public sealed class BranchDocumentDeletedEvent : DomainEvent
{
    public BranchDocumentId BranchDocumentId { get; }

    public BranchDocumentDeletedEvent(BranchDocumentId branchdocumentId)
    {
        BranchDocumentId = branchdocumentId;
    }
}
}
