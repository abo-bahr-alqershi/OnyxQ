using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to DocumentMessageAlert entity
/// </summary>
public sealed class DocumentMessageAlertCreatedEvent : DomainEvent
{
    public DocumentMessageAlertId DocumentMessageAlertId { get; }

    public DocumentMessageAlertCreatedEvent(DocumentMessageAlertId documentmessagealertId)
    {
        DocumentMessageAlertId = documentmessagealertId;
    }
}

public sealed class DocumentMessageAlertUpdatedEvent : DomainEvent
{
    public DocumentMessageAlertId DocumentMessageAlertId { get; }

    public DocumentMessageAlertUpdatedEvent(DocumentMessageAlertId documentmessagealertId)
    {
        DocumentMessageAlertId = documentmessagealertId;
    }
}

public sealed class DocumentMessageAlertDeletedEvent : DomainEvent
{
    public DocumentMessageAlertId DocumentMessageAlertId { get; }

    public DocumentMessageAlertDeletedEvent(DocumentMessageAlertId documentmessagealertId)
    {
        DocumentMessageAlertId = documentmessagealertId;
    }
}
}
