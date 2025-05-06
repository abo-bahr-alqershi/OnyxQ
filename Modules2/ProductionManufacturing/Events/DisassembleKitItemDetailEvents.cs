using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to DisassembleKitItemDetail entity
/// </summary>
public sealed class DisassembleKitItemDetailCreatedEvent : DomainEvent
{
    public DisassembleKitItemDetailId DisassembleKitItemDetailId { get; }

    public DisassembleKitItemDetailCreatedEvent(DisassembleKitItemDetailId disassemblekititemdetailId)
    {
        DisassembleKitItemDetailId = disassemblekititemdetailId;
    }
}

public sealed class DisassembleKitItemDetailUpdatedEvent : DomainEvent
{
    public DisassembleKitItemDetailId DisassembleKitItemDetailId { get; }

    public DisassembleKitItemDetailUpdatedEvent(DisassembleKitItemDetailId disassemblekititemdetailId)
    {
        DisassembleKitItemDetailId = disassemblekititemdetailId;
    }
}

public sealed class DisassembleKitItemDetailDeletedEvent : DomainEvent
{
    public DisassembleKitItemDetailId DisassembleKitItemDetailId { get; }

    public DisassembleKitItemDetailDeletedEvent(DisassembleKitItemDetailId disassemblekititemdetailId)
    {
        DisassembleKitItemDetailId = disassemblekititemdetailId;
    }
}
}
