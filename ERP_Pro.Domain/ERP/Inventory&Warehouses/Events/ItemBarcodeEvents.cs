using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class ItemBarcodeCreatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string Barcode { get; }

        public ItemBarcodeCreatedEvent(string itemCode, string barcode)
        {
            ItemCode = itemCode;
            Barcode = barcode;
        }
    }

    public class ItemBarcodeUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string Barcode { get; }

        public ItemBarcodeUpdatedEvent(string itemCode, string barcode)
        {
            ItemCode = itemCode;
            Barcode = barcode;
        }
    }

    public class ItemBarcodeDescriptionsUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string Barcode { get; }

        public ItemBarcodeDescriptionsUpdatedEvent(string itemCode, string barcode)
        {
            ItemCode = itemCode;
            Barcode = barcode;
        }
    }

    public class ItemBarcodeSetAsMainEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string Barcode { get; }

        public ItemBarcodeSetAsMainEvent(string itemCode, string barcode)
        {
            ItemCode = itemCode;
            Barcode = barcode;
        }
    }
} 