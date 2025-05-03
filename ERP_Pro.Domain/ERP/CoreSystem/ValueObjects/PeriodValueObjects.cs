using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// Represents an exchange rate value object
    /// يمثل كائن قيمة لسعر الصرف
    /// </summary>
    public class ExchangeRate : ValueObject
    {
        /// <summary>
        /// Gets the rate value
        /// قيمة سعر الصرف
        /// </summary>
        public decimal Rate { get; }

        /// <summary>
        /// Gets the effective date
        /// تاريخ السريان
        /// </summary>
        public DateTime EffectiveDate { get; }

        private ExchangeRate() { } // For EF Core

        private ExchangeRate(decimal rate, DateTime effectiveDate)
        {
            if (rate <= 0)
                throw new DomainException("Exchange rate must be greater than zero");

            if (effectiveDate == default)
                throw new DomainException("Effective date is required");

            Rate = rate;
            EffectiveDate = effectiveDate;
        }

        public static ExchangeRate Create(decimal rate, DateTime effectiveDate)
            => new(rate, effectiveDate);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Rate;
            yield return EffectiveDate;
        }
    }

    /// <summary>
    /// Represents company information value object
    /// يمثل كائن قيمة لمعلومات الشركة
    /// </summary>
    public class CompanyInfo : ValueObject
    {
        /// <summary>
        /// Gets the company number
        /// رقم الشركة
        /// </summary>
        public short CompanyNumber { get; }

        /// <summary>
        /// Gets the company name
        /// اسم الشركة
        /// </summary>
        public string CompanyName { get; }

        private CompanyInfo() { } // For EF Core

        private CompanyInfo(short companyNumber, string companyName)
        {
            if (companyNumber <= 0)
                throw new DomainException("Company number must be greater than zero");

            if (string.IsNullOrWhiteSpace(companyName))
                throw new DomainException("Company name is required");

            CompanyNumber = companyNumber;
            CompanyName = companyName;
        }

        public static CompanyInfo Create(short companyNumber, string companyName)
            => new(companyNumber, companyName);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CompanyNumber;
            yield return CompanyName;
        }
    }

    /// <summary>
    /// Represents branch information value object
    /// يمثل كائن قيمة لمعلومات الفرع
    /// </summary>
    public class BranchInfo : ValueObject
    {
        /// <summary>
        /// Gets the branch number
        /// رقم الفرع
        /// </summary>
        public int BranchNumber { get; }

        /// <summary>
        /// Gets the branch name
        /// اسم الفرع
        /// </summary>
        public string BranchName { get; }

        /// <summary>
        /// Gets the branch year
        /// سنة الفرع
        /// </summary>
        public short BranchYear { get; }

        /// <summary>
        /// Gets the branch user number
        /// رقم مستخدم الفرع
        /// </summary>
        public short BranchUserNumber { get; }

        private BranchInfo() { } // For EF Core

        private BranchInfo(
            int branchNumber,
            string branchName,
            short branchYear,
            short branchUserNumber)
        {
            if (branchNumber <= 0)
                throw new DomainException("Branch number must be greater than zero");

            if (string.IsNullOrWhiteSpace(branchName))
                throw new DomainException("Branch name is required");

            if (branchYear <= 0)
                throw new DomainException("Branch year must be greater than zero");

            if (branchUserNumber <= 0)
                throw new DomainException("Branch user number must be greater than zero");

            BranchNumber = branchNumber;
            BranchName = branchName;
            BranchYear = branchYear;
            BranchUserNumber = branchUserNumber;
        }

        public static BranchInfo Create(
            int branchNumber,
            string branchName,
            short branchYear,
            short branchUserNumber)
            => new(branchNumber, branchName, branchYear, branchUserNumber);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return BranchNumber;
            yield return BranchName;
            yield return BranchYear;
            yield return BranchUserNumber;
        }
    }

    /// <summary>
    /// Represents audit information value object
    /// يمثل كائن قيمة لمعلومات التدقيق
    /// </summary>
    public class AuditInfo : ValueObject
    {
        /// <summary>
        /// Gets the user who added the record
        /// المستخدم الذي أضاف السجل
        /// </summary>
        public int AddedByUserId { get; }

        /// <summary>
        /// Gets the date when the record was added
        /// تاريخ إضافة السجل
        /// </summary>
        public DateTime AddedDate { get; }

        /// <summary>
        /// Gets the terminal name where the record was added
        /// اسم الطرفية التي تمت منها إضافة السجل
        /// </summary>
        public string AddedTerminalName { get; }

        /// <summary>
        /// Gets the user who last updated the record
        /// المستخدم الذي قام بآخر تحديث للسجل
        /// </summary>
        public int? UpdatedByUserId { get; }

        /// <summary>
        /// Gets the date when the record was last updated
        /// تاريخ آخر تحديث للسجل
        /// </summary>
        public DateTime? UpdatedDate { get; }

        /// <summary>
        /// Gets the terminal name where the record was last updated
        /// اسم الطرفية التي تم منها آخر تحديث للسجل
        /// </summary>
        public string? UpdatedTerminalName { get; }

        /// <summary>
        /// Gets the update counter
        /// عداد التحديث
        /// </summary>
        public long UpdateCounter { get; }

        private AuditInfo() { } // For EF Core

        private AuditInfo(
            int addedByUserId,
            DateTime addedDate,
            string addedTerminalName,
            int? updatedByUserId,
            DateTime? updatedDate,
            string? updatedTerminalName,
            long updateCounter)
        {
            if (addedByUserId <= 0)
                throw new DomainException("Added by user ID must be greater than zero");

            if (addedDate == default)
                throw new DomainException("Added date is required");

            if (string.IsNullOrWhiteSpace(addedTerminalName))
                throw new DomainException("Added terminal name is required");

            if (updatedByUserId.HasValue && updatedByUserId.Value <= 0)
                throw new DomainException("Updated by user ID must be greater than zero");

            if (updatedByUserId.HasValue && !updatedDate.HasValue)
                throw new DomainException("Updated date is required when updated by user ID is provided");

            if (updatedByUserId.HasValue && string.IsNullOrWhiteSpace(updatedTerminalName))
                throw new DomainException("Updated terminal name is required when updated by user ID is provided");

            if (updateCounter < 0)
                throw new DomainException("Update counter cannot be negative");

            AddedByUserId = addedByUserId;
            AddedDate = addedDate;
            AddedTerminalName = addedTerminalName;
            UpdatedByUserId = updatedByUserId;
            UpdatedDate = updatedDate;
            UpdatedTerminalName = updatedTerminalName;
            UpdateCounter = updateCounter;
        }

        public static AuditInfo Create(int userId, string terminal)
            => new(userId, DateTime.UtcNow, terminal, null, null, null, 0);

        public static AuditInfo Update(AuditInfo current, int userId, string terminal)
            => new(
                current.AddedByUserId,
                current.AddedDate,
                current.AddedTerminalName,
                userId,
                DateTime.UtcNow,
                terminal,
                current.UpdateCounter + 1);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AddedByUserId;
            yield return AddedDate;
            yield return AddedTerminalName;
            yield return UpdatedByUserId ?? 0;
            yield return UpdatedDate ?? DateTime.MinValue;
            yield return UpdatedTerminalName ?? string.Empty;
            yield return UpdateCounter;
        }
    }
} 