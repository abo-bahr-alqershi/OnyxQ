using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to MissingDocumentTemp entity
/// </summary>
public sealed class MissingDocumentTempCreatedEvent : DomainEvent
{
    public MissingDocumentTempId MissingDocumentTempId { get; }

    public MissingDocumentTempCreatedEvent(MissingDocumentTempId missingdocumenttempId)
    {
        MissingDocumentTempId = missingdocumenttempId;
    }
}

public sealed class MissingDocumentTempUpdatedEvent : DomainEvent
{
    public MissingDocumentTempId MissingDocumentTempId { get; }

    public MissingDocumentTempUpdatedEvent(MissingDocumentTempId missingdocumenttempId)
    {
        MissingDocumentTempId = missingdocumenttempId;
    }
}

public sealed class MissingDocumentTempDeletedEvent : DomainEvent
{
    public MissingDocumentTempId MissingDocumentTempId { get; }

    public MissingDocumentTempDeletedEvent(MissingDocumentTempId missingdocumenttempId)
    {
        MissingDocumentTempId = missingdocumenttempId;
    }
}
}
