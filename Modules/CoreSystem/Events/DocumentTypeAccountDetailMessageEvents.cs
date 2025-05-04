using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to DocumentTypeAccountDetailMessage entity
/// </summary>
public sealed class DocumentTypeAccountDetailMessageCreatedEvent : DomainEvent
{
    public DocumentTypeAccountDetailMessageId DocumentTypeAccountDetailMessageId { get; }

    public DocumentTypeAccountDetailMessageCreatedEvent(DocumentTypeAccountDetailMessageId documenttypeaccountdetailmessageId)
    {
        DocumentTypeAccountDetailMessageId = documenttypeaccountdetailmessageId;
    }
}

public sealed class DocumentTypeAccountDetailMessageUpdatedEvent : DomainEvent
{
    public DocumentTypeAccountDetailMessageId DocumentTypeAccountDetailMessageId { get; }

    public DocumentTypeAccountDetailMessageUpdatedEvent(DocumentTypeAccountDetailMessageId documenttypeaccountdetailmessageId)
    {
        DocumentTypeAccountDetailMessageId = documenttypeaccountdetailmessageId;
    }
}

public sealed class DocumentTypeAccountDetailMessageDeletedEvent : DomainEvent
{
    public DocumentTypeAccountDetailMessageId DocumentTypeAccountDetailMessageId { get; }

    public DocumentTypeAccountDetailMessageDeletedEvent(DocumentTypeAccountDetailMessageId documenttypeaccountdetailmessageId)
    {
        DocumentTypeAccountDetailMessageId = documenttypeaccountdetailmessageId;
    }
}
}
