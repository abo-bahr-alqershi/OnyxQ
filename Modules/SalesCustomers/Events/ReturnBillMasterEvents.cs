using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to ReturnBillMaster entity
/// </summary>
public sealed class ReturnBillMasterCreatedEvent : DomainEvent
{
    public ReturnBillMasterId ReturnBillMasterId { get; }

    public ReturnBillMasterCreatedEvent(ReturnBillMasterId returnbillmasterId)
    {
        ReturnBillMasterId = returnbillmasterId;
    }
}

public sealed class ReturnBillMasterUpdatedEvent : DomainEvent
{
    public ReturnBillMasterId ReturnBillMasterId { get; }

    public ReturnBillMasterUpdatedEvent(ReturnBillMasterId returnbillmasterId)
    {
        ReturnBillMasterId = returnbillmasterId;
    }
}

public sealed class ReturnBillMasterDeletedEvent : DomainEvent
{
    public ReturnBillMasterId ReturnBillMasterId { get; }

    public ReturnBillMasterDeletedEvent(ReturnBillMasterId returnbillmasterId)
    {
        ReturnBillMasterId = returnbillmasterId;
    }
}
}
