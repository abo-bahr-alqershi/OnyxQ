using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Events
{
    public class ItemMovementCreatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public int DocumentType { get; }
        public long DocumentNumber { get; }
        public decimal Quantity { get; }

        public ItemMovementCreatedEvent(string itemCode, int documentType, long documentNumber, decimal quantity)
        {
            ItemCode = itemCode;
            DocumentType = documentType;
            DocumentNumber = documentNumber;
            Quantity = quantity;
        }
    }

    public class ItemMovementQuantityUpdatedEvent : DomainEvent
    {
        public ItemMovement ItemMovement { get; }
        public ItemQuantity OldQuantity { get; }
        public ItemQuantity NewQuantity { get; }

        public ItemMovementQuantityUpdatedEvent(
            ItemMovement itemMovement,
            ItemQuantity oldQuantity,
            ItemQuantity newQuantity)
        {
            ItemMovement = itemMovement;
            OldQuantity = oldQuantity;
            NewQuantity = newQuantity;
        }
    }

    public class ItemMovementFreeQuantityAddedEvent : DomainEvent
    {
        public ItemMovement ItemMovement { get; }
        public ItemQuantity FreeQuantity { get; }

        public ItemMovementFreeQuantityAddedEvent(
            ItemMovement itemMovement,
            ItemQuantity freeQuantity)
        {
            ItemMovement = itemMovement;
            FreeQuantity = freeQuantity;
        }
    }

    public class ItemMovementCostUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public int DocumentType { get; }
        public long DocumentNumber { get; }

        public ItemMovementCostUpdatedEvent(string itemCode, int documentType, long documentNumber)
        {
            ItemCode = itemCode;
            DocumentType = documentType;
            DocumentNumber = documentNumber;
        }
    }

    public class ItemMovementDiscountAppliedEvent : DomainEvent
    {
        public ItemMovement ItemMovement { get; }
        public DiscountInfo Discount { get; }

        public ItemMovementDiscountAppliedEvent(
            ItemMovement itemMovement,
            DiscountInfo discount)
        {
            ItemMovement = itemMovement;
            Discount = discount;
        }
    }

    public class ItemMovementBatchInfoSetEvent : DomainEvent
    {
        public ItemMovement ItemMovement { get; }
        public BatchNumber BatchNumber { get; }
        public DateTime ExpireDate { get; }

        public ItemMovementBatchInfoSetEvent(
            ItemMovement itemMovement,
            BatchNumber batchNumber,
            DateTime expireDate)
        {
            ItemMovement = itemMovement;
            BatchNumber = batchNumber;
            ExpireDate = expireDate;
        }
    }

    public class ItemMovementReferencesUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public int DocumentType { get; }
        public long DocumentNumber { get; }

        public ItemMovementReferencesUpdatedEvent(string itemCode, int documentType, long documentNumber)
        {
            ItemCode = itemCode;
            DocumentType = documentType;
            DocumentNumber = documentNumber;
        }
    }
} 