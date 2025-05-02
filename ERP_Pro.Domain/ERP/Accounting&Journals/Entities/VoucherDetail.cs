using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class VoucherDetail : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
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
        public AccountInfo Account { get; private set; }
        #endregion

        #region Amount Info
        public VoucherAmount Amount { get; private set; }
        #endregion

        #region Reference Info
        public ReferenceInfo Reference { get; private set; }
        #endregion

        #region Cheque Info
        public ChequeInfo Cheque { get; private set; }
    public string? NoteNo { get; private set; }
        #endregion

        #region Bank Info
        public BankInfo Bank { get; private set; }
        #endregion

        #region Contract Info
        public ContractInfo Contract { get; private set; }
        #endregion

        #region Tax Info
        public TaxInfo Tax { get; private set; }
        #endregion

        #region Card Info
        public CardInfo Card { get; private set; }
        #endregion

        #region Document References
    /// <summary> رقم الاعتماد المستندي </summary>
    public string? LCNo { get; private set; }
    /// <summary> رقم الاعتماد المستندي </summary>
    public long? CINo { get; private set; }
    /// <summary> الرقم التسلسلي للاعتماد المستندي </summary>
    public long? CISerial { get; private set; }
    /// <summary> رقم سند صرف الموارد البشرية </summary>
    public long? HRSPayNo { get; private set; }
    /// <summary> رقم الكمبيالة </summary>
    public long? KNo { get; private set; }
    /// <summary> الرقم التسلسلي للكمبيالة </summary>
    public long? KSerial { get; private set; }
    /// <summary> رقم الفاتورة </summary>
    public long? BillNo { get; private set; }
    /// <summary> الرقم التسلسلي للفاتورة </summary>
    public long? BillSerial { get; private set; }
    /// <summary> رقم العنصر </summary>
    public long? INo { get; private set; }
    /// <summary> رقم أمر العمل </summary>
    public long? WONo { get; private set; }
    /// <summary> الرقم التسلسلي لأمر العمل </summary>
    public long? WOSerial { get; private set; }
        #endregion

        #region Additional References
    /// <summary> رقم مرجعي إضافي </summary>
    public string? RefNo { get; private set; }
    /// <summary> رقم السطر في القيد </summary>
    public long? RecordNo { get; private set; }
    /// <summary> رقم السند المرتبط </summary>
    public long? ConnVoucherNo { get; private set; }
    /// <summary> الرقم التسلسلي للسند المرتبط </summary>
    public long? ConnVoucherSerial { get; private set; }
    /// <summary> مبلغ السند المرتبط </summary>
    public int? ConnVoucherAmount { get; private set; }
    /// <summary> علم الترحيل الخارجي </summary>
    public int? ExternalPost { get; private set; }
    /// <summary> تاريخ التسوية </summary>
    public DateTime? BlmntDate { get; private set; }
    /// <summary> تسلسل المستند المرجعي </summary>
    public long? DocSequenceRef { get; private set; }
    /// <summary> تسلسل المستند </summary>
    public long? DocSequence { get; private set; }
    /// <summary> رقم أمين الصندوق </summary>
    public int? CashierNo { get; private set; }
    /// <summary> ملاحظات </summary>
    public string? Note { get; private set; }
        #endregion

        #region Additional Fields
    /// <summary> حقل إضافي </summary>
    public string? Fld1 { get; private set; }
    /// <summary> حقل إضافي </summary>
    public string? Fld2 { get; private set; }
    /// <summary> حقل إضافي </summary>
    public string? Fld3 { get; private set; }
    /// <summary> حقل إضافي </summary>
    public string? Fld4 { get; private set; }
    /// <summary> حقل إضافي </summary>
    public string? Fld5 { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        public BranchInfo BranchInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual AccountCurrency AccountCurrency { get; private set; }
        public virtual Project Project { get; private set; }
        public virtual Customer Customer { get; private set; }
        public virtual Voucher Voucher { get; private set; }
        public virtual Account Account { get; private set; }
        public virtual CostCenter CostCenter { get; private set; }
        #endregion

        private VoucherDetail() { } // For EF Core

        public static VoucherDetail Create(
            string accountCode,
            string? accountDetailCode,
            string? currencyCode,
            decimal? exchangeRate,
            decimal debit,
            decimal credit,
            string? costCenterCode,
            string? projectCode,
            string? description)
        {
            var detail = new VoucherDetail
            {
                Id = Guid.NewGuid(),
                AccountCode = accountCode,
                AccountDetailCode = accountDetailCode,
                CurrencyCode = currencyCode,
                ExchangeRate = exchangeRate,
                Debit = debit,
                Credit = credit,
                CostCenterCode = costCenterCode,
                ProjectCode = projectCode,
                Description = description
            };

            detail.ValidateState();
            return detail;
        }

        public void Update(
            string accountCode,
            string? accountDetailCode,
            string? currencyCode,
            decimal? exchangeRate,
            decimal debit,
            decimal credit,
            string? costCenterCode,
            string? projectCode,
            string? description)
        {
            AccountCode = accountCode;
            AccountDetailCode = accountDetailCode;
            CurrencyCode = currencyCode;
            ExchangeRate = exchangeRate;
            Debit = debit;
            Credit = credit;
            CostCenterCode = costCenterCode;
            ProjectCode = projectCode;
            Description = description;

            ValidateState();
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(AccountCode))
                throw new DomainException("Account code is required");

            if (Debit < 0)
                throw new DomainException("Debit amount cannot be negative");

            if (Credit < 0)
                throw new DomainException("Credit amount cannot be negative");

            if (Debit > 0 && Credit > 0)
                throw new DomainException("Cannot have both debit and credit amounts");

            if (Debit == 0 && Credit == 0)
                throw new DomainException("Must have either debit or credit amount");

            if (CurrencyCode != null)
            {
                if (ExchangeRate == null)
                    throw new DomainException("Exchange rate is required when currency is specified");

                if (ExchangeRate <= 0)
                    throw new DomainException("Exchange rate must be greater than zero");
            }
        }
    }
}