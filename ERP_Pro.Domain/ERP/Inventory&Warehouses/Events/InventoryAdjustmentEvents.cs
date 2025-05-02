using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Events
{
    public class InventoryAdjustmentCreatedEvent : DomainEvent
    {
        public InventoryAdjustment InventoryAdjustment { get; }

        public InventoryAdjustmentCreatedEvent(InventoryAdjustment inventoryAdjustment)
        {
            InventoryAdjustment = inventoryAdjustment;
        }
    }

    public class InventoryAdjustmentDescriptionUpdatedEvent : DomainEvent
    {
        public InventoryAdjustment InventoryAdjustment { get; }
        public string? OldDescription { get; }
        public string? NewDescription { get; }

        public InventoryAdjustmentDescriptionUpdatedEvent(
            InventoryAdjustment inventoryAdjustment,
            string? oldDescription,
            string? newDescription)
        {
            InventoryAdjustment = inventoryAdjustment;
            OldDescription = oldDescription;
            NewDescription = newDescription;
        }
    }

    public class InventoryAdjustmentReferenceNumberUpdatedEvent : DomainEvent
    {
        public InventoryAdjustment InventoryAdjustment { get; }
        public string? OldReferenceNumber { get; }
        public string? NewReferenceNumber { get; }

        public InventoryAdjustmentReferenceNumberUpdatedEvent(
            InventoryAdjustment inventoryAdjustment,
            string? oldReferenceNumber,
            string? newReferenceNumber)
        {
            InventoryAdjustment = inventoryAdjustment;
            OldReferenceNumber = oldReferenceNumber;
            NewReferenceNumber = newReferenceNumber;
        }
    }

    public class InventoryAdjustmentDetailAddedEvent : DomainEvent
    {
        public InventoryAdjustment InventoryAdjustment { get; }
        public InventoryAdjustmentDetail Detail { get; }

        public InventoryAdjustmentDetailAddedEvent(
            InventoryAdjustment inventoryAdjustment,
            InventoryAdjustmentDetail detail)
        {
            InventoryAdjustment = inventoryAdjustment;
            Detail = detail;
        }
    }

    public class InventoryAdjustmentDetailRemovedEvent : DomainEvent
    {
        public InventoryAdjustment InventoryAdjustment { get; }
        public InventoryAdjustmentDetail Detail { get; }

        public InventoryAdjustmentDetailRemovedEvent(
            InventoryAdjustment inventoryAdjustment,
            InventoryAdjustmentDetail detail)
        {
            InventoryAdjustment = inventoryAdjustment;
            Detail = detail;
        }
    }

    public class InventoryAdjustmentPostedEvent : DomainEvent
    {
        public InventoryAdjustment InventoryAdjustment { get; }
        public int UserId { get; }

        public InventoryAdjustmentPostedEvent(
            InventoryAdjustment inventoryAdjustment,
            int userId)
        {
            InventoryAdjustment = inventoryAdjustment;
            UserId = userId;
        }
    }

    public class InventoryAdjustmentApprovedEvent : DomainEvent
    {
        public InventoryAdjustment InventoryAdjustment { get; }
        public int UserId { get; }

        public InventoryAdjustmentApprovedEvent(
            InventoryAdjustment inventoryAdjustment,
            int userId)
        {
            InventoryAdjustment = inventoryAdjustment;
            UserId = userId;
        }
    }

    public class InventoryAdjustmentExternalPostUpdatedEvent : DomainEvent
    {
        public InventoryAdjustment InventoryAdjustment { get; }
        public int? OldExternalPost { get; }
        public int? NewExternalPost { get; }

        public InventoryAdjustmentExternalPostUpdatedEvent(
            InventoryAdjustment inventoryAdjustment,
            int? oldExternalPost,
            int? newExternalPost)
        {
            InventoryAdjustment = inventoryAdjustment;
            OldExternalPost = oldExternalPost;
            NewExternalPost = newExternalPost;
        }
    }
} 