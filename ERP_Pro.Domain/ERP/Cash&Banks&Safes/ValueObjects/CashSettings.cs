using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class CashSettings : ValueObject
    {
        public bool UseCashIncome { get; private set; }
        public bool IsPOSSystem { get; private set; }
        public bool IsMediator { get; private set; }
        public int? ReceiptSerialType { get; private set; }
        public int? DefaultPaymentType { get; private set; }
        public int? DefaultReceivedType { get; private set; }
        public decimal? MinimumLimit { get; private set; }
        public decimal? MaximumLimit { get; private set; }
        public decimal? MinimumTransactionLimit { get; private set; }
        public decimal? MaximumTransactionLimit { get; private set; }
        public bool PassLimit { get; private set; }
        public bool IsInactive { get; private set; }
        public DateTime? InactiveDate { get; private set; }
        public string? InactiveReason { get; private set; }

        private CashSettings() { }

        public static CashSettings Create(
            bool useCashIncome = false,
            bool isPOSSystem = false,
            bool isMediator = false,
            int? receiptSerialType = null,
            int? defaultPaymentType = null,
            int? defaultReceivedType = null,
            decimal? minimumLimit = null,
            decimal? maximumLimit = null,
            decimal? minimumTransactionLimit = null,
            decimal? maximumTransactionLimit = null,
            bool passLimit = false,
            bool isInactive = false,
            DateTime? inactiveDate = null,
            string? inactiveReason = null)
        {
            var settings = new CashSettings
            {
                UseCashIncome = useCashIncome,
                IsPOSSystem = isPOSSystem,
                IsMediator = isMediator,
                ReceiptSerialType = receiptSerialType,
                DefaultPaymentType = defaultPaymentType,
                DefaultReceivedType = defaultReceivedType,
                MinimumLimit = minimumLimit,
                MaximumLimit = maximumLimit,
                MinimumTransactionLimit = minimumTransactionLimit,
                MaximumTransactionLimit = maximumTransactionLimit,
                PassLimit = passLimit,
                IsInactive = isInactive,
                InactiveDate = inactiveDate,
                InactiveReason = inactiveReason
            };

            settings.ValidateState();
            return settings;
        }

        private void ValidateState()
        {
            if (IsInactive && string.IsNullOrWhiteSpace(InactiveReason))
                throw new DomainException("يجب تحديد سبب التعطيل");

            if (IsInactive && !InactiveDate.HasValue)
                throw new DomainException("يجب تحديد تاريخ التعطيل");

            if (MinimumLimit.HasValue && MaximumLimit.HasValue && MinimumLimit > MaximumLimit)
                throw new DomainException("الحد الأدنى يجب أن يكون أقل من الحد الأعلى");

            if (MinimumTransactionLimit.HasValue && MaximumTransactionLimit.HasValue && 
                MinimumTransactionLimit > MaximumTransactionLimit)
                throw new DomainException("الحد الأدنى للحركة يجب أن يكون أقل من الحد الأعلى");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return UseCashIncome;
            yield return IsPOSSystem;
            yield return IsMediator;
            yield return ReceiptSerialType ?? 0;
            yield return DefaultPaymentType ?? 0;
            yield return DefaultReceivedType ?? 0;
            yield return MinimumLimit ?? 0;
            yield return MaximumLimit ?? 0;
            yield return MinimumTransactionLimit ?? 0;
            yield return MaximumTransactionLimit ?? 0;
            yield return PassLimit;
            yield return IsInactive;
            yield return InactiveDate ?? DateTime.MinValue;
            yield return InactiveReason ?? string.Empty;
        }
    }
} 