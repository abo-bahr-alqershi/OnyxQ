using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to DisassembleKitItem entity
/// </summary>
public sealed class DisassembleKitItemCreatedEvent : DomainEvent
{
    public DisassembleKitItemId DisassembleKitItemId { get; }

    public DisassembleKitItemCreatedEvent(DisassembleKitItemId disassemblekititemId)
    {
        DisassembleKitItemId = disassemblekititemId;
    }
}

public sealed class DisassembleKitItemUpdatedEvent : DomainEvent
{
    public DisassembleKitItemId DisassembleKitItemId { get; }

    public DisassembleKitItemUpdatedEvent(DisassembleKitItemId disassemblekititemId)
    {
        DisassembleKitItemId = disassemblekititemId;
    }
}

public sealed class DisassembleKitItemDeletedEvent : DomainEvent
{
    public DisassembleKitItemId DisassembleKitItemId { get; }

    public DisassembleKitItemDeletedEvent(DisassembleKitItemId disassemblekititemId)
    {
        DisassembleKitItemId = disassemblekititemId;
    }
}
}
