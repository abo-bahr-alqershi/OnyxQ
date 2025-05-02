using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class ItemCreatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string ItemName { get; }

        public ItemCreatedEvent(string itemCode, string itemName)
        {
            ItemCode = itemCode;
            ItemName = itemName;
        }
    }

    public class ItemUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }

        public ItemUpdatedEvent(string itemCode)
        {
            ItemCode = itemCode;
        }
    }

    public class ItemCostsUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }

        public ItemCostsUpdatedEvent(string itemCode)
        {
            ItemCode = itemCode;
        }
    }

    public class ItemDeactivatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string Reason { get; }

        public ItemDeactivatedEvent(string itemCode, string reason)
        {
            ItemCode = itemCode;
            Reason = reason;
        }
    }

    public class ItemActivatedEvent : DomainEvent
    {
        public string ItemCode { get; }

        public ItemActivatedEvent(string itemCode)
        {
            ItemCode = itemCode;
        }
    }
} 