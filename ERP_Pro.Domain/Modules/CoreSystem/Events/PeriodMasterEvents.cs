using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to PeriodMaster entity
/// </summary>
public sealed class PeriodMasterCreatedEvent : DomainEvent
{
    public PeriodMasterId PeriodMasterId { get; }

    public PeriodMasterCreatedEvent(PeriodMasterId periodmasterId)
    {
        PeriodMasterId = periodmasterId;
    }
}

public sealed class PeriodMasterUpdatedEvent : DomainEvent
{
    public PeriodMasterId PeriodMasterId { get; }

    public PeriodMasterUpdatedEvent(PeriodMasterId periodmasterId)
    {
        PeriodMasterId = periodmasterId;
    }
}

public sealed class PeriodMasterDeletedEvent : DomainEvent
{
    public PeriodMasterId PeriodMasterId { get; }

    public PeriodMasterDeletedEvent(PeriodMasterId periodmasterId)
    {
        PeriodMasterId = periodmasterId;
    }
}
}
