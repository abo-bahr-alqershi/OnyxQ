using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to DocumentDeletion entity
/// </summary>
public sealed class DocumentDeletionCreatedEvent : DomainEvent
{
    public DocumentDeletionId DocumentDeletionId { get; }

    public DocumentDeletionCreatedEvent(DocumentDeletionId documentdeletionId)
    {
        DocumentDeletionId = documentdeletionId;
    }
}

public sealed class DocumentDeletionUpdatedEvent : DomainEvent
{
    public DocumentDeletionId DocumentDeletionId { get; }

    public DocumentDeletionUpdatedEvent(DocumentDeletionId documentdeletionId)
    {
        DocumentDeletionId = documentdeletionId;
    }
}

public sealed class DocumentDeletionDeletedEvent : DomainEvent
{
    public DocumentDeletionId DocumentDeletionId { get; }

    public DocumentDeletionDeletedEvent(DocumentDeletionId documentdeletionId)
    {
        DocumentDeletionId = documentdeletionId;
    }
}
}
