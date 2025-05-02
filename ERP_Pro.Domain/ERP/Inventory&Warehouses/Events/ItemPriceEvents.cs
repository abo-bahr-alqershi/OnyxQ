using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class ItemPriceCreatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public int LevelNumber { get; }
        public decimal Price { get; }

        public ItemPriceCreatedEvent(string itemCode, int levelNumber, decimal price)
        {
            ItemCode = itemCode;
            LevelNumber = levelNumber;
            Price = price;
        }
    }

    public class ItemPriceUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public int LevelNumber { get; }
        public decimal OldPrice { get; }
        public decimal NewPrice { get; }

        public ItemPriceUpdatedEvent(string itemCode, int levelNumber, decimal oldPrice, decimal newPrice)
        {
            ItemCode = itemCode;
            LevelNumber = levelNumber;
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }

    public class ItemPriceQuantityRangeUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public int LevelNumber { get; }

        public ItemPriceQuantityRangeUpdatedEvent(string itemCode, int levelNumber)
        {
            ItemCode = itemCode;
            LevelNumber = levelNumber;
        }
    }
} 