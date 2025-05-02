using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class ItemGroupTree : AggregateRoot
    {
        #region Basic Info
        /// <summary> كود المجموعة </summary>
        public string GroupCode { get; private set; }
        /// <summary> كود شجرة المجموعة </summary>
        public string GroupCodeTree { get; private set; }
        /// <summary> اسم المجموعة </summary>
        public string GroupName { get; private set; }
        /// <summary> مستوى المجموعة </summary>
        public int? GroupLevel { get; private set; }
        #endregion

        #region Item Info
        /// <summary> معلومات الصنف </summary>
        public CompoundItemInfo ItemInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual ItemGroup ItemGroup { get; private set; }
        public virtual IReadOnlyCollection<ItemGroupTree> Children => _children.AsReadOnly();
        private readonly List<ItemGroupTree> _children = new();
        #endregion

        private ItemGroupTree() { } // For EF Core

        public static ItemGroupTree Create(
            string groupCode,
            string groupCodeTree,
            string groupName,
            CompoundItemInfo itemInfo,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            if (string.IsNullOrWhiteSpace(groupCode))
                throw new DomainException("Group code is required");
            if (string.IsNullOrWhiteSpace(groupCodeTree))
                throw new DomainException("Group code tree is required");
            if (string.IsNullOrWhiteSpace(groupName))
                throw new DomainException("Group name is required");

            var tree = new ItemGroupTree
            {
                GroupCode = groupCode,
                GroupCodeTree = groupCodeTree,
                GroupName = groupName,
                ItemInfo = itemInfo,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            tree.AddDomainEvent(new ItemGroupTreeCreatedEvent(tree));
            return tree;
        }

        public void UpdateGroupInfo(
            string groupName,
            int? groupLevel,
            int userId,
            string terminal)
        {
            if (string.IsNullOrWhiteSpace(groupName))
                throw new DomainException("Group name is required");

            GroupName = groupName;
            GroupLevel = groupLevel;

            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new ItemGroupTreeUpdatedEvent(this));
        }

        public void UpdateItemInfo(
            CompoundItemInfo itemInfo,
            int userId,
            string terminal)
        {
            ItemInfo = itemInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new ItemGroupTreeUpdatedEvent(this));
        }

        public void AddChild(ItemGroupTree child)
        {
            if (child == null)
                throw new DomainException("Child group tree cannot be null");

            _children.Add(child);
            AddDomainEvent(new ItemGroupTreeChildAddedEvent(this, child));
        }

        public void RemoveChild(ItemGroupTree child)
        {
            if (child == null)
                throw new DomainException("Child group tree cannot be null");

            _children.Remove(child);
            AddDomainEvent(new ItemGroupTreeChildRemovedEvent(this, child));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(GroupCode))
                throw new DomainException("Group code is required");

            if (string.IsNullOrWhiteSpace(GroupCodeTree))
                throw new DomainException("Group code tree is required");

            if (string.IsNullOrWhiteSpace(GroupName))
                throw new DomainException("Group name is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");
        }
    }
}