using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CashManagementMaster entity
/// </summary>
public sealed class CashManagementMasterCreatedEvent : DomainEvent
{
    public CashManagementMasterId CashManagementMasterId { get; }

    public CashManagementMasterCreatedEvent(CashManagementMasterId cashmanagementmasterId)
    {
        CashManagementMasterId = cashmanagementmasterId;
    }
}

public sealed class CashManagementMasterUpdatedEvent : DomainEvent
{
    public CashManagementMasterId CashManagementMasterId { get; }

    public CashManagementMasterUpdatedEvent(CashManagementMasterId cashmanagementmasterId)
    {
        CashManagementMasterId = cashmanagementmasterId;
    }
}

public sealed class CashManagementMasterDeletedEvent : DomainEvent
{
    public CashManagementMasterId CashManagementMasterId { get; }

    public CashManagementMasterDeletedEvent(CashManagementMasterId cashmanagementmasterId)
    {
        CashManagementMasterId = cashmanagementmasterId;
    }
}
}
