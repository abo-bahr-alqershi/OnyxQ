using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class MasterJournalBranch : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رقم نوع القيد الرئيسي للفرع </summary>
        public JournalType JVType { get; private set; }
        /// <summary> رقم المستند الرئيسي للفرع </summary>
        public DocumentNumber JDocNo { get; private set; }
        /// <summary> الرقم التسلسلي للسطر </summary>
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
        /// <summary> وصف القيد </summary>
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

        private MasterJournalBranch() { } // For EF Core

        public static MasterJournalBranch Create(
            JournalType journalType,
            DocumentNumber documentNumber,
            DateTime journalDate,
            string description,
            CompanyInfo companyInfo,
            BranchInfo branchInfo,
            int userId,
            string terminal)
        {
            var journal = new MasterJournalBranch
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

            journal.AddDomainEvent(new JournalBranchCreatedEvent(journal));
            return journal;
        }

        public void Post(int userId)
        {
            if (JPost == true)
                throw new DomainException("Journal is already posted");

            JPost = true;
            PostingInfo = PostingInfo.Post(userId);

            AddDomainEvent(new JournalBranchPostedEvent(this));
        }

        public void Unpost(int userId)
        {
            if (JPost != true)
                throw new DomainException("Journal is not posted");

            JPost = false;
            PostingInfo = PostingInfo.Unpost(userId);

            AddDomainEvent(new JournalBranchUnpostedEvent(this));
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

            AddDomainEvent(new JournalBranchDescriptionUpdatedEvent(
                this, oldBenName, oldRecName, oldDesc));
        }

        public void UpdateAuditInfo(
            string auditDescription,
            int userId)
        {
            if (AuditRef == true)
                throw new DomainException("Journal is already audited");

            AuditRef = true;
            AuditRefDesc = auditDescription;
            AuditRefUserId = userId;
            AuditRefDate = DateTime.UtcNow;

            AddDomainEvent(new JournalBranchAuditedEvent(this));
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