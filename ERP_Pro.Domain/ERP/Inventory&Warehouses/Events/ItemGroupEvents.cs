using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class ItemGroupCreatedEvent : DomainEvent
    {
        public string GroupCode { get; }
        public string GroupName { get; }

        public ItemGroupCreatedEvent(string groupCode, string groupName)
        {
            GroupCode = groupCode;
            GroupName = groupName;
        }
    }

    public class ItemGroupUpdatedEvent : DomainEvent
    {
        public string GroupCode { get; }

        public ItemGroupUpdatedEvent(string groupCode)
        {
            GroupCode = groupCode;
        }
    }

    public class ItemGroupSettingsUpdatedEvent : DomainEvent
    {
        public string GroupCode { get; }

        public ItemGroupSettingsUpdatedEvent(string groupCode)
        {
            GroupCode = groupCode;
        }
    }
} 