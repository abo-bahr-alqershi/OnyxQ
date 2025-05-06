using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to ReturnBillMasterRequest entity
/// </summary>
public sealed class ReturnBillMasterRequestCreatedEvent : DomainEvent
{
    public ReturnBillMasterRequestId ReturnBillMasterRequestId { get; }

    public ReturnBillMasterRequestCreatedEvent(ReturnBillMasterRequestId returnbillmasterrequestId)
    {
        ReturnBillMasterRequestId = returnbillmasterrequestId;
    }
}

public sealed class ReturnBillMasterRequestUpdatedEvent : DomainEvent
{
    public ReturnBillMasterRequestId ReturnBillMasterRequestId { get; }

    public ReturnBillMasterRequestUpdatedEvent(ReturnBillMasterRequestId returnbillmasterrequestId)
    {
        ReturnBillMasterRequestId = returnbillmasterrequestId;
    }
}

public sealed class ReturnBillMasterRequestDeletedEvent : DomainEvent
{
    public ReturnBillMasterRequestId ReturnBillMasterRequestId { get; }

    public ReturnBillMasterRequestDeletedEvent(ReturnBillMasterRequestId returnbillmasterrequestId)
    {
        ReturnBillMasterRequestId = returnbillmasterrequestId;
    }
}
}
