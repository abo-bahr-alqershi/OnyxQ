using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class ItemLevelMeasureCreatedEvent : DomainEvent
    {
        public ItemLevelMeasure ItemLevelMeasure { get; }

        public ItemLevelMeasureCreatedEvent(ItemLevelMeasure itemLevelMeasure)
        {
            ItemLevelMeasure = itemLevelMeasure;
        }
    }

    public class ItemLevelMeasureUpdatedEvent : DomainEvent
    {
        public ItemLevelMeasure ItemLevelMeasure { get; }

        public ItemLevelMeasureUpdatedEvent(ItemLevelMeasure itemLevelMeasure)
        {
            ItemLevelMeasure = itemLevelMeasure;
        }
    }
} 