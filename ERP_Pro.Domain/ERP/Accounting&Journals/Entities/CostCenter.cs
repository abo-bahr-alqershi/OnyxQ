using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class CostCenter : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رمز مركز التكلفة </summary>
        public string Code { get; private set; }
        /// <summary> اسم مركز التكلفة بالعربي </summary>
        public string NameAr { get; private set; }
        /// <summary> اسم مركز التكلفة بالإنجليزي </summary>
        public string? NameEn { get; private set; }
        /// <summary> مستوى مركز التكلفة </summary>
        public short Level { get; private set; }
        /// <summary> نوع مركز التكلفة </summary>
        public CostCenterType Type { get; private set; }
        /// <summary> حالة مركز التكلفة </summary>
        public bool IsActive { get; private set; }
        #endregion

        #region Parent Cost Center
        /// <summary> رمز مركز التكلفة الأب </summary>
        public string? ParentCode { get; private set; }
        public CostCenter? Parent { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual IReadOnlyCollection<JournalDetail> JournalDetails => _journalDetails.AsReadOnly();
        public virtual IReadOnlyCollection<VoucherDetail> VoucherDetails => _voucherDetails.AsReadOnly();
        #endregion

        #region Private Collections
        private readonly List<JournalDetail> _journalDetails = new();
        private readonly List<VoucherDetail> _voucherDetails = new();
        #endregion

        private CostCenter() { } // For EF Core

        public static CostCenter Create(
            string code,
            string nameAr,
            string? nameEn,
            short level,
            CostCenterType type,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var costCenter = new CostCenter
            {
                Id = Guid.NewGuid(),
                Code = code,
                NameAr = nameAr,
                NameEn = nameEn,
                Level = level,
                Type = type,
                IsActive = true,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            costCenter.AddDomainEvent(new CostCenterCreatedEvent(costCenter));
            return costCenter;
        }

        public void UpdateNames(string nameAr, string? nameEn)
        {
            var oldNameAr = NameAr;
            var oldNameEn = NameEn;

            NameAr = nameAr;
            NameEn = nameEn;

            AddDomainEvent(new CostCenterNamesUpdatedEvent(this, oldNameAr, oldNameEn));
        }

        public void SetParent(CostCenter parent)
        {
            if (parent == null)
                throw new DomainException("Parent cost center cannot be null");

            var oldParentCode = ParentCode;
            ParentCode = parent.Code;
            Parent = parent;

            AddDomainEvent(new CostCenterParentUpdatedEvent(this, oldParentCode));
        }

        public void Activate()
        {
            if (IsActive)
                throw new DomainException("Cost center is already active");

            IsActive = true;
            AddDomainEvent(new CostCenterActivatedEvent(this));
        }

        public void Deactivate()
        {
            if (!IsActive)
                throw new DomainException("Cost center is already inactive");

            IsActive = false;
            AddDomainEvent(new CostCenterDeactivatedEvent(this));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(Code))
                throw new DomainException("Cost center code is required");

            if (string.IsNullOrWhiteSpace(NameAr))
                throw new DomainException("Cost center Arabic name is required");

            if (Level <= 0)
                throw new DomainException("Cost center level must be greater than zero");

            if (Type == null)
                throw new DomainException("Cost center type is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");
        }
    }

    public enum CostCenterType
    {
        /// <summary> مركز تكلفة إداري </summary>
        Administrative = 1,
        /// <summary> مركز تكلفة إنتاجي </summary>
        Production = 2,
        /// <summary> مركز تكلفة بيعي </summary>
        Sales = 3,
        /// <summary> مركز تكلفة خدمي </summary>
        Service = 4
    }
} 