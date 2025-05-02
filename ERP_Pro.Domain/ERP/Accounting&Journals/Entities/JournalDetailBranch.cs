using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class JournalDetailBranch : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
        public Guid JournalId { get; private set; }
        /// <summary> نوع القيد المحاسبي </summary>
        public short JVType { get; private set; }
        /// <summary> رقم المستند المحاسبي </summary>
        public long JDocNo { get; private set; }
        /// <summary> الرقم التسلسلي للسطر </summary>
        public long? JSerial { get; private set; }
        /// <summary> رقم السطر في القيد </summary>
        public long? RecordNo { get; private set; }
        #endregion

        #region Branch Info
        /// <summary> رقم الفرع المصدر </summary>
        public int FromBranchNo { get; private set; }
        /// <summary> رقم الفرع الهدف </summary>
        public int ToBranchNo { get; private set; }
        /// <summary> سنة الفرع المصدر </summary>
        public short FromBranchYear { get; private set; }
        /// <summary> سنة الفرع الهدف </summary>
        public short ToBranchYear { get; private set; }
        #endregion

        #region Amount Info
        /// <summary> المبلغ المحاسبي بالعملة المحلية </summary>
        public Money LocalAmount { get; private set; }
        /// <summary> المبلغ بالعملة الأجنبية </summary>
        public Money ForeignAmount { get; private set; }
        /// <summary> سعر صرف الحساب </summary>
        public ExchangeRate ExchangeRate { get; private set; }
        /// <summary> رمز العملة </summary>
        public string CurrencyCode { get; private set; }
        #endregion

        #region Account Info
        /// <summary> كود الحساب </summary>
        public string AccountCode { get; private set; }
        /// <summary> كود التفاصيل للحساب </summary>
        public string AccountDtlCode { get; private set; }
        /// <summary> كود التفاصيل الفرعية للحساب </summary>
        public string AccountDtlSub { get; private set; }
        /// <summary> نوع التفاصيل للحساب </summary>
        public short? AccountDtlType { get; private set; }
        #endregion

        #region Reference Info
        /// <summary> كود مركز التكلفة </summary>
        public string CostCenterCode { get; private set; }
        /// <summary> رقم المشروع المرتبط بالسطر </summary>
        public string ProjectNo { get; private set; }
        /// <summary> رقم النشاط </summary>
        public string ActivityNo { get; private set; }
        /// <summary> كود العميل </summary>
        public string CCode { get; private set; }
        /// <summary> كود المورد </summary>
        public string VCode { get; private set; }
        /// <summary> كود التقرير </summary>
        public string ReportCode { get; private set; }
        #endregion

        #region Document References
        /// <summary> نوع المستند المرجعي </summary>
        public int? DocTypeRef { get; private set; }
        /// <summary> نوع القيد المرجعي </summary>
        public int? DocJVTypeRef { get; private set; }
        /// <summary> رقم المستند المرجعي </summary>
        public long? DocNoRef { get; private set; }
        /// <summary> الرقم التسلسلي للمستند المرجعي </summary>
        public long? DocSerRef { get; private set; }
        /// <summary> تاريخ الاستحقاق للمستند المرجعي </summary>
        public DateTime? DocDueDate { get; private set; }
        #endregion

        #region Additional References
        /// <summary> رقم مرجعي إضافي </summary>
        public string RefNo { get; private set; }
        /// <summary> ملاحظات </summary>
        public string Note { get; private set; }
        /// <summary> تسلسل المستند </summary>
        public long? DocSequence { get; private set; }
        /// <summary> علم الترحيل الخارجي </summary>
        public int? ExternalPost { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        public BranchInfo BranchInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual MasterJournal Journal { get; private set; }
        public virtual AccountCurrency AccountCurrency { get; private set; }
        public virtual Project Project { get; private set; }
        public virtual Customer Customer { get; private set; }
        #endregion

        private JournalDetailBranch() { } // For EF Core

        public static JournalDetailBranch Create(
            Guid journalId,
            short jvType,
            long jDocNo,
            int fromBranchNo,
            int toBranchNo,
            short fromBranchYear,
            short toBranchYear,
            string accountCode,
            Money localAmount,
            Money foreignAmount,
            ExchangeRate exchangeRate,
            CompanyInfo companyInfo,
            BranchInfo branchInfo,
            int userId,
            string terminal)
        {
            var detail = new JournalDetailBranch
            {
                Id = Guid.NewGuid(),
                JournalId = journalId,
                JVType = jvType,
                JDocNo = jDocNo,
                FromBranchNo = fromBranchNo,
                ToBranchNo = toBranchNo,
                FromBranchYear = fromBranchYear,
                ToBranchYear = toBranchYear,
                AccountCode = accountCode,
                LocalAmount = localAmount,
                ForeignAmount = foreignAmount,
                ExchangeRate = exchangeRate,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            detail.AddDomainEvent(new JournalDetailBranchCreatedEvent(detail));
            return detail;
        }

        public void UpdateAmounts(
            Money localAmount,
            Money foreignAmount,
            ExchangeRate exchangeRate)
        {
            var oldLocalAmount = LocalAmount;
            var oldForeignAmount = ForeignAmount;
            var oldExchangeRate = ExchangeRate;

            LocalAmount = localAmount;
            ForeignAmount = foreignAmount;
            ExchangeRate = exchangeRate;

            AddDomainEvent(new JournalDetailBranchAmountsUpdatedEvent(
                this, oldLocalAmount, oldForeignAmount, oldExchangeRate));
        }

        public void UpdateReferences(
            string costCenterCode,
            string projectNo,
            string activityNo,
            string customerCode,
            string vendorCode,
            string reportCode)
        {
            var oldCostCenterCode = CostCenterCode;
            var oldProjectNo = ProjectNo;
            var oldActivityNo = ActivityNo;
            var oldCustomerCode = CCode;
            var oldVendorCode = VCode;
            var oldReportCode = ReportCode;

            CostCenterCode = costCenterCode;
            ProjectNo = projectNo;
            ActivityNo = activityNo;
            CCode = customerCode;
            VCode = vendorCode;
            ReportCode = reportCode;

            AddDomainEvent(new JournalDetailBranchReferencesUpdatedEvent(
                this,
                oldCostCenterCode,
                oldProjectNo,
                oldActivityNo,
                oldCustomerCode,
                oldVendorCode,
                oldReportCode));
        }

        public void UpdateNote(string note)
        {
            var oldNote = Note;
            Note = note;

            AddDomainEvent(new JournalDetailBranchNoteUpdatedEvent(this, oldNote));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(AccountCode))
                throw new DomainException("Account code is required");

            if (LocalAmount == null)
                throw new DomainException("Local amount is required");

            if (ExchangeRate == null && ForeignAmount != null)
                throw new DomainException("Exchange rate is required when foreign amount is specified");

            if (FromBranchNo <= 0)
                throw new DomainException("From branch number is required");

            if (ToBranchNo <= 0)
                throw new DomainException("To branch number is required");

            if (FromBranchYear <= 0)
                throw new DomainException("From branch year is required");

            if (ToBranchYear <= 0)
                throw new DomainException("To branch year is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (BranchInfo == null)
                throw new DomainException("Branch info is required");
        }
    }
}