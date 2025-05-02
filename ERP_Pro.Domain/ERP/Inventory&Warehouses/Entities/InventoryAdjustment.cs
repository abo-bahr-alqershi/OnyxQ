using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities
{
    public class InventoryAdjustment : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> نوع التسوية (جرد دوري، مفاجئ، ...). </summary>
        public short AdjustmentType { get; private set; }
        /// <summary> رقم مستند التسوية. </summary>
        public long DocumentNumber { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long DocumentSerial { get; private set; }
        /// <summary> تاريخ المستند. </summary>
        public DateTime DocumentDate { get; private set; }
        /// <summary> وصف التسوية. </summary>
        public string? Description { get; private set; }
        /// <summary> رقم مرجعي إضافي. </summary>
        public string? ReferenceNumber { get; private set; }
        #endregion

        #region Status
        /// <summary> تم ترحيل التسوية (1=نعم). </summary>
        public bool IsPosted { get; private set; }
        /// <summary> تسوية معلقة (1=نعم). </summary>
        public bool IsApproved { get; private set; }
        /// <summary> رقم مرجعي خارجي. </summary>
        public int? ExternalPost { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        public BranchInfo BranchInfo { get; private set; }
        #endregion

        #region Audit Info
        /// <summary> رقم المستخدم الذي أضاف السطر. </summary>
        public int? AddedByUserId { get; private set; }
        /// <summary> تاريخ الإضافة. </summary>
        public DateTime? AddedDate { get; private set; }
        /// <summary> المستخدم الذي عدل السطر. </summary>
        public int? UpdatedByUserId { get; private set; }
        /// <summary> تاريخ آخر تعديل. </summary>
        public DateTime? UpdatedDate { get; private set; }
        /// <summary> عدد مرات التعديل. </summary>
        public long? UpdateCount { get; private set; }
        /// <summary> اسم الجهاز عند الإضافة. </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> اسم الجهاز عند التعديل. </summary>
        public string? UpdatedTerminal { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<InventoryAdjustmentDetail> Details { get; private set; } = new List<InventoryAdjustmentDetail>();
        #endregion

        private InventoryAdjustment() { } // For EF Core

        public static InventoryAdjustment Create(
            short adjustmentType,
            long documentNumber,
            long documentSerial,
            DateTime documentDate,
            CompanyInfo companyInfo,
            BranchInfo branchInfo,
            int userId,
            string terminal)
        {
            var adjustment = new InventoryAdjustment
            {
                Id = Guid.NewGuid(),
                AdjustmentType = adjustmentType,
                DocumentNumber = documentNumber,
                DocumentSerial = documentSerial,
                DocumentDate = documentDate,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo,
                IsPosted = false,
                IsApproved = false,
                AddedByUserId = userId,
                AddedDate = DateTime.UtcNow,
                AddedTerminal = terminal,
                UpdateCount = 0
            };

            adjustment.AddDomainEvent(new InventoryAdjustmentCreatedEvent(adjustment));
            return adjustment;
        }

        public void UpdateDescription(string description)
        {
            var oldDescription = Description;
            Description = description;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryAdjustmentDescriptionUpdatedEvent(this, oldDescription, description));
        }

        public void UpdateReferenceNumber(string referenceNumber)
        {
            var oldReferenceNumber = ReferenceNumber;
            ReferenceNumber = referenceNumber;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryAdjustmentReferenceNumberUpdatedEvent(this, oldReferenceNumber, referenceNumber));
        }

        public void AddDetail(InventoryAdjustmentDetail detail)
        {
            if (IsPosted)
                throw new DomainException("Cannot add details to a posted adjustment");

            Details.Add(detail);
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryAdjustmentDetailAddedEvent(this, detail));
        }

        public void RemoveDetail(InventoryAdjustmentDetail detail)
        {
            if (IsPosted)
                throw new DomainException("Cannot remove details from a posted adjustment");

            Details.Remove(detail);
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryAdjustmentDetailRemovedEvent(this, detail));
        }

        public void Post(int userId)
        {
            if (IsPosted)
                throw new DomainException("Adjustment is already posted");

            if (!IsApproved)
                throw new DomainException("Adjustment must be approved before posting");

            if (!Details.Any())
                throw new DomainException("Cannot post an adjustment without details");

            IsPosted = true;
            UpdatedByUserId = userId;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryAdjustmentPostedEvent(this, userId));
        }

        public void Approve(int userId)
        {
            if (IsApproved)
                throw new DomainException("Adjustment is already approved");

            if (!Details.Any())
                throw new DomainException("Cannot approve an adjustment without details");

            IsApproved = true;
            UpdatedByUserId = userId;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryAdjustmentApprovedEvent(this, userId));
        }

        public void UpdateExternalPost(int externalPost)
        {
            var oldExternalPost = ExternalPost;
            ExternalPost = externalPost;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryAdjustmentExternalPostUpdatedEvent(this, oldExternalPost, externalPost));
        }

        private void ValidateState()
        {
            if (DocumentNumber <= 0)
                throw new DomainException("Document number must be positive");

            if (DocumentSerial <= 0)
                throw new DomainException("Document serial must be positive");

            if (DocumentDate == default)
                throw new DomainException("Document date is required");

            if (CompanyInfo == null)
                throw new DomainException("Company information is required");

            if (BranchInfo == null)
                throw new DomainException("Branch information is required");
        }
    }
}