using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to AuditDocument entity
/// </summary>
public sealed class AuditDocumentCreatedEvent : DomainEvent
{
    public AuditDocumentId AuditDocumentId { get; }

    public AuditDocumentCreatedEvent(AuditDocumentId auditdocumentId)
    {
        AuditDocumentId = auditdocumentId;
    }
}

public sealed class AuditDocumentUpdatedEvent : DomainEvent
{
    public AuditDocumentId AuditDocumentId { get; }

    public AuditDocumentUpdatedEvent(AuditDocumentId auditdocumentId)
    {
        AuditDocumentId = auditdocumentId;
    }
}

public sealed class AuditDocumentDeletedEvent : DomainEvent
{
    public AuditDocumentId AuditDocumentId { get; }

    public AuditDocumentDeletedEvent(AuditDocumentId auditdocumentId)
    {
        AuditDocumentId = auditdocumentId;
    }
}
}
