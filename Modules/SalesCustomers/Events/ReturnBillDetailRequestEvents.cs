using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to ReturnBillDetailRequest entity
/// </summary>
public sealed class ReturnBillDetailRequestCreatedEvent : DomainEvent
{
    public ReturnBillDetailRequestId ReturnBillDetailRequestId { get; }

    public ReturnBillDetailRequestCreatedEvent(ReturnBillDetailRequestId returnbilldetailrequestId)
    {
        ReturnBillDetailRequestId = returnbilldetailrequestId;
    }
}

public sealed class ReturnBillDetailRequestUpdatedEvent : DomainEvent
{
    public ReturnBillDetailRequestId ReturnBillDetailRequestId { get; }

    public ReturnBillDetailRequestUpdatedEvent(ReturnBillDetailRequestId returnbilldetailrequestId)
    {
        ReturnBillDetailRequestId = returnbilldetailrequestId;
    }
}

public sealed class ReturnBillDetailRequestDeletedEvent : DomainEvent
{
    public ReturnBillDetailRequestId ReturnBillDetailRequestId { get; }

    public ReturnBillDetailRequestDeletedEvent(ReturnBillDetailRequestId returnbilldetailrequestId)
    {
        ReturnBillDetailRequestId = returnbilldetailrequestId;
    }
}
}
