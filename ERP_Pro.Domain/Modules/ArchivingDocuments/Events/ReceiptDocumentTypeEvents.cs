using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to ReceiptDocumentType entity
/// </summary>
public sealed class ReceiptDocumentTypeCreatedEvent : DomainEvent
{
    public ReceiptDocumentTypeId ReceiptDocumentTypeId { get; }

    public ReceiptDocumentTypeCreatedEvent(ReceiptDocumentTypeId receiptdocumenttypeId)
    {
        ReceiptDocumentTypeId = receiptdocumenttypeId;
    }
}

public sealed class ReceiptDocumentTypeUpdatedEvent : DomainEvent
{
    public ReceiptDocumentTypeId ReceiptDocumentTypeId { get; }

    public ReceiptDocumentTypeUpdatedEvent(ReceiptDocumentTypeId receiptdocumenttypeId)
    {
        ReceiptDocumentTypeId = receiptdocumenttypeId;
    }
}

public sealed class ReceiptDocumentTypeDeletedEvent : DomainEvent
{
    public ReceiptDocumentTypeId ReceiptDocumentTypeId { get; }

    public ReceiptDocumentTypeDeletedEvent(ReceiptDocumentTypeId receiptdocumenttypeId)
    {
        ReceiptDocumentTypeId = receiptdocumenttypeId;
    }
}
}
