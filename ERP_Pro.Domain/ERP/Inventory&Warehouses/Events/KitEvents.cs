using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    #region KitItem Events
    public class KitItemCreatedEvent : DomainEvent
    {
        public KitItem KitItem { get; }

        public KitItemCreatedEvent(KitItem kitItem)
        {
            KitItem = kitItem;
        }
    }

    public class KitItemUpdatedEvent : DomainEvent
    {
        public KitItem KitItem { get; }

        public KitItemUpdatedEvent(KitItem kitItem)
        {
            KitItem = kitItem;
        }
    }
    #endregion

    #region KitItemDetail Events
    public class KitItemDetailCreatedEvent : DomainEvent
    {
        public KitItemDetail KitItemDetail { get; }

        public KitItemDetailCreatedEvent(KitItemDetail kitItemDetail)
        {
            KitItemDetail = kitItemDetail;
        }
    }

    public class KitItemDetailUpdatedEvent : DomainEvent
    {
        public KitItemDetail KitItemDetail { get; }

        public KitItemDetailUpdatedEvent(KitItemDetail kitItemDetail)
        {
            KitItemDetail = kitItemDetail;
        }
    }

    public class KitItemDetailBatchUpdatedEvent : DomainEvent
    {
        public KitItemDetail KitItemDetail { get; }

        public KitItemDetailBatchUpdatedEvent(KitItemDetail kitItemDetail)
        {
            KitItemDetail = kitItemDetail;
        }
    }

    public class KitItemDetailCostUpdatedEvent : DomainEvent
    {
        public KitItemDetail KitItemDetail { get; }

        public KitItemDetailCostUpdatedEvent(KitItemDetail kitItemDetail)
        {
            KitItemDetail = kitItemDetail;
        }
    }

    public class KitItemDetailQuantitiesUpdatedEvent : DomainEvent
    {
        public KitItemDetail KitItemDetail { get; }

        public KitItemDetailQuantitiesUpdatedEvent(KitItemDetail kitItemDetail)
        {
            KitItemDetail = kitItemDetail;
        }
    }
    #endregion

    #region Measurement Events
    public class MeasurementCreatedEvent : DomainEvent
    {
        public Measurement Measurement { get; }

        public MeasurementCreatedEvent(Measurement measurement)
        {
            Measurement = measurement;
        }
    }

    public class MeasurementUpdatedEvent : DomainEvent
    {
        public Measurement Measurement { get; }

        public MeasurementUpdatedEvent(Measurement measurement)
        {
            Measurement = measurement;
        }
    }
    #endregion
} 