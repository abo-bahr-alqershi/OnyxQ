using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class ItemGroupTreeCreatedEvent : DomainEvent
    {
        public ItemGroupTree ItemGroupTree { get; }

        public ItemGroupTreeCreatedEvent(ItemGroupTree itemGroupTree)
        {
            ItemGroupTree = itemGroupTree;
        }
    }

    public class ItemGroupTreeUpdatedEvent : DomainEvent
    {
        public ItemGroupTree ItemGroupTree { get; }

        public ItemGroupTreeUpdatedEvent(ItemGroupTree itemGroupTree)
        {
            ItemGroupTree = itemGroupTree;
        }
    }

    public class ItemGroupTreeChildAddedEvent : DomainEvent
    {
        public ItemGroupTree ParentTree { get; }
        public ItemGroupTree ChildTree { get; }

        public ItemGroupTreeChildAddedEvent(ItemGroupTree parentTree, ItemGroupTree childTree)
        {
            ParentTree = parentTree;
            ChildTree = childTree;
        }
    }

    public class ItemGroupTreeChildRemovedEvent : DomainEvent
    {
        public ItemGroupTree ParentTree { get; }
        public ItemGroupTree ChildTree { get; }

        public ItemGroupTreeChildRemovedEvent(ItemGroupTree parentTree, ItemGroupTree childTree)
        {
            ParentTree = parentTree;
            ChildTree = childTree;
        }
    }
} 