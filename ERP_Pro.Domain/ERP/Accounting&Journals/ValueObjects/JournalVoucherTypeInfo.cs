using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public record JournalVoucherTypeInfo
    {
        /// <summary> رقم/نوع السند المحاسبي الرئيسي </summary>
        public int VoucherType { get; }
        /// <summary> رقم فرعي لنوع السند </summary>
        public short VoucherTypeNo { get; }
        /// <summary> كود الحساب الافتراضي لهذا السند </summary>
        public string? DefaultAccountCode { get; }
        /// <summary> معلومات تفاصيل الحساب </summary>
        public AccountDetailInfo? AccountDetail { get; }

        private JournalVoucherTypeInfo(
            int voucherType,
            short voucherTypeNo,
            string? defaultAccountCode = null,
            AccountDetailInfo? accountDetail = null)
        {
            if (voucherType <= 0)
                throw new DomainException("Voucher type must be greater than zero");

            if (voucherTypeNo <= 0)
                throw new DomainException("Voucher type number must be greater than zero");

            VoucherType = voucherType;
            VoucherTypeNo = voucherTypeNo;
            DefaultAccountCode = defaultAccountCode;
            AccountDetail = accountDetail;
        }

        public static JournalVoucherTypeInfo Create(
            int voucherType,
            short voucherTypeNo,
            string? defaultAccountCode = null,
            AccountDetailInfo? accountDetail = null) =>
            new(voucherType, voucherTypeNo, defaultAccountCode, accountDetail);
    }

    public record AccountDetailInfo
    {
        /// <summary> كود التفاصيل للحساب </summary>
        public string Code { get; }
        /// <summary> نوع التفاصيل للحساب </summary>
        public short Type { get; }

        private AccountDetailInfo(string code, short type)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new DomainException("Account detail code is required");

            if (type <= 0)
                throw new DomainException("Account detail type must be greater than zero");

            Code = code;
            Type = type;
        }

        public static AccountDetailInfo Create(string code, short type) =>
            new(code, type);
    }
} 