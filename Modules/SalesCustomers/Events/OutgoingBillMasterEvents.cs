using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to OutgoingBillMaster entity
/// </summary>
public sealed class OutgoingBillMasterCreatedEvent : DomainEvent
{
    public OutgoingBillMasterId OutgoingBillMasterId { get; }

    public OutgoingBillMasterCreatedEvent(OutgoingBillMasterId outgoingbillmasterId)
    {
        OutgoingBillMasterId = outgoingbillmasterId;
    }
}

public sealed class OutgoingBillMasterUpdatedEvent : DomainEvent
{
    public OutgoingBillMasterId OutgoingBillMasterId { get; }

    public OutgoingBillMasterUpdatedEvent(OutgoingBillMasterId outgoingbillmasterId)
    {
        OutgoingBillMasterId = outgoingbillmasterId;
    }
}

public sealed class OutgoingBillMasterDeletedEvent : DomainEvent
{
    public OutgoingBillMasterId OutgoingBillMasterId { get; }

    public OutgoingBillMasterDeletedEvent(OutgoingBillMasterId outgoingbillmasterId)
    {
        OutgoingBillMasterId = outgoingbillmasterId;
    }
}
}
