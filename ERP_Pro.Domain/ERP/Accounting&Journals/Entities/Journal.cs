using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class Journal : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> نوع القيد </summary>
        public short JVType { get; private set; }
        /// <summary> رقم المستند </summary>
        public long DocumentNo { get; private set; }
        /// <summary> الرقم التسلسلي </summary>
        public long? Serial { get; private set; }
        /// <summary> حالة الترحيل </summary>
        public bool IsPosted { get; private set; }
        /// <summary> تاريخ القيد </summary>
        public DateTime JournalDate { get; private set; }
        /// <summary> قيمة الدفعة </summary>
        public decimal? BatchValue { get; private set; }
        /// <summary> رقم المرجع </summary>
        public string? ReferenceNo { get; private set; }
        #endregion

        #region Journal Flags
        /// <summary> قيد عكسي </summary>
        public bool IsReversalJournal { get; private set; }
        /// <summary> قيد دوري </summary>
        public bool IsPeriodicalJournal { get; private set; }
        /// <summary> احتياطي نقدي </summary>
        public bool IsCashReserve { get; private set; }
        /// <summary> احتياطي </summary>
        public bool IsStandBy { get; private set; }
        /// <summary> استخدام الربط </summary>
        public bool UseLinkage { get; private set; }
        /// <summary> إغلاق الأرصدة الصفرية </summary>
        public bool CloseZeroBalances { get; private set; }
        #endregion

        #region Additional Info
        /// <summary> عدد المرفقات </summary>
        public short? AttachmentCount { get; private set; }
        /// <summary> اسم المستفيد </summary>
        public string? BeneficiaryName { get; private set; }
        /// <summary> اسم المستلم </summary>
        public string? ReceiverName { get; private set; }
        /// <summary> الوصف </summary>
        public string? Description { get; private set; }
        #endregion

        #region Audit References
        /// <summary> مرجع التدقيق </summary>
        public bool HasAuditReference { get; private set; }
        /// <summary> وصف مرجع التدقيق </summary>
        public string? AuditReferenceDescription { get; private set; }
        /// <summary> رقم مستخدم مرجع التدقيق </summary>
        public int? AuditReferenceUserId { get; private set; }
        /// <summary> تاريخ مرجع التدقيق </summary>
        public DateTime? AuditReferenceDate { get; private set; }
        #endregion

        #region External Info
        /// <summary> حالة الترحيل الخارجي </summary>
        public int? ExternalPost { get; private set; }
        #endregion

        #region Additional Fields
        /// <summary> حقول إضافية </summary>
        public string? Field1 { get; private set; }
        public string? Field2 { get; private set; }
        public string? Field3 { get; private set; }
        public string? Field4 { get; private set; }
        public string? Field5 { get; private set; }
        public string? Field6 { get; private set; }
        public string? Field7 { get; private set; }
        public string? Field8 { get; private set; }
        public string? Field9 { get; private set; }
        public string? Field10 { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        public BranchInfo BranchInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        public int? PostedByUserId { get; private set; }
        public DateTime? PostedDate { get; private set; }
        public int? UnpostedByUserId { get; private set; }
        public DateTime? UnpostedDate { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual IReadOnlyCollection<JournalDetail> Details => _details.AsReadOnly();
        #endregion

        #region Private Collections
        private readonly List<JournalDetail> _details = new();
        #endregion

        private Journal() { } // For EF Core

        public static Journal Create(
            short jvType,
            long documentNo,
            long? serial,
            DateTime journalDate,
            decimal? batchValue,
            string? referenceNo,
            bool isReversalJournal,
            bool isPeriodicalJournal,
            bool isCashReserve,
            bool isStandBy,
            bool useLinkage,
            bool closeZeroBalances,
            short? attachmentCount,
            string? beneficiaryName,
            string? receiverName,
            string? description,
            CompanyInfo companyInfo,
            BranchInfo branchInfo,
            int userId,
            string terminal)
        {
            var journal = new Journal
            {
                Id = Guid.NewGuid(),
                JVType = jvType,
                DocumentNo = documentNo,
                Serial = serial,
                IsPosted = false,
                JournalDate = journalDate,
                BatchValue = batchValue,
                ReferenceNo = referenceNo,
                IsReversalJournal = isReversalJournal,
                IsPeriodicalJournal = isPeriodicalJournal,
                IsCashReserve = isCashReserve,
                IsStandBy = isStandBy,
                UseLinkage = useLinkage,
                CloseZeroBalances = closeZeroBalances,
                AttachmentCount = attachmentCount,
                BeneficiaryName = beneficiaryName,
                ReceiverName = receiverName,
                Description = description,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            journal.ValidateState();
            journal.AddDomainEvent(new JournalCreatedEvent(journal));
            return journal;
        }

        public void AddDetail(JournalDetail detail)
        {
            if (IsPosted)
                throw new DomainException("Cannot add details to a posted journal");

            _details.Add(detail);
            AddDomainEvent(new JournalDetailAddedEvent(this, detail));
        }

        public void RemoveDetail(JournalDetail detail)
        {
            if (IsPosted)
                throw new DomainException("Cannot remove details from a posted journal");

            _details.Remove(detail);
            AddDomainEvent(new JournalDetailRemovedEvent(this, detail));
        }

        public void Post(int userId)
        {
            if (IsPosted)
                throw new DomainException("Journal is already posted");

            if (!_details.Any())
                throw new DomainException("Cannot post a journal without details");

            var totalDebit = _details.Sum(d => d.Debit);
            var totalCredit = _details.Sum(d => d.Credit);

            if (totalDebit != totalCredit)
                throw new DomainException("Journal is not balanced");

            IsPosted = true;
            PostedByUserId = userId;
            PostedDate = DateTime.UtcNow;

            AddDomainEvent(new JournalPostedEvent(this));
        }

        public void Unpost(int userId)
        {
            if (!IsPosted)
                throw new DomainException("Journal is not posted");

            IsPosted = false;
            UnpostedByUserId = userId;
            UnpostedDate = DateTime.UtcNow;

            AddDomainEvent(new JournalUnpostedEvent(this));
        }

        public void UpdateAuditReference(
            string description,
            int userId)
        {
            HasAuditReference = true;
            AuditReferenceDescription = description;
            AuditReferenceUserId = userId;
            AuditReferenceDate = DateTime.UtcNow;

            AddDomainEvent(new JournalAuditReferenceUpdatedEvent(this));
        }

        public void ClearAuditReference()
        {
            HasAuditReference = false;
            AuditReferenceDescription = null;
            AuditReferenceUserId = null;
            AuditReferenceDate = null;

            AddDomainEvent(new JournalAuditReferenceClearedEvent(this));
        }

        private void ValidateState()
        {
            if (JVType <= 0)
                throw new DomainException("Journal type must be greater than zero");

            if (DocumentNo <= 0)
                throw new DomainException("Document number must be greater than zero");

            if (JournalDate == default)
                throw new DomainException("Journal date is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (BranchInfo == null)
                throw new DomainException("Branch info is required");
        }
    }
} 