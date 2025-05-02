using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class ItemBatch : Entity
    {
        // Primary Key
        public string ItemCode { get; private set; }
        public string BatchNumber { get; private set; }
        
        // Batch Description Fields
        public int? ColorNumber1 { get; private set; }
        public string? BatchDescription1 { get; private set; }
        public int? ColorNumber2 { get; private set; }
        public string? BatchDescription2 { get; private set; }
        public int? ColorNumber3 { get; private set; }
        public string? BatchDescription3 { get; private set; }
        public int? ColorNumber4 { get; private set; }
        public string? BatchDescription4 { get; private set; }
        public int? ColorNumber5 { get; private set; }
        public string? BatchDescription5 { get; private set; }
        
        // Company Info
        public int CompanyNumber { get; private set; }
        public int BranchNumber { get; private set; }
        public int? BranchYear { get; private set; }
        public int? BranchUser { get; private set; }
        
        // Audit Fields
        public int? AddedUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long UpdateCount { get; private set; }
        public int? PrintReport { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }

        // Navigation Properties
        public virtual Item Item { get; private set; }

        private ItemBatch() { } // For EF Core

        public ItemBatch(
            string itemCode,
            string batchNumber,
            int companyNumber,
            int branchNumber)
        {
            ItemCode = itemCode;
            BatchNumber = batchNumber;
            CompanyNumber = companyNumber;
            BranchNumber = branchNumber;

            AddDomainEvent(new ItemBatchCreatedEvent(itemCode, batchNumber));
        }

        public void UpdateBatchDescription(
            int descriptionNumber,
            int? colorNumber,
            string? description)
        {
            switch (descriptionNumber)
            {
                case 1:
                    ColorNumber1 = colorNumber;
                    BatchDescription1 = description;
                    break;
                case 2:
                    ColorNumber2 = colorNumber;
                    BatchDescription2 = description;
                    break;
                case 3:
                    ColorNumber3 = colorNumber;
                    BatchDescription3 = description;
                    break;
                case 4:
                    ColorNumber4 = colorNumber;
                    BatchDescription4 = description;
                    break;
                case 5:
                    ColorNumber5 = colorNumber;
                    BatchDescription5 = description;
                    break;
                default:
                    throw new DomainException($"Invalid description number: {descriptionNumber}");
            }

            AddDomainEvent(new ItemBatchDescriptionUpdatedEvent(ItemCode, BatchNumber, descriptionNumber));
        }

        public void UpdateBranchInfo(
            int? branchYear = null,
            int? branchUser = null)
        {
            BranchYear = branchYear ?? BranchYear;
            BranchUser = branchUser ?? BranchUser;

            AddDomainEvent(new ItemBatchBranchInfoUpdatedEvent(ItemCode, BatchNumber));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(ItemCode))
                throw new DomainException("Item code is required");

            if (string.IsNullOrWhiteSpace(BatchNumber))
                throw new DomainException("Batch number is required");

            if (CompanyNumber <= 0)
                throw new DomainException("Company number must be greater than zero");

            if (BranchNumber <= 0)
                throw new DomainException("Branch number must be greater than zero");
        }
    }
}