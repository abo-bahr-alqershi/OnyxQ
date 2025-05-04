using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BranchItemSerialNumber entity
/// </summary>
public sealed class BranchItemSerialNumberCreatedEvent : DomainEvent
{
    public BranchItemSerialNumberId BranchItemSerialNumberId { get; }

    public BranchItemSerialNumberCreatedEvent(BranchItemSerialNumberId branchitemserialnumberId)
    {
        BranchItemSerialNumberId = branchitemserialnumberId;
    }
}

public sealed class BranchItemSerialNumberUpdatedEvent : DomainEvent
{
    public BranchItemSerialNumberId BranchItemSerialNumberId { get; }

    public BranchItemSerialNumberUpdatedEvent(BranchItemSerialNumberId branchitemserialnumberId)
    {
        BranchItemSerialNumberId = branchitemserialnumberId;
    }
}

public sealed class BranchItemSerialNumberDeletedEvent : DomainEvent
{
    public BranchItemSerialNumberId BranchItemSerialNumberId { get; }

    public BranchItemSerialNumberDeletedEvent(BranchItemSerialNumberId branchitemserialnumberId)
    {
        BranchItemSerialNumberId = branchitemserialnumberId;
    }
}
}
