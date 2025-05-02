using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting.Entities;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class AccountReference : ValueObject
    {
        public string AccountCode { get; private set; }
        public string? AccountCodeDetail { get; private set; }
        public string? AccountCodeDetailSub { get; private set; }
        public int? AccountDetailType { get; private set; }
        public string? CostCenterCode { get; private set; }
        public string? ProjectCode { get; private set; }
        public string? ActivityCode { get; private set; }
        
        // Navigation properties - will be populated by EF Core
        public Account? Account { get; private set; }
        public CostCenter? CostCenter { get; private set; }
        public Project? Project { get; private set; }
        public Activity? Activity { get; private set; }

        private AccountReference() { }

        public static AccountReference Create(
            string accountCode,
            string? accountCodeDetail = null,
            string? accountCodeDetailSub = null,
            int? accountDetailType = null,
            string? costCenterCode = null,
            string? projectCode = null,
            string? activityCode = null)
        {
            var reference = new AccountReference
            {
                AccountCode = accountCode,
                AccountCodeDetail = accountCodeDetail,
                AccountCodeDetailSub = accountCodeDetailSub,
                AccountDetailType = accountDetailType,
                CostCenterCode = costCenterCode,
                ProjectCode = projectCode,
                ActivityCode = activityCode
            };

            reference.ValidateState();
            return reference;
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(AccountCode))
                throw new DomainException("رمز الحساب مطلوب");

            // التحقق من صحة نوع تفاصيل الحساب إذا تم تحديده
            if (AccountDetailType.HasValue && (AccountDetailType < 1 || AccountDetailType > 99))
                throw new DomainException("نوع تفاصيل الحساب غير صحيح");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AccountCode;
            yield return AccountCodeDetail ?? string.Empty;
            yield return AccountCodeDetailSub ?? string.Empty;
            yield return AccountDetailType ?? 0;
            yield return CostCenterCode ?? string.Empty;
            yield return ProjectCode ?? string.Empty;
            yield return ActivityCode ?? string.Empty;
        }
    }
} 