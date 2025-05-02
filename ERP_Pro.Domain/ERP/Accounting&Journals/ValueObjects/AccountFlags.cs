using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class AccountFlags : ValueObject
    {
        public bool IsClosed { get; private set; }
        public bool IsDebit { get; private set; }
        public bool IsFavorite { get; private set; }
        public bool IsFlowType { get; private set; }
        public bool IsConnectedToPeriod { get; private set; }
        public DateTime? LastConfirmationDate { get; private set; }

        private AccountFlags() { }

        public static AccountFlags Create(
            bool isClosed = false,
            bool isDebit = false,
            bool isFavorite = false,
            bool isFlowType = false,
            bool isConnectedToPeriod = false,
            DateTime? lastConfirmationDate = null)
        {
            var flags = new AccountFlags
            {
                IsClosed = isClosed,
                IsDebit = isDebit,
                IsFavorite = isFavorite,
                IsFlowType = isFlowType,
                IsConnectedToPeriod = isConnectedToPeriod,
                LastConfirmationDate = lastConfirmationDate
            };

            flags.ValidateState();
            return flags;
        }

        public AccountFlags Close()
        {
            return Create(
                true,
                IsDebit,
                IsFavorite,
                IsFlowType,
                IsConnectedToPeriod,
                LastConfirmationDate);
        }

        public AccountFlags Reopen()
        {
            return Create(
                false,
                IsDebit,
                IsFavorite,
                IsFlowType,
                IsConnectedToPeriod,
                LastConfirmationDate);
        }

        public AccountFlags ToggleFavorite()
        {
            return Create(
                IsClosed,
                IsDebit,
                !IsFavorite,
                IsFlowType,
                IsConnectedToPeriod,
                LastConfirmationDate);
        }

        public AccountFlags Confirm()
        {
            return Create(
                IsClosed,
                IsDebit,
                IsFavorite,
                IsFlowType,
                IsConnectedToPeriod,
                DateTime.UtcNow);
        }

        private void ValidateState()
        {
            if (IsClosed && !LastConfirmationDate.HasValue)
                throw new DomainException("Closed account must have a last confirmation date");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return IsClosed;
            yield return IsDebit;
            yield return IsFavorite;
            yield return IsFlowType;
            yield return IsConnectedToPeriod;
            yield return LastConfirmationDate ?? DateTime.MinValue;
        }
    }
} 