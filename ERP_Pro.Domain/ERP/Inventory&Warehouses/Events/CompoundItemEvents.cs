using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class CompoundItemCreatedEvent : DomainEvent
    {
        public CompoundItem CompoundItem { get; }

        public CompoundItemCreatedEvent(CompoundItem compoundItem)
        {
            CompoundItem = compoundItem;
        }
    }

    public class CompoundItemUpdatedEvent : DomainEvent
    {
        public CompoundItem CompoundItem { get; }

        public CompoundItemUpdatedEvent(CompoundItem compoundItem)
        {
            CompoundItem = compoundItem;
        }
    }

    public class CompoundItemPostedEvent : DomainEvent
    {
        public CompoundItem CompoundItem { get; }

        public CompoundItemPostedEvent(CompoundItem compoundItem)
        {
            CompoundItem = compoundItem;
        }
    }

    public class CompoundItemUnpostedEvent : DomainEvent
    {
        public CompoundItem CompoundItem { get; }

        public CompoundItemUnpostedEvent(CompoundItem compoundItem)
        {
            CompoundItem = compoundItem;
        }
    }

    public class CompoundItemDetailCreatedEvent : DomainEvent
    {
        public CompoundItemDetail CompoundItemDetail { get; }

        public CompoundItemDetailCreatedEvent(CompoundItemDetail compoundItemDetail)
        {
            CompoundItemDetail = compoundItemDetail;
        }
    }

    public class CompoundItemDetailUpdatedEvent : DomainEvent
    {
        public CompoundItemDetail CompoundItemDetail { get; }

        public CompoundItemDetailUpdatedEvent(CompoundItemDetail compoundItemDetail)
        {
            CompoundItemDetail = compoundItemDetail;
        }
    }

    public class CompoundItemDetailAddedEvent : DomainEvent
    {
        public CompoundItem CompoundItem { get; }
        public CompoundItemDetail CompoundItemDetail { get; }

        public CompoundItemDetailAddedEvent(CompoundItem compoundItem, CompoundItemDetail compoundItemDetail)
        {
            CompoundItem = compoundItem;
            CompoundItemDetail = compoundItemDetail;
        }
    }

    public class CompoundItemDetailRemovedEvent : DomainEvent
    {
        public CompoundItem CompoundItem { get; }
        public CompoundItemDetail CompoundItemDetail { get; }

        public CompoundItemDetailRemovedEvent(CompoundItem compoundItem, CompoundItemDetail compoundItemDetail)
        {
            CompoundItem = compoundItem;
            CompoundItemDetail = compoundItemDetail;
        }
    }
} 