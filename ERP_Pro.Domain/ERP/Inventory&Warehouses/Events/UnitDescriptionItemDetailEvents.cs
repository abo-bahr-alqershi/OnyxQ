using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class UnitDescriptionItemDetailCreatedEvent : DomainEvent
    {
        public UnitDescriptionItemDetail UnitDescriptionItemDetail { get; }

        public UnitDescriptionItemDetailCreatedEvent(UnitDescriptionItemDetail unitDescriptionItemDetail)
        {
            UnitDescriptionItemDetail = unitDescriptionItemDetail;
        }
    }

    public class UnitDescriptionItemDetailUpdatedEvent : DomainEvent
    {
        public UnitDescriptionItemDetail UnitDescriptionItemDetail { get; }

        public UnitDescriptionItemDetailUpdatedEvent(UnitDescriptionItemDetail unitDescriptionItemDetail)
        {
            UnitDescriptionItemDetail = unitDescriptionItemDetail;
        }
    }
} 