using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApprovedShowDocumentSub entity
/// </summary>
public sealed class ApprovedShowDocumentSubCreatedEvent : DomainEvent
{
    public ApprovedShowDocumentSubId ApprovedShowDocumentSubId { get; }

    public ApprovedShowDocumentSubCreatedEvent(ApprovedShowDocumentSubId approvedshowdocumentsubId)
    {
        ApprovedShowDocumentSubId = approvedshowdocumentsubId;
    }
}

public sealed class ApprovedShowDocumentSubUpdatedEvent : DomainEvent
{
    public ApprovedShowDocumentSubId ApprovedShowDocumentSubId { get; }

    public ApprovedShowDocumentSubUpdatedEvent(ApprovedShowDocumentSubId approvedshowdocumentsubId)
    {
        ApprovedShowDocumentSubId = approvedshowdocumentsubId;
    }
}

public sealed class ApprovedShowDocumentSubDeletedEvent : DomainEvent
{
    public ApprovedShowDocumentSubId ApprovedShowDocumentSubId { get; }

    public ApprovedShowDocumentSubDeletedEvent(ApprovedShowDocumentSubId approvedshowdocumentsubId)
    {
        ApprovedShowDocumentSubId = approvedshowdocumentsubId;
    }
}
}
