using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillDetail entity
/// </summary>
public sealed class BillDetailCreatedEvent : DomainEvent
{
    public BillDetailId BillDetailId { get; }

    public BillDetailCreatedEvent(BillDetailId billdetailId)
    {
        BillDetailId = billdetailId;
    }
}

public sealed class BillDetailUpdatedEvent : DomainEvent
{
    public BillDetailId BillDetailId { get; }

    public BillDetailUpdatedEvent(BillDetailId billdetailId)
    {
        BillDetailId = billdetailId;
    }
}

public sealed class BillDetailDeletedEvent : DomainEvent
{
    public BillDetailId BillDetailId { get; }

    public BillDetailDeletedEvent(BillDetailId billdetailId)
    {
        BillDetailId = billdetailId;
    }
}
}
