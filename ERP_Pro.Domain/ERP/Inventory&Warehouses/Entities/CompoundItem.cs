using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class CompoundItem : AggregateRoot
    {
        #region Basic Info
        /// <summary> رقم المستند. </summary>
        public long DocumentNumber { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long? DocumentSerial { get; private set; }
        /// <summary> تاريخ المستند. </summary>
        public DateTime DocumentDate { get; private set; }
        /// <summary> وصف المستند. </summary>
        public string? DocumentDescription { get; private set; }
        /// <summary> رقم مرجعي إضافي. </summary>
        public string? ReferenceNumber { get; private set; }
        #endregion

        #region Item Info
        /// <summary> معلومات الصنف المركب. </summary>
        public CompoundItemInfo ItemInfo { get; private set; }
        /// <summary> تكاليف الصنف المركب. </summary>
        public CompoundItemCost ItemCost { get; private set; }
        /// <summary> كميات الصنف المركب. </summary>
        public CompoundItemQuantities ItemQuantities { get; private set; }
        #endregion

        #region Warehouse Info
        /// <summary> المستودع المحول منه. </summary>
        public long? FromWarehouse { get; private set; }
        /// <summary> المستودع المحول إليه. </summary>
        public long? ToWarehouse { get; private set; }
        #endregion

        #region References
        /// <summary> مركز التكلفة. </summary>
        public string? CostCenterCode { get; private set; }
        /// <summary> رقم المشروع. </summary>
        public string? ProjectNumber { get; private set; }
        /// <summary> رقم النشاط. </summary>
        public string? ActivityNumber { get; private set; }
        /// <summary> رقم الموظف المرتبط. </summary>
        public long? EmployeeNumber { get; private set; }
        #endregion

        #region Status
        /// <summary> تم معالجة السطر (1=نعم). </summary>
        public bool? Processed { get; private set; }
        /// <summary> عملية معلقة (1=نعم). </summary>
        public bool? Hung { get; private set; }
        /// <summary> تم الترحيل للمحاسبة (1=نعم). </summary>
        public bool? Posted { get; private set; }
        #endregion

        #region Audit Info
        /// <summary> المستخدم الذي أضاف السطر. </summary>
        public int? AddedByUserId { get; private set; }
        /// <summary> تاريخ الإضافة. </summary>
        public DateTime? AddedDate { get; private set; }
        /// <summary> المستخدم الذي عدل السطر. </summary>
        public int? UpdatedByUserId { get; private set; }
        /// <summary> تاريخ آخر تعديل. </summary>
        public DateTime? UpdatedDate { get; private set; }
        /// <summary> المستخدم الذي رحل المستند. </summary>
        public int? PostUserId { get; private set; }
        /// <summary> تاريخ الترحيل. </summary>
        public DateTime? PostDate { get; private set; }
        /// <summary> المستخدم الذي ألغى الترحيل. </summary>
        public int? UnpostUserId { get; private set; }
        /// <summary> تاريخ إلغاء الترحيل. </summary>
        public DateTime? UnpostDate { get; private set; }
        /// <summary> مرجع التدقيق. </summary>
        public bool? AuditRef { get; private set; }
        /// <summary> وصف مرجع التدقيق. </summary>
        public string? AuditRefDesc { get; private set; }
        /// <summary> رقم المستخدم لمرجع التدقيق. </summary>
        public int? AuditRefUserId { get; private set; }
        /// <summary> تاريخ مرجع التدقيق. </summary>
        public DateTime? AuditRefDate { get; private set; }
        #endregion

        #region Company Info
        /// <summary> رقم الشركة. </summary>
        public short CompanyNumber { get; private set; }
        /// <summary> رقم الفرع. </summary>
        public int BranchNumber { get; private set; }
        /// <summary> السنة المالية للفرع. </summary>
        public short? BranchYear { get; private set; }
        /// <summary> مستخدم الفرع. </summary>
        public short? BranchUser { get; private set; }
        /// <summary> عدد مرات التعديل. </summary>
        public long? UpdateCount { get; private set; }
        /// <summary> أولوية التقرير. </summary>
        public long? ReportPriority { get; private set; }
        /// <summary> الجهاز عند الإضافة. </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> الجهاز عند التعديل. </summary>
        public string? UpdatedTerminal { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual Project Project { get; private set; }
        public virtual IReadOnlyCollection<CompoundItemDetail> CompoundItemDetails => _compoundItemDetails.AsReadOnly();
        private readonly List<CompoundItemDetail> _compoundItemDetails = new();
        #endregion

        private CompoundItem() { } // For EF Core

        public static CompoundItem Create(
            long documentNumber,
            DateTime documentDate,
            CompoundItemInfo itemInfo,
            CompoundItemCost itemCost,
            CompoundItemQuantities itemQuantities,
            short companyNumber,
            int branchNumber,
            int userId,
            string terminal)
        {
            var compoundItem = new CompoundItem
            {
                DocumentNumber = documentNumber,
                DocumentDate = documentDate,
                ItemInfo = itemInfo,
                ItemCost = itemCost,
                ItemQuantities = itemQuantities,
                CompanyNumber = companyNumber,
                BranchNumber = branchNumber,
                AddedByUserId = userId,
                AddedDate = DateTime.Now,
                AddedTerminal = terminal,
                UpdateCount = 0
            };

            compoundItem.AddDomainEvent(new CompoundItemCreatedEvent(compoundItem));
            return compoundItem;
        }

        public void UpdateItemInfo(CompoundItemInfo itemInfo)
        {
            ItemInfo = itemInfo;
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;
            AddDomainEvent(new CompoundItemUpdatedEvent(this));
        }

        public void UpdateItemCost(CompoundItemCost itemCost)
        {
            ItemCost = itemCost;
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;
            AddDomainEvent(new CompoundItemUpdatedEvent(this));
        }

        public void UpdateItemQuantities(CompoundItemQuantities itemQuantities)
        {
            ItemQuantities = itemQuantities;
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;
            AddDomainEvent(new CompoundItemUpdatedEvent(this));
        }

        public void Post(int userId)
        {
            if (Posted == true)
                throw new DomainException("Document is already posted");

            Posted = true;
            PostUserId = userId;
            PostDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;
            AddDomainEvent(new CompoundItemPostedEvent(this));
        }

        public void Unpost(int userId)
        {
            if (Posted != true)
                throw new DomainException("Document is not posted");

            Posted = false;
            UnpostUserId = userId;
            UnpostDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;
            AddDomainEvent(new CompoundItemUnpostedEvent(this));
        }

        public void AddDetail(CompoundItemDetail detail)
        {
            _compoundItemDetails.Add(detail);
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;
            AddDomainEvent(new CompoundItemDetailAddedEvent(this, detail));
        }

        public void RemoveDetail(CompoundItemDetail detail)
        {
            _compoundItemDetails.Remove(detail);
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;
            AddDomainEvent(new CompoundItemDetailRemovedEvent(this, detail));
        }
    }
}