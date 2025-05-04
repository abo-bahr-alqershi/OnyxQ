using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to ReceiptDocument entity
/// </summary>
public sealed class ReceiptDocumentCreatedEvent : DomainEvent
{
    public ReceiptDocumentId ReceiptDocumentId { get; }

    public ReceiptDocumentCreatedEvent(ReceiptDocumentId receiptdocumentId)
    {
        ReceiptDocumentId = receiptdocumentId;
    }
}

public sealed class ReceiptDocumentUpdatedEvent : DomainEvent
{
    public ReceiptDocumentId ReceiptDocumentId { get; }

    public ReceiptDocumentUpdatedEvent(ReceiptDocumentId receiptdocumentId)
    {
        ReceiptDocumentId = receiptdocumentId;
    }
}

public sealed class ReceiptDocumentDeletedEvent : DomainEvent
{
    public ReceiptDocumentId ReceiptDocumentId { get; }

    public ReceiptDocumentDeletedEvent(ReceiptDocumentId receiptdocumentId)
    {
        ReceiptDocumentId = receiptdocumentId;
    }
}
}
