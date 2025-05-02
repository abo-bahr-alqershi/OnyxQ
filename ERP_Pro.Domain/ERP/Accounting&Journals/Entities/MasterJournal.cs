using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class MasterJournal : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> نوع القيد الرئيسي </summary>
        public short JVType { get; private set; }
        /// <summary> رقم المستند الرئيسي </summary>
        public long JDocNo { get; private set; }
        /// <summary> الرقم التسلسلي </summary>
        public long? JSerial { get; private set; }
        /// <summary> حالة الترحيل (1=مرحل) </summary>
        public bool? JPost { get; private set; }
        /// <summary> تاريخ القيد </summary>
        public DateTime JDate { get; private set; }
        /// <summary> قيمة الدفعة </summary>
        public int? BatchVal { get; private set; }
        /// <summary> رقم مرجعي إضافي </summary>
        public string? RefNo { get; private set; }
        #endregion

        #region Journal Settings
        /// <summary> علم يوضح إذا كان القيد عكسي </summary>
        public bool? RevrsJrnl { get; private set; }
        /// <summary> علم يوضح إذا كان القيد دوري </summary>
        public bool? PeriodicalJrnl { get; private set; }
        /// <summary> احتياطي نقدي </summary>
        public bool? CashReserve { get; private set; }
        /// <summary> قيد احتياطي </summary>
        public bool? StandBy { get; private set; }
        /// <summary> استخدام الربط </summary>
        public bool? LinkUse { get; private set; }
        /// <summary> رقم المرفق </summary>
        public short? AttachNo { get; private set; }
        #endregion

        #region Description Info
        /// <summary> اسم المستفيد </summary>
        public string? BenName { get; private set; }
        /// <summary> اسم المستلم </summary>
        public string? RecName { get; private set; }
        /// <summary> وصف القيد الرئيسي </summary>
        public string? TDesc { get; private set; }
        #endregion

        #region Audit Info
        /// <summary> مرجع التدقيق </summary>
        public bool? AuditRef { get; private set; }
        /// <summary> وصف مرجع التدقيق </summary>
        public string? AuditRefDesc { get; private set; }
        /// <summary> رقم المستخدم لمرجع التدقيق </summary>
        public int? AuditRefUserId { get; private set; }
        /// <summary> تاريخ مرجع التدقيق </summary>
        public DateTime? AuditRefDate { get; private set; }
        /// <summary> أولوية التقرير </summary>
        public long? ReportPriority { get; private set; }
        #endregion

        #region Flags
        /// <summary> إغلاق الأرصدة الصفرية </summary>
        public bool? ClsZeroAcBlc { get; private set; }
        /// <summary> علم الترحيل الخارجي </summary>
        public int? ExternalPost { get; private set; }
        #endregion

        #region Company Info
        /// <summary> رقم الشركة </summary>
        public short CompanyNo { get; private set; }
        /// <summary> رقم الفرع </summary>
        public int BranchNo { get; private set; }
        /// <summary> سنة الفرع </summary>
        public short? BranchYear { get; private set; }
        /// <summary> مستخدم الفرع </summary>
        public short? BranchUser { get; private set; }
        /// <summary> اسم الجهاز عند الإضافة </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> اسم الجهاز عند التعديل </summary>
        public string? UpdatedTerminal { get; private set; }
        public CompanyInfo CompanyInfo { get; private set; }
        public BranchInfo BranchInfo { get; private set; }
        #endregion

        #region Posting Info
        public PostingInfo PostingInfo { get; private set; }
        #endregion

        #region Additional Fields
        /// <summary> حقل إضافي </summary>
        public string? Field1 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field2 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field3 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field4 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field5 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field6 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field7 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field8 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field9 { get; private set; }
        /// <summary> حقل إضافي </summary>
        public string? Field10 { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual IReadOnlyCollection<JournalDetail> JournalDetails => _journalDetails.AsReadOnly();
        public virtual IReadOnlyCollection<JournalDetailBranch> JournalDetailBranchs => _journalDetailBranches.AsReadOnly();
        #endregion

        #region Private Collections
        private readonly List<JournalDetail> _journalDetails = new();
        private readonly List<JournalDetailBranch> _journalDetailBranches = new();
        #endregion

        private MasterJournal() { } // For EF Core

        public static MasterJournal Create(
            JournalType journalType,
            DocumentNumber documentNumber,
            DateTime journalDate,
            string description,
            CompanyInfo companyInfo,
            BranchInfo branchInfo,
            int userId,
            string terminal)
        {
            var journal = new MasterJournal
            {
                Id = Guid.NewGuid(),
                JVType = journalType,
                JDocNo = documentNumber,
                JDate = journalDate,
                TDesc = description,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo,
                JPost = false,
                RevrsJrnl = false,
                PeriodicalJrnl = false,
                CashReserve = false,
                StandBy = false,
                LinkUse = false,
                ClsZeroAcBlc = false,
                PostingInfo = PostingInfo.Create(userId, terminal)
            };

            journal.AddDomainEvent(new JournalCreatedEvent(journal));
            return journal;
        }

        public void AddDetail(JournalDetail detail)
        {
            _journalDetails.Add(detail);
            AddDomainEvent(new JournalDetailAddedEvent(this, detail));
        }

        public void AddBranchDetail(JournalDetailBranch detail)
        {
            _journalDetailBranches.Add(detail);
            AddDomainEvent(new JournalBranchDetailAddedEvent(this, detail));
        }

        public void Post(int userId)
        {
            if (JPost)
                throw new DomainException("Journal is already posted");

            JPost = true;
            PostingInfo = PostingInfo.Post(userId);

            AddDomainEvent(new JournalPostedEvent(this));
        }

        public void Unpost(int userId)
        {
            if (!JPost)
                throw new DomainException("Journal is not posted");

            JPost = false;
            PostingInfo = PostingInfo.Unpost(userId);

            AddDomainEvent(new JournalUnpostedEvent(this));
        }

        public void UpdateDescription(
            string beneficiaryName,
            string receiverName,
            string description)
        {
            var oldBenName = BenName;
            var oldRecName = RecName;
            var oldDesc = TDesc;

            BenName = beneficiaryName;
            RecName = receiverName;
            TDesc = description;

            AddDomainEvent(new JournalDescriptionUpdatedEvent(
                this, oldBenName, oldRecName, oldDesc));
        }

        public void UpdateAuditInfo(
            string auditDescription,
            int userId)
        {
            if (AuditRef)
                throw new DomainException("Journal is already audited");

            AuditRef = true;
            AuditRefDesc = auditDescription;
            AuditRefUserId = userId;
            AuditRefDate = DateTime.UtcNow;

            AddDomainEvent(new JournalAuditedEvent(this));
        }

        private void ValidateState()
        {
            if (JVType == null)
                throw new DomainException("Journal type is required");

            if (JDocNo == null)
                throw new DomainException("Document number is required");

            if (JDate == default)
                throw new DomainException("Journal date is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (BranchInfo == null)
                throw new DomainException("Branch info is required");
        }
    }
}