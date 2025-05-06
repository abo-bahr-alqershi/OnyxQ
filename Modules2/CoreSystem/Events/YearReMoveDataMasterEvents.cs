using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to YearReMoveDataMaster entity
/// </summary>
public sealed class YearReMoveDataMasterCreatedEvent : DomainEvent
{
    public YearReMoveDataMasterId YearReMoveDataMasterId { get; }

    public YearReMoveDataMasterCreatedEvent(YearReMoveDataMasterId yearremovedatamasterId)
    {
        YearReMoveDataMasterId = yearremovedatamasterId;
    }
}

public sealed class YearReMoveDataMasterUpdatedEvent : DomainEvent
{
    public YearReMoveDataMasterId YearReMoveDataMasterId { get; }

    public YearReMoveDataMasterUpdatedEvent(YearReMoveDataMasterId yearremovedatamasterId)
    {
        YearReMoveDataMasterId = yearremovedatamasterId;
    }
}

public sealed class YearReMoveDataMasterDeletedEvent : DomainEvent
{
    public YearReMoveDataMasterId YearReMoveDataMasterId { get; }

    public YearReMoveDataMasterDeletedEvent(YearReMoveDataMasterId yearremovedatamasterId)
    {
        YearReMoveDataMasterId = yearremovedatamasterId;
    }
}
}
