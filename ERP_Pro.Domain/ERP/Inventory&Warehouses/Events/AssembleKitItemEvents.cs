using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class AssembleKitItemCreatedEvent : DomainEvent
    {
        public AssembleKitItem AssembleKitItem { get; }

        public AssembleKitItemCreatedEvent(AssembleKitItem assembleKitItem)
        {
            AssembleKitItem = assembleKitItem;
        }
    }

    public class AssembleKitItemWarehouseUpdatedEvent : DomainEvent
    {
        public AssembleKitItem AssembleKitItem { get; }

        public AssembleKitItemWarehouseUpdatedEvent(AssembleKitItem assembleKitItem)
        {
            AssembleKitItem = assembleKitItem;
        }
    }

    public class AssembleKitItemReferencesUpdatedEvent : DomainEvent
    {
        public AssembleKitItem AssembleKitItem { get; }

        public AssembleKitItemReferencesUpdatedEvent(AssembleKitItem assembleKitItem)
        {
            AssembleKitItem = assembleKitItem;
        }
    }

    public class AssembleKitItemSettingsUpdatedEvent : DomainEvent
    {
        public AssembleKitItem AssembleKitItem { get; }

        public AssembleKitItemSettingsUpdatedEvent(AssembleKitItem assembleKitItem)
        {
            AssembleKitItem = assembleKitItem;
        }
    }
} 