using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects
{
    public record CompanyInfo
    {
        public short CompanyNumber { get; }
        public string? CompanyName { get; }
        public string? CompanyDescription { get; }

        private CompanyInfo(short companyNumber, string? companyName, string? companyDescription)
        {
            if (companyNumber <= 0)
                throw new DomainException("Company number must be positive");

            CompanyNumber = companyNumber;
            CompanyName = companyName;
            CompanyDescription = companyDescription;
        }

        public static CompanyInfo Create(short companyNumber, string? companyName = null, string? companyDescription = null) =>
            new(companyNumber, companyName, companyDescription);
    }

    public record BranchInfo
    {
        public int BranchNumber { get; }
        public short? BranchYear { get; }
        public short? BranchUser { get; }
        public string? BranchName { get; }
        public string? BranchDescription { get; }

        private BranchInfo(
            int branchNumber,
            short? branchYear,
            short? branchUser,
            string? branchName,
            string? branchDescription)
        {
            if (branchNumber <= 0)
                throw new DomainException("Branch number must be positive");

            BranchNumber = branchNumber;
            BranchYear = branchYear;
            BranchUser = branchUser;
            BranchName = branchName;
            BranchDescription = branchDescription;
        }

        public static BranchInfo Create(
            int branchNumber,
            short? branchYear = null,
            short? branchUser = null,
            string? branchName = null,
            string? branchDescription = null) =>
            new(branchNumber, branchYear, branchUser, branchName, branchDescription);
    }

    public record DocumentInfo
    {
        public long DocumentNumber { get; }
        public long DocumentSerial { get; }
        public DateTime DocumentDate { get; }
        public string? ReferenceNumber { get; }
        public string? Description { get; }

        private DocumentInfo(
            long documentNumber,
            long documentSerial,
            DateTime documentDate,
            string? referenceNumber,
            string? description)
        {
            if (documentNumber <= 0)
                throw new DomainException("Document number must be positive");
            if (documentSerial <= 0)
                throw new DomainException("Document serial must be positive");
            if (documentDate == default)
                throw new DomainException("Document date is required");

            DocumentNumber = documentNumber;
            DocumentSerial = documentSerial;
            DocumentDate = documentDate;
            ReferenceNumber = referenceNumber;
            Description = description;
        }

        public static DocumentInfo Create(
            long documentNumber,
            long documentSerial,
            DateTime documentDate,
            string? referenceNumber = null,
            string? description = null) =>
            new(documentNumber, documentSerial, documentDate, referenceNumber, description);
    }

    public record AuditInfo
    {
        public int? AddedByUserId { get; }
        public DateTime? AddedDate { get; }
        public string? AddedTerminal { get; }
        public int? UpdatedByUserId { get; }
        public DateTime? UpdatedDate { get; }
        public string? UpdatedTerminal { get; }
        public long? UpdateCount { get; }

        private AuditInfo(
            int? addedByUserId,
            DateTime? addedDate,
            string? addedTerminal,
            int? updatedByUserId,
            DateTime? updatedDate,
            string? updatedTerminal,
            long? updateCount)
        {
            AddedByUserId = addedByUserId;
            AddedDate = addedDate;
            AddedTerminal = addedTerminal;
            UpdatedByUserId = updatedByUserId;
            UpdatedDate = updatedDate;
            UpdatedTerminal = updatedTerminal;
            UpdateCount = updateCount;
        }

        public static AuditInfo Create(
            int? addedByUserId = null,
            DateTime? addedDate = null,
            string? addedTerminal = null,
            int? updatedByUserId = null,
            DateTime? updatedDate = null,
            string? updatedTerminal = null,
            long? updateCount = null) =>
            new(addedByUserId, addedDate, addedTerminal, updatedByUserId, updatedDate, updatedTerminal, updateCount);

        public static AuditInfo CreateNew(int userId, string terminal) =>
            new(userId, DateTime.UtcNow, terminal, null, null, null, 0);

        public AuditInfo WithUpdate(int userId, string terminal) =>
            this with
            {
                UpdatedByUserId = userId,
                UpdatedDate = DateTime.UtcNow,
                UpdatedTerminal = terminal,
                UpdateCount = (UpdateCount ?? 0) + 1
            };
    }
} 