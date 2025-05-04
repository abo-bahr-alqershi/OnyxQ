using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to UnitConversion entity
/// </summary>
public sealed class UnitConversionCreatedEvent : DomainEvent
{
    public UnitConversionId UnitConversionId { get; }

    public UnitConversionCreatedEvent(UnitConversionId unitconversionId)
    {
        UnitConversionId = unitconversionId;
    }
}

public sealed class UnitConversionUpdatedEvent : DomainEvent
{
    public UnitConversionId UnitConversionId { get; }

    public UnitConversionUpdatedEvent(UnitConversionId unitconversionId)
    {
        UnitConversionId = unitconversionId;
    }
}

public sealed class UnitConversionDeletedEvent : DomainEvent
{
    public UnitConversionId UnitConversionId { get; }

    public UnitConversionDeletedEvent(UnitConversionId unitconversionId)
    {
        UnitConversionId = unitconversionId;
    }
}
}
