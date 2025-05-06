using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CashManagementDetail entity
/// </summary>
public sealed class CashManagementDetailCreatedEvent : DomainEvent
{
    public CashManagementDetailId CashManagementDetailId { get; }

    public CashManagementDetailCreatedEvent(CashManagementDetailId cashmanagementdetailId)
    {
        CashManagementDetailId = cashmanagementdetailId;
    }
}

public sealed class CashManagementDetailUpdatedEvent : DomainEvent
{
    public CashManagementDetailId CashManagementDetailId { get; }

    public CashManagementDetailUpdatedEvent(CashManagementDetailId cashmanagementdetailId)
    {
        CashManagementDetailId = cashmanagementdetailId;
    }
}

public sealed class CashManagementDetailDeletedEvent : DomainEvent
{
    public CashManagementDetailId CashManagementDetailId { get; }

    public CashManagementDetailDeletedEvent(CashManagementDetailId cashmanagementdetailId)
    {
        CashManagementDetailId = cashmanagementdetailId;
    }
}
}
