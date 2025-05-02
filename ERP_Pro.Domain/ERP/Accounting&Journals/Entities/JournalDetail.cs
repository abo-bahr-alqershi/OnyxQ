using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;
using ERP_Pro.Domain.ERP.HR&Payroll.ValueObjects;
using ERP_Pro.Domain.ERP.Taxation.ValueObjects;
using ERP_Pro.Domain.ERP.Sales&Customers.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class JournalDetail : Entity
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
        /// <summary> رمز الحساب </summary>
        public string AccountCode { get; private set; }
        /// <summary> رمز الحساب التفصيلي </summary>
        public string? AccountDetailCode { get; private set; }
        /// <summary> رمز العملة </summary>
        public string? CurrencyCode { get; private set; }
        /// <summary> سعر الصرف </summary>
        public decimal? ExchangeRate { get; private set; }
        /// <summary> المبلغ المدين </summary>
        public decimal Debit { get; private set; }
        /// <summary> المبلغ الدائن </summary>
        public decimal Credit { get; private set; }
        /// <summary> رمز مركز التكلفة </summary>
        public string? CostCenterCode { get; private set; }
        /// <summary> رمز المشروع </summary>
        public string? ProjectCode { get; private set; }
        /// <summary> الوصف </summary>
        public string? Description { get; private set; }
        #endregion

        #region Account Info
        /// <summary> كود التفاصيل للحساب </summary>
        public AccountDetailInfo AccountDetailInfo { get; private set; }
        #endregion

        #region Amount Info
        /// <summary> المبلغ المحاسبي بالعملة المحلية </summary>
        public Money LocalAmount { get; private set; }
        /// <summary> المبلغ بالعملة الأجنبية </summary>
        public Money ForeignAmount { get; private set; }
        #endregion

        #region Reference Info
        /// <summary> رقم المشروع المرتبط بالسطر </summary>
        public string? ProjectNo { get; private set; }
        /// <summary> رقم النشاط </summary>
        public string? ActivityNo { get; private set; }
        /// <summary> كود العميل </summary>
        public string? CCode { get; private set; }
        /// <summary> كود المورد </summary>
        public string? VCode { get; private set; }
        /// <summary> كود التقرير </summary>
        public string? ReportCode { get; private set; }
        /// <summary> رقم المحصل </summary>
        public long? CollectorNo { get; private set; }
        #endregion

        #region Document References
        /// <summary> رقم الاعتماد المستندي </summary>
        public string? LCNo { get; private set; }
        /// <summary> رقم أمر التوريد/الإصدار </summary>
        public string? GRNo { get; private set; }
        /// <summary> رقم الصندوق أو البنك </summary>
        public long? CashBankNo { get; private set; }
        /// <summary> رقم السطر في القيد </summary>
        public long? RecordNo { get; private set; }
        /// <summary> رقم السطر الترتيبي </summary>
        public long? RecordNoOrd { get; private set; }
        /// <summary> رقم الاعتماد المستندي </summary>
        public DocumentReference DocumentReference { get; private set; }
        #endregion

        #region Bill Info
        /// <summary> رقم الفاتورة </summary>
        public long? BillNo { get; private set; }
        /// <summary> الرقم التسلسلي للفاتورة </summary>
        public long? BillSer { get; private set; }
        /// <summary> رقم أمين الصندوق </summary>
        public int? CashierNo { get; private set; }
        /// <summary> رقم الفاتورة </summary>
        public BillReference BillReference { get; private set; }
        #endregion

        #region Item Info
        /// <summary> رقم العنصر </summary>
        public long? INo { get; private set; }
        /// <summary> رقم أمر العمل </summary>
        public long? WONo { get; private set; }
        /// <summary> الرقم التسلسلي لأمر العمل </summary>
        public long? WOSer { get; private set; }
        /// <summary> رقم أمر العمل </summary>
        public ItemReference ItemReference { get; private set; }
        #endregion

        #region Contract Info
        /// <summary> رقم العقد </summary>
        public long? ContractNo { get; private set; }
        /// <summary> السيريال للعقد </summary>
        public int? ContractSerial { get; private set; }
        /// <summary> دفعة العقد </summary>
        public int? ContractBatch { get; private set; }
        /// <summary> رقم العقد </summary>
        public ContractReference ContractReference { get; private set; }
        #endregion

        #region Additional References
        /// <summary> رقم مرجعي إضافي </summary>
        public string? RefNo { get; private set; }
        /// <summary> رقم الشيك </summary>
        public long? ChequeNo { get; private set; }
        /// <summary> رقم الإشعار/الملاحظة </summary>
        public string? NoteNo { get; private set; }
        /// <summary> تسلسل المستند </summary>
        public long? DocSequence { get; private set; }
        /// <summary> علم الترحيل الخارجي </summary>
        public int? ExternalPost { get; private set; }
        /// <summary> رقم فرع المستند </summary>
        public int? DocBranchNo { get; private set; }
        /// <summary> ملاحظات </summary>
        public string? Note { get; private set; }
        /// <summary> تسلسل المستند المرجعي </summary>
        public long? DocSequenceRef { get; private set; }
        /// <summary> رقم السطر المرجعي </summary>
        public long? RecordNoRef { get; private set; }
        #endregion

        #region Tax Info
        /// <summary> نوع الحساب الضريبي </summary>
        public int? CalcTypeNoTax { get; private set; }
        /// <summary> نسبة الضريبة </summary>
        public decimal? TaxPercent { get; private set; }
        /// <summary> مبلغ الضريبة </summary>
        public decimal? TaxAmount { get; private set; }
        /// <summary> نوع الحساب الضريبي </summary>
        public TaxInfo TaxInfo { get; private set; }
        #endregion

        #region HR References
        /// <summary> نوع المستند للموارد البشرية </summary>
        public int? HrsDocTypeRef { get; private set; }
        /// <summary> الرقم التسلسلي للمستند للموارد البشرية </summary>
        public int? HrsDocSerRef { get; private set; }
        /// <summary> رقم المستند للموارد البشرية </summary>
        public int? HrsDocNoRef { get; private set; }
        /// <summary> نوع المستند للموارد البشرية </summary>
        public HRReference HRReference { get; private set; }
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
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        public BranchInfo BranchInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual Journal Journal { get; private set; }
        public virtual AccountCurrency AccountCurrency { get; private set; }
        public virtual Project Project { get; private set; }
        public virtual Customer Customer { get; private set; }
        public virtual Vendor Vendor { get; private set; }
        #endregion

        private JournalDetail() { } // For EF Core

        public static JournalDetail Create(
            Guid journalId,
            short jvType,
            long jDocNo,
            long? jSerial,
            string accountCode,
            string? accountDetailCode,
            AccountDetailInfo accountDetailInfo,
            string? currencyCode,
            decimal? exchangeRate,
            decimal debit,
            decimal credit,
            Money localAmount,
            Money foreignAmount,
            string? costCenterCode,
            string? projectCode,
            string? description,
            DocumentReference documentReference,
            BillReference billReference,
            ItemReference itemReference,
            ContractReference contractReference,
            TaxInfo taxInfo,
            HRReference hrReference,
            CompanyInfo companyInfo,
            BranchInfo branchInfo,
            int userId,
            string terminal)
        {
            var detail = new JournalDetail
            {
                Id = Guid.NewGuid(),
                JournalId = journalId,
                JVType = jvType,
                JDocNo = jDocNo,
                JSerial = jSerial,
                AccountCode = accountCode,
                AccountDetailCode = accountDetailCode,
                AccountDetailInfo = accountDetailInfo,
                CurrencyCode = currencyCode,
                ExchangeRate = exchangeRate,
                Debit = debit,
                Credit = credit,
                LocalAmount = localAmount,
                ForeignAmount = foreignAmount,
                CostCenterCode = costCenterCode,
                ProjectCode = projectCode,
                Description = description,
                DocumentReference = documentReference,
                BillReference = billReference,
                ItemReference = itemReference,
                ContractReference = contractReference,
                TaxInfo = taxInfo,
                HRReference = hrReference,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            detail.ValidateState();
            detail.AddDomainEvent(new JournalDetailCreatedEvent(detail));
            return detail;
        }

        public void Update(
            string accountCode,
            string? accountDetailCode,
            AccountDetailInfo accountDetailInfo,
            string? currencyCode,
            decimal? exchangeRate,
            decimal debit,
            decimal credit,
            Money localAmount,
            Money foreignAmount,
            string? costCenterCode,
            string? projectCode,
            string? description,
            DocumentReference documentReference,
            BillReference billReference,
            ItemReference itemReference,
            ContractReference contractReference,
            TaxInfo taxInfo,
            HRReference hrReference)
        {
            AccountCode = accountCode;
            AccountDetailCode = accountDetailCode;
            AccountDetailInfo = accountDetailInfo;
            CurrencyCode = currencyCode;
            ExchangeRate = exchangeRate;
            Debit = debit;
            Credit = credit;
            LocalAmount = localAmount;
            ForeignAmount = foreignAmount;
            CostCenterCode = costCenterCode;
            ProjectCode = projectCode;
            Description = description;
            DocumentReference = documentReference;
            BillReference = billReference;
            ItemReference = itemReference;
            ContractReference = contractReference;
            TaxInfo = taxInfo;
            HRReference = hrReference;

            ValidateState();
            AddDomainEvent(new JournalDetailUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(AccountCode))
                throw new DomainException("Account code is required");

            if (Debit < 0 || Credit < 0)
                throw new DomainException("Debit and credit amounts must be non-negative");

            if (Debit > 0 && Credit > 0)
                throw new DomainException("Entry cannot be both debit and credit");

            if (Debit == 0 && Credit == 0)
                throw new DomainException("Entry must have either debit or credit amount");

            if (CurrencyCode != null && !ExchangeRate.HasValue)
                throw new DomainException("Exchange rate is required when currency is specified");

            if (ExchangeRate.HasValue && ExchangeRate.Value <= 0)
                throw new DomainException("Exchange rate must be positive");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (BranchInfo == null)
                throw new DomainException("Branch info is required");
        }
    }
}