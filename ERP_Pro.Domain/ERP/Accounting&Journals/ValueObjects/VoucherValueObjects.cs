using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public record VoucherType
    {
        public bool? Value { get; }
        public bool PayType { get; }

        private VoucherType(bool? value, bool payType)
        {
            Value = value;
            PayType = payType;
        }

        public static VoucherType Create(bool? value, bool payType) => new(value, payType);
    }

    public record VoucherNumber
    {
        public long Value { get; }
        public long? Serial { get; }

        private VoucherNumber(long value, long? serial)
        {
            if (value <= 0)
                throw new DomainException("Voucher number must be greater than zero");
            Value = value;
            Serial = serial;
        }

        public static VoucherNumber Create(long value, long? serial = null) => new(value, serial);
    }

    public record AccountInfo
    {
        public string Code { get; }
        public string? DetailCode { get; }
        public string? DetailSub { get; }
        public string? DetailSubEnd { get; }
        public string? DetailSubDrComm { get; }
        public short? DetailType { get; }
        public string? Description { get; }

        private AccountInfo(
            string code,
            string? detailCode,
            string? detailSub,
            string? detailSubEnd,
            string? detailSubDrComm,
            short? detailType,
            string? description)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new DomainException("Account code is required");

            Code = code;
            DetailCode = detailCode;
            DetailSub = detailSub;
            DetailSubEnd = detailSubEnd;
            DetailSubDrComm = detailSubDrComm;
            DetailType = detailType;
            Description = description;
        }

        public static AccountInfo Create(
            string code,
            string? detailCode = null,
            string? detailSub = null,
            string? detailSubEnd = null,
            string? detailSubDrComm = null,
            short? detailType = null,
            string? description = null) =>
            new(code, detailCode, detailSub, detailSubEnd, detailSubDrComm, detailType, description);
    }

    public record VoucherAmount
    {
        public int? Local { get; }
        public int? Foreign { get; }
        public int? ExchangeRate { get; }
        public string? CurrencyCode { get; }

        private VoucherAmount(int? local, int? foreign, int? exchangeRate, string? currencyCode)
        {
            Local = local;
            Foreign = foreign;
            ExchangeRate = exchangeRate;
            CurrencyCode = currencyCode;
        }

        public static VoucherAmount Create(
            int? local = null,
            int? foreign = null,
            int? exchangeRate = null,
            string? currencyCode = null) =>
            new(local, foreign, exchangeRate, currencyCode);
    }

    public record ReferenceInfo
    {
        public string? CostCenterCode { get; }
        public string? ProjectNo { get; }
        public string? ActivityNo { get; }
        public string? CustomerCode { get; }
        public string? VendorCode { get; }
        public string? ReportCode { get; }
        public long? CashBankNo { get; }

        private ReferenceInfo(
            string? costCenterCode,
            string? projectNo,
            string? activityNo,
            string? customerCode,
            string? vendorCode,
            string? reportCode,
            long? cashBankNo)
        {
            CostCenterCode = costCenterCode;
            ProjectNo = projectNo;
            ActivityNo = activityNo;
            CustomerCode = customerCode;
            VendorCode = vendorCode;
            ReportCode = reportCode;
            CashBankNo = cashBankNo;
        }

        public static ReferenceInfo Create(
            string? costCenterCode = null,
            string? projectNo = null,
            string? activityNo = null,
            string? customerCode = null,
            string? vendorCode = null,
            string? reportCode = null,
            long? cashBankNo = null) =>
            new(costCenterCode, projectNo, activityNo, customerCode, vendorCode, reportCode, cashBankNo);
    }

    public record ChequeInfo
    {
        public long? Number { get; }
        public DateTime? ValueDate { get; }
        public bool? IsPosted { get; }
        public bool? IsValued { get; }
        public bool? IsEndorsed { get; }
        public DateTime? EndorsementDate { get; }
        public short? EndorsementPost { get; }

        private ChequeInfo(
            long? number,
            DateTime? valueDate,
            bool? isPosted,
            bool? isValued,
            bool? isEndorsed,
            DateTime? endorsementDate,
            short? endorsementPost)
        {
            Number = number;
            ValueDate = valueDate;
            IsPosted = isPosted;
            IsValued = isValued;
            IsEndorsed = isEndorsed;
            EndorsementDate = endorsementDate;
            EndorsementPost = endorsementPost;
        }

        public static ChequeInfo Create(
            long? number = null,
            DateTime? valueDate = null,
            bool? isPosted = null,
            bool? isValued = null,
            bool? isEndorsed = null,
            DateTime? endorsementDate = null,
            short? endorsementPost = null) =>
            new(number, valueDate, isPosted, isValued, isEndorsed, endorsementDate, endorsementPost);
    }

    public record BankInfo
    {
        public long? Number { get; }
        public string? Name { get; }
        public int? BranchNo { get; }

        private BankInfo(long? number, string? name, int? branchNo)
        {
            Number = number;
            Name = name;
            BranchNo = branchNo;
        }

        public static BankInfo Create(
            long? number = null,
            string? name = null,
            int? branchNo = null) =>
            new(number, name, branchNo);
    }

    public record ContractInfo
    {
        public long? Number { get; }
        public int? Serial { get; }
        public int? Batch { get; }
        public DateTime? FromDate { get; }
        public DateTime? ToDate { get; }
        public string? FromDateAH { get; }
        public string? ToDateAH { get; }

        private ContractInfo(
            long? number,
            int? serial,
            int? batch,
            DateTime? fromDate,
            DateTime? toDate,
            string? fromDateAH,
            string? toDateAH)
        {
            Number = number;
            Serial = serial;
            Batch = batch;
            FromDate = fromDate;
            ToDate = toDate;
            FromDateAH = fromDateAH;
            ToDateAH = toDateAH;
        }

        public static ContractInfo Create(
            long? number = null,
            int? serial = null,
            int? batch = null,
            DateTime? fromDate = null,
            DateTime? toDate = null,
            string? fromDateAH = null,
            string? toDateAH = null) =>
            new(number, serial, batch, fromDate, toDate, fromDateAH, toDateAH);
    }

    public record TaxInfo
    {
        public int? CalculationType { get; }
        public int? Percentage { get; }
        public int? Amount { get; }

        private TaxInfo(int? calculationType, int? percentage, int? amount)
        {
            CalculationType = calculationType;
            Percentage = percentage;
            Amount = amount;
        }

        public static TaxInfo Create(
            int? calculationType = null,
            int? percentage = null,
            int? amount = null) =>
            new(calculationType, percentage, amount);
    }

    public record CardInfo
    {
        public int? CardNo { get; }
        public string? AccountCodeRecLetter { get; }
        public string? CommAccount { get; }
        public bool? CommCalcType { get; }
        public int? CommPercent { get; }
        public int? VatCommPercent { get; }
        public int? DuePeriod { get; }
        public long? ProcessNo { get; }
        public int? CommAmountLocal { get; }
        public int? VatCommAmountLocal { get; }
        public int? WithdrawAmountLocal { get; }
        public short? CardType { get; }

        private CardInfo(
            int? cardNo,
            string? accountCodeRecLetter,
            string? commAccount,
            bool? commCalcType,
            int? commPercent,
            int? vatCommPercent,
            int? duePeriod,
            long? processNo,
            int? commAmountLocal,
            int? vatCommAmountLocal,
            int? withdrawAmountLocal,
            short? cardType)
        {
            CardNo = cardNo;
            AccountCodeRecLetter = accountCodeRecLetter;
            CommAccount = commAccount;
            CommCalcType = commCalcType;
            CommPercent = commPercent;
            VatCommPercent = vatCommPercent;
            DuePeriod = duePeriod;
            ProcessNo = processNo;
            CommAmountLocal = commAmountLocal;
            VatCommAmountLocal = vatCommAmountLocal;
            WithdrawAmountLocal = withdrawAmountLocal;
            CardType = cardType;
        }

        public static CardInfo Create(
            int? cardNo = null,
            string? accountCodeRecLetter = null,
            string? commAccount = null,
            bool? commCalcType = null,
            int? commPercent = null,
            int? vatCommPercent = null,
            int? duePeriod = null,
            long? processNo = null,
            int? commAmountLocal = null,
            int? vatCommAmountLocal = null,
            int? withdrawAmountLocal = null,
            short? cardType = null) =>
            new(cardNo, accountCodeRecLetter, commAccount, commCalcType, commPercent,
                vatCommPercent, duePeriod, processNo, commAmountLocal, vatCommAmountLocal,
                withdrawAmountLocal, cardType);
    }
} 