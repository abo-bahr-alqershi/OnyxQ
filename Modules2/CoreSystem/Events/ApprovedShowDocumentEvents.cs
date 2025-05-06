using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApprovedShowDocument entity
/// </summary>
public sealed class ApprovedShowDocumentCreatedEvent : DomainEvent
{
    public ApprovedShowDocumentId ApprovedShowDocumentId { get; }

    public ApprovedShowDocumentCreatedEvent(ApprovedShowDocumentId approvedshowdocumentId)
    {
        ApprovedShowDocumentId = approvedshowdocumentId;
    }
}

public sealed class ApprovedShowDocumentUpdatedEvent : DomainEvent
{
    public ApprovedShowDocumentId ApprovedShowDocumentId { get; }

    public ApprovedShowDocumentUpdatedEvent(ApprovedShowDocumentId approvedshowdocumentId)
    {
        ApprovedShowDocumentId = approvedshowdocumentId;
    }
}

public sealed class ApprovedShowDocumentDeletedEvent : DomainEvent
{
    public ApprovedShowDocumentId ApprovedShowDocumentId { get; }

    public ApprovedShowDocumentDeletedEvent(ApprovedShowDocumentId approvedshowdocumentId)
    {
        ApprovedShowDocumentId = approvedshowdocumentId;
    }
}
}
