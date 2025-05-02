using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class AccountDetailInfo : ValueObject
    {
        public string? AccountDtlCode { get; private set; }
        public string? AccountDtlSub { get; private set; }
        public string? AccountDtlSubEnd { get; private set; }
        public string? AccountDtlSubDrComm { get; private set; }
        public short? AccountDtlType { get; private set; }

        private AccountDetailInfo() { }

        public static AccountDetailInfo Create(
            string? accountDtlCode = null,
            string? accountDtlSub = null,
            string? accountDtlSubEnd = null,
            string? accountDtlSubDrComm = null,
            short? accountDtlType = null)
        {
            return new AccountDetailInfo
            {
                AccountDtlCode = accountDtlCode,
                AccountDtlSub = accountDtlSub,
                AccountDtlSubEnd = accountDtlSubEnd,
                AccountDtlSubDrComm = accountDtlSubDrComm,
                AccountDtlType = accountDtlType
            };
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AccountDtlCode ?? string.Empty;
            yield return AccountDtlSub ?? string.Empty;
            yield return AccountDtlSubEnd ?? string.Empty;
            yield return AccountDtlSubDrComm ?? string.Empty;
            yield return AccountDtlType ?? 0;
        }
    }
} 