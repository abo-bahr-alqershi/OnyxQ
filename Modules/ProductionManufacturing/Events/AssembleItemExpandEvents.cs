using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to AssembleItemExpand entity
/// </summary>
public sealed class AssembleItemExpandCreatedEvent : DomainEvent
{
    public AssembleItemExpandId AssembleItemExpandId { get; }

    public AssembleItemExpandCreatedEvent(AssembleItemExpandId assembleitemexpandId)
    {
        AssembleItemExpandId = assembleitemexpandId;
    }
}

public sealed class AssembleItemExpandUpdatedEvent : DomainEvent
{
    public AssembleItemExpandId AssembleItemExpandId { get; }

    public AssembleItemExpandUpdatedEvent(AssembleItemExpandId assembleitemexpandId)
    {
        AssembleItemExpandId = assembleitemexpandId;
    }
}

public sealed class AssembleItemExpandDeletedEvent : DomainEvent
{
    public AssembleItemExpandId AssembleItemExpandId { get; }

    public AssembleItemExpandDeletedEvent(AssembleItemExpandId assembleitemexpandId)
    {
        AssembleItemExpandId = assembleitemexpandId;
    }
}
}
