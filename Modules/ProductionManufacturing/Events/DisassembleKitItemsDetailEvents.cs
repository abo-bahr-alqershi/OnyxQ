using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to DisassembleKitItemsDetail entity
/// </summary>
public sealed class DisassembleKitItemsDetailCreatedEvent : DomainEvent
{
    public DisassembleKitItemsDetailId DisassembleKitItemsDetailId { get; }

    public DisassembleKitItemsDetailCreatedEvent(DisassembleKitItemsDetailId disassemblekititemsdetailId)
    {
        DisassembleKitItemsDetailId = disassemblekititemsdetailId;
    }
}

public sealed class DisassembleKitItemsDetailUpdatedEvent : DomainEvent
{
    public DisassembleKitItemsDetailId DisassembleKitItemsDetailId { get; }

    public DisassembleKitItemsDetailUpdatedEvent(DisassembleKitItemsDetailId disassemblekititemsdetailId)
    {
        DisassembleKitItemsDetailId = disassemblekititemsdetailId;
    }
}

public sealed class DisassembleKitItemsDetailDeletedEvent : DomainEvent
{
    public DisassembleKitItemsDetailId DisassembleKitItemsDetailId { get; }

    public DisassembleKitItemsDetailDeletedEvent(DisassembleKitItemsDetailId disassemblekititemsdetailId)
    {
        DisassembleKitItemsDetailId = disassemblekititemsdetailId;
    }
}
}
