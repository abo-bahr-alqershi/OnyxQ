using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to DocumentDescription entity
/// </summary>
public sealed class DocumentDescriptionCreatedEvent : DomainEvent
{
    public DocumentDescriptionId DocumentDescriptionId { get; }

    public DocumentDescriptionCreatedEvent(DocumentDescriptionId documentdescriptionId)
    {
        DocumentDescriptionId = documentdescriptionId;
    }
}

public sealed class DocumentDescriptionUpdatedEvent : DomainEvent
{
    public DocumentDescriptionId DocumentDescriptionId { get; }

    public DocumentDescriptionUpdatedEvent(DocumentDescriptionId documentdescriptionId)
    {
        DocumentDescriptionId = documentdescriptionId;
    }
}

public sealed class DocumentDescriptionDeletedEvent : DomainEvent
{
    public DocumentDescriptionId DocumentDescriptionId { get; }

    public DocumentDescriptionDeletedEvent(DocumentDescriptionId documentdescriptionId)
    {
        DocumentDescriptionId = documentdescriptionId;
    }
}
}
