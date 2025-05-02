using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class DisassembleKitItemCreatedEvent : DomainEvent
    {
        public DisassembleKitItem DisassembleKitItem { get; }

        public DisassembleKitItemCreatedEvent(DisassembleKitItem disassembleKitItem)
        {
            DisassembleKitItem = disassembleKitItem;
        }
    }

    public class DisassembleKitItemUpdatedEvent : DomainEvent
    {
        public DisassembleKitItem DisassembleKitItem { get; }

        public DisassembleKitItemUpdatedEvent(DisassembleKitItem disassembleKitItem)
        {
            DisassembleKitItem = disassembleKitItem;
        }
    }

    public class DisassembleKitItemDetailAddedEvent : DomainEvent
    {
        public DisassembleKitItem DisassembleKitItem { get; }
        public DisassembleKitItemDetail Detail { get; }

        public DisassembleKitItemDetailAddedEvent(DisassembleKitItem disassembleKitItem, DisassembleKitItemDetail detail)
        {
            DisassembleKitItem = disassembleKitItem;
            Detail = detail;
        }
    }

    public class DisassembleKitItemDetailCreatedEvent : DomainEvent
    {
        public DisassembleKitItemDetail Detail { get; }

        public DisassembleKitItemDetailCreatedEvent(DisassembleKitItemDetail detail)
        {
            Detail = detail;
        }
    }

    public class DisassembleKitItemDetailUpdatedEvent : DomainEvent
    {
        public DisassembleKitItemDetail Detail { get; }

        public DisassembleKitItemDetailUpdatedEvent(DisassembleKitItemDetail detail)
        {
            Detail = detail;
        }
    }
} 