using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class ItemGroup : AggregateRoot
    {
        // Primary Key
        public string GroupCode { get; private set; }
        
        // Basic Info
        public string LocalName { get; private set; }
        public string? ForeignName { get; private set; }
        public string? ParentGroupCode { get; private set; }
        
        // Settings
        public bool AffectedByTransactions { get; private set; }
        public string? GeneralGroupCode { get; private set; }
        public int? ActivityNumber { get; private set; }
        public decimal? DefaultPricePercentageFromPrimaryCost { get; private set; }
        
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
        public virtual ItemGroup ParentGroup { get; private set; }
        public virtual IReadOnlyCollection<ItemGroup> ChildGroups => _childGroups.AsReadOnly();
        public virtual IReadOnlyCollection<Item> Items => _items.AsReadOnly();

        // Private Collections
        private readonly List<ItemGroup> _childGroups = new();
        private readonly List<Item> _items = new();

        private ItemGroup() { } // For EF Core

        public ItemGroup(
            string groupCode,
            string localName,
            string? parentGroupCode = null)
        {
            GroupCode = groupCode;
            LocalName = localName;
            ParentGroupCode = parentGroupCode;

            AddDomainEvent(new ItemGroupCreatedEvent(groupCode, localName));
        }

        public void UpdateBasicInfo(
            string localName,
            string? foreignName = null,
            string? generalGroupCode = null)
        {
            LocalName = localName;
            ForeignName = foreignName;
            GeneralGroupCode = generalGroupCode;

            AddDomainEvent(new ItemGroupUpdatedEvent(GroupCode));
        }

        public void UpdateSettings(
            bool affectedByTransactions,
            int? activityNumber = null,
            decimal? defaultPricePercentage = null)
        {
            AffectedByTransactions = affectedByTransactions;
            ActivityNumber = activityNumber;
            DefaultPricePercentageFromPrimaryCost = defaultPricePercentage;

            AddDomainEvent(new ItemGroupSettingsUpdatedEvent(GroupCode));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(GroupCode))
                throw new DomainException("Group code is required");

            if (string.IsNullOrWhiteSpace(LocalName))
                throw new DomainException("Local name is required");
        }
    }
} 