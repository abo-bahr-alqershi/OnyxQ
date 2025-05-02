using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class UnitConversionCreatedEvent : DomainEvent
    {
        public UnitConversion UnitConversion { get; }

        public UnitConversionCreatedEvent(UnitConversion unitConversion)
        {
            UnitConversion = unitConversion;
        }
    }

    public class UnitConversionUpdatedEvent : DomainEvent
    {
        public UnitConversion UnitConversion { get; }

        public UnitConversionUpdatedEvent(UnitConversion unitConversion)
        {
            UnitConversion = unitConversion;
        }
    }
} 