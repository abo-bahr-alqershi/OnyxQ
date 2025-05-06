using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to ReturnBillDetail entity
/// </summary>
public sealed class ReturnBillDetailCreatedEvent : DomainEvent
{
    public ReturnBillDetailId ReturnBillDetailId { get; }

    public ReturnBillDetailCreatedEvent(ReturnBillDetailId returnbilldetailId)
    {
        ReturnBillDetailId = returnbilldetailId;
    }
}

public sealed class ReturnBillDetailUpdatedEvent : DomainEvent
{
    public ReturnBillDetailId ReturnBillDetailId { get; }

    public ReturnBillDetailUpdatedEvent(ReturnBillDetailId returnbilldetailId)
    {
        ReturnBillDetailId = returnbilldetailId;
    }
}

public sealed class ReturnBillDetailDeletedEvent : DomainEvent
{
    public ReturnBillDetailId ReturnBillDetailId { get; }

    public ReturnBillDetailDeletedEvent(ReturnBillDetailId returnbilldetailId)
    {
        ReturnBillDetailId = returnbilldetailId;
    }
}
}
