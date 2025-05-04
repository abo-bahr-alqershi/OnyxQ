using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CostMaster entity
/// </summary>
public sealed class CostMasterCreatedEvent : DomainEvent
{
    public CostMasterId CostMasterId { get; }

    public CostMasterCreatedEvent(CostMasterId costmasterId)
    {
        CostMasterId = costmasterId;
    }
}

public sealed class CostMasterUpdatedEvent : DomainEvent
{
    public CostMasterId CostMasterId { get; }

    public CostMasterUpdatedEvent(CostMasterId costmasterId)
    {
        CostMasterId = costmasterId;
    }
}

public sealed class CostMasterDeletedEvent : DomainEvent
{
    public CostMasterId CostMasterId { get; }

    public CostMasterDeletedEvent(CostMasterId costmasterId)
    {
        CostMasterId = costmasterId;
    }
}
}
