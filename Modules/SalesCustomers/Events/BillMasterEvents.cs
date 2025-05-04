using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillMaster entity
/// </summary>
public sealed class BillMasterCreatedEvent : DomainEvent
{
    public BillMasterId BillMasterId { get; }

    public BillMasterCreatedEvent(BillMasterId billmasterId)
    {
        BillMasterId = billmasterId;
    }
}

public sealed class BillMasterUpdatedEvent : DomainEvent
{
    public BillMasterId BillMasterId { get; }

    public BillMasterUpdatedEvent(BillMasterId billmasterId)
    {
        BillMasterId = billmasterId;
    }
}

public sealed class BillMasterDeletedEvent : DomainEvent
{
    public BillMasterId BillMasterId { get; }

    public BillMasterDeletedEvent(BillMasterId billmasterId)
    {
        BillMasterId = billmasterId;
    }
}
}
