using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to DocumentPostUnpostTemp entity
/// </summary>
public sealed class DocumentPostUnpostTempCreatedEvent : DomainEvent
{
    public DocumentPostUnpostTempId DocumentPostUnpostTempId { get; }

    public DocumentPostUnpostTempCreatedEvent(DocumentPostUnpostTempId documentpostunposttempId)
    {
        DocumentPostUnpostTempId = documentpostunposttempId;
    }
}

public sealed class DocumentPostUnpostTempUpdatedEvent : DomainEvent
{
    public DocumentPostUnpostTempId DocumentPostUnpostTempId { get; }

    public DocumentPostUnpostTempUpdatedEvent(DocumentPostUnpostTempId documentpostunposttempId)
    {
        DocumentPostUnpostTempId = documentpostunposttempId;
    }
}

public sealed class DocumentPostUnpostTempDeletedEvent : DomainEvent
{
    public DocumentPostUnpostTempId DocumentPostUnpostTempId { get; }

    public DocumentPostUnpostTempDeletedEvent(DocumentPostUnpostTempId documentpostunposttempId)
    {
        DocumentPostUnpostTempId = documentpostunposttempId;
    }
}
}
