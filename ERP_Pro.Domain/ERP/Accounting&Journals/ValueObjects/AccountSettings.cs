using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class AccountSettings : ValueObject
    {
        public bool IsGroup { get; private set; }
        public bool IsMain { get; private set; }
        public bool IsActive { get; private set; }
        public bool AcceptsEntries { get; private set; }
        public bool AcceptsForeignCurrency { get; private set; }
        public bool RequiresCostCenter { get; private set; }
        public bool RequiresProject { get; private set; }
        public bool UsesTDS { get; private set; }
        public bool IsAdvanceExpenseRevenue { get; private set; }
        public string? InactiveReason { get; private set; }
        public DateTime? InactiveDate { get; private set; }

        private AccountSettings() { }

        public static AccountSettings Create(
            bool isGroup = false,
            bool isMain = false,
            bool isActive = true,
            bool acceptsEntries = true,
            bool acceptsForeignCurrency = false,
            bool requiresCostCenter = false,
            bool requiresProject = false,
            bool usesTDS = false,
            bool isAdvanceExpenseRevenue = false,
            string? inactiveReason = null,
            DateTime? inactiveDate = null)
        {
            var settings = new AccountSettings
            {
                IsGroup = isGroup,
                IsMain = isMain,
                IsActive = isActive,
                AcceptsEntries = acceptsEntries,
                AcceptsForeignCurrency = acceptsForeignCurrency,
                RequiresCostCenter = requiresCostCenter,
                RequiresProject = requiresProject,
                UsesTDS = usesTDS,
                IsAdvanceExpenseRevenue = isAdvanceExpenseRevenue,
                InactiveReason = inactiveReason,
                InactiveDate = inactiveDate
            };

            settings.ValidateState();
            return settings;
        }

        public AccountSettings Activate()
        {
            return Create(
                IsGroup,
                IsMain,
                true,
                AcceptsEntries,
                AcceptsForeignCurrency,
                RequiresCostCenter,
                RequiresProject,
                UsesTDS,
                IsAdvanceExpenseRevenue);
        }

        public AccountSettings Deactivate(string reason)
        {
            if (string.IsNullOrWhiteSpace(reason))
                throw new DomainException("Deactivation reason is required");

            return Create(
                IsGroup,
                IsMain,
                false,
                AcceptsEntries,
                AcceptsForeignCurrency,
                RequiresCostCenter,
                RequiresProject,
                UsesTDS,
                IsAdvanceExpenseRevenue,
                reason,
                DateTime.UtcNow);
        }

        private void ValidateState()
        {
            if (!IsActive && string.IsNullOrWhiteSpace(InactiveReason))
                throw new DomainException("Inactive account must have a reason");

            if (!IsActive && !InactiveDate.HasValue)
                throw new DomainException("Inactive account must have a deactivation date");

            if (IsGroup && AcceptsEntries)
                throw new DomainException("Group accounts cannot accept entries");

            if (IsMain && !AcceptsEntries)
                throw new DomainException("Main accounts must accept entries");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return IsGroup;
            yield return IsMain;
            yield return IsActive;
            yield return AcceptsEntries;
            yield return AcceptsForeignCurrency;
            yield return RequiresCostCenter;
            yield return RequiresProject;
            yield return UsesTDS;
            yield return IsAdvanceExpenseRevenue;
            yield return InactiveReason ?? string.Empty;
            yield return InactiveDate ?? DateTime.MinValue;
        }
    }
} 