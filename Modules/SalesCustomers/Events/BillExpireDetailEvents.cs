using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillExpireDetail entity
/// </summary>
public sealed class BillExpireDetailCreatedEvent : DomainEvent
{
    public BillExpireDetailId BillExpireDetailId { get; }

    public BillExpireDetailCreatedEvent(BillExpireDetailId billexpiredetailId)
    {
        BillExpireDetailId = billexpiredetailId;
    }
}

public sealed class BillExpireDetailUpdatedEvent : DomainEvent
{
    public BillExpireDetailId BillExpireDetailId { get; }

    public BillExpireDetailUpdatedEvent(BillExpireDetailId billexpiredetailId)
    {
        BillExpireDetailId = billexpiredetailId;
    }
}

public sealed class BillExpireDetailDeletedEvent : DomainEvent
{
    public BillExpireDetailId BillExpireDetailId { get; }

    public BillExpireDetailDeletedEvent(BillExpireDetailId billexpiredetailId)
    {
        BillExpireDetailId = billexpiredetailId;
    }
}
}
