using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to DocumentTypeMessage entity
/// </summary>
public sealed class DocumentTypeMessageCreatedEvent : DomainEvent
{
    public DocumentTypeMessageId DocumentTypeMessageId { get; }

    public DocumentTypeMessageCreatedEvent(DocumentTypeMessageId documenttypemessageId)
    {
        DocumentTypeMessageId = documenttypemessageId;
    }
}

public sealed class DocumentTypeMessageUpdatedEvent : DomainEvent
{
    public DocumentTypeMessageId DocumentTypeMessageId { get; }

    public DocumentTypeMessageUpdatedEvent(DocumentTypeMessageId documenttypemessageId)
    {
        DocumentTypeMessageId = documenttypemessageId;
    }
}

public sealed class DocumentTypeMessageDeletedEvent : DomainEvent
{
    public DocumentTypeMessageId DocumentTypeMessageId { get; }

    public DocumentTypeMessageDeletedEvent(DocumentTypeMessageId documenttypemessageId)
    {
        DocumentTypeMessageId = documenttypemessageId;
    }
}
}
