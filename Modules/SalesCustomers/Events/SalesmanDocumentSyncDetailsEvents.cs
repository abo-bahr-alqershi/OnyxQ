using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanDocumentSyncDetails entity
/// </summary>
public sealed class SalesmanDocumentSyncDetailsCreatedEvent : DomainEvent
{
    public SalesmanDocumentSyncDetailsId SalesmanDocumentSyncDetailsId { get; }

    public SalesmanDocumentSyncDetailsCreatedEvent(SalesmanDocumentSyncDetailsId salesmandocumentsyncdetailsId)
    {
        SalesmanDocumentSyncDetailsId = salesmandocumentsyncdetailsId;
    }
}

public sealed class SalesmanDocumentSyncDetailsUpdatedEvent : DomainEvent
{
    public SalesmanDocumentSyncDetailsId SalesmanDocumentSyncDetailsId { get; }

    public SalesmanDocumentSyncDetailsUpdatedEvent(SalesmanDocumentSyncDetailsId salesmandocumentsyncdetailsId)
    {
        SalesmanDocumentSyncDetailsId = salesmandocumentsyncdetailsId;
    }
}

public sealed class SalesmanDocumentSyncDetailsDeletedEvent : DomainEvent
{
    public SalesmanDocumentSyncDetailsId SalesmanDocumentSyncDetailsId { get; }

    public SalesmanDocumentSyncDetailsDeletedEvent(SalesmanDocumentSyncDetailsId salesmandocumentsyncdetailsId)
    {
        SalesmanDocumentSyncDetailsId = salesmandocumentsyncdetailsId;
    }
}
}
