using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to OutgoingBillDetail entity
/// </summary>
public sealed class OutgoingBillDetailCreatedEvent : DomainEvent
{
    public OutgoingBillDetailId OutgoingBillDetailId { get; }

    public OutgoingBillDetailCreatedEvent(OutgoingBillDetailId outgoingbilldetailId)
    {
        OutgoingBillDetailId = outgoingbilldetailId;
    }
}

public sealed class OutgoingBillDetailUpdatedEvent : DomainEvent
{
    public OutgoingBillDetailId OutgoingBillDetailId { get; }

    public OutgoingBillDetailUpdatedEvent(OutgoingBillDetailId outgoingbilldetailId)
    {
        OutgoingBillDetailId = outgoingbilldetailId;
    }
}

public sealed class OutgoingBillDetailDeletedEvent : DomainEvent
{
    public OutgoingBillDetailId OutgoingBillDetailId { get; }

    public OutgoingBillDetailDeletedEvent(OutgoingBillDetailId outgoingbilldetailId)
    {
        OutgoingBillDetailId = outgoingbilldetailId;
    }
}
}
