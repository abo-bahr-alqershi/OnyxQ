using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillExpireMaster entity
/// </summary>
public sealed class BillExpireMasterCreatedEvent : DomainEvent
{
    public BillExpireMasterId BillExpireMasterId { get; }

    public BillExpireMasterCreatedEvent(BillExpireMasterId billexpiremasterId)
    {
        BillExpireMasterId = billexpiremasterId;
    }
}

public sealed class BillExpireMasterUpdatedEvent : DomainEvent
{
    public BillExpireMasterId BillExpireMasterId { get; }

    public BillExpireMasterUpdatedEvent(BillExpireMasterId billexpiremasterId)
    {
        BillExpireMasterId = billexpiremasterId;
    }
}

public sealed class BillExpireMasterDeletedEvent : DomainEvent
{
    public BillExpireMasterId BillExpireMasterId { get; }

    public BillExpireMasterDeletedEvent(BillExpireMasterId billexpiremasterId)
    {
        BillExpireMasterId = billexpiremasterId;
    }
}
}
