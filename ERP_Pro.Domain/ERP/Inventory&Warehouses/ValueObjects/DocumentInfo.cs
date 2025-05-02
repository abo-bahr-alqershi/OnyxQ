using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public class DocumentInfo : ValueObject
    {
        public long DocumentNumber { get; private set; }
        public long? DocumentSerial { get; private set; }
        public DateTime DocumentDate { get; private set; }
        public string? ReferenceNumber { get; private set; }
        public string? Description { get; private set; }
        public bool? Processed { get; private set; }
        public bool? Hung { get; private set; }
        public bool? Posted { get; private set; }
        public int? PostUserId { get; private set; }
        public DateTime? PostDate { get; private set; }
        public int? UnpostUserId { get; private set; }
        public DateTime? UnpostDate { get; private set; }
        public bool? AuditReference { get; private set; }
        public string? AuditReferenceDescription { get; private set; }
        public int? AuditReferenceUserId { get; private set; }
        public DateTime? AuditReferenceDate { get; private set; }
        public int? DocumentSequenceMain { get; private set; }

        private DocumentInfo() { } // For EF Core

        public DocumentInfo(
            long documentNumber,
            DateTime documentDate,
            long? documentSerial = null,
            string? referenceNumber = null,
            string? description = null,
            bool? processed = null,
            bool? hung = null,
            bool? posted = null,
            int? documentSequenceMain = null)
        {
            DocumentNumber = documentNumber;
            DocumentDate = documentDate;
            DocumentSerial = documentSerial;
            ReferenceNumber = referenceNumber;
            Description = description;
            Processed = processed;
            Hung = hung;
            Posted = posted;
            DocumentSequenceMain = documentSequenceMain;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return DocumentNumber;
            yield return DocumentSerial ?? 0;
            yield return DocumentDate;
            yield return ReferenceNumber ?? string.Empty;
            yield return Description ?? string.Empty;
            yield return Processed ?? false;
            yield return Hung ?? false;
            yield return Posted ?? false;
            yield return PostUserId ?? 0;
            yield return PostDate ?? DateTime.MinValue;
            yield return UnpostUserId ?? 0;
            yield return UnpostDate ?? DateTime.MinValue;
            yield return AuditReference ?? false;
            yield return AuditReferenceDescription ?? string.Empty;
            yield return AuditReferenceUserId ?? 0;
            yield return AuditReferenceDate ?? DateTime.MinValue;
            yield return DocumentSequenceMain ?? 0;
        }

        public DocumentInfo Post(int userId)
        {
            if (Posted == true)
                throw new DomainException("Document is already posted");

            return new DocumentInfo(
                DocumentNumber,
                DocumentDate,
                DocumentSerial,
                ReferenceNumber,
                Description,
                Processed,
                Hung,
                true,
                DocumentSequenceMain)
            {
                PostUserId = userId,
                PostDate = DateTime.UtcNow,
                UnpostUserId = null,
                UnpostDate = null,
                AuditReference = AuditReference,
                AuditReferenceDescription = AuditReferenceDescription,
                AuditReferenceUserId = AuditReferenceUserId,
                AuditReferenceDate = AuditReferenceDate
            };
        }

        public DocumentInfo Unpost(int userId)
        {
            if (Posted != true)
                throw new DomainException("Document is not posted");

            return new DocumentInfo(
                DocumentNumber,
                DocumentDate,
                DocumentSerial,
                ReferenceNumber,
                Description,
                Processed,
                Hung,
                false,
                DocumentSequenceMain)
            {
                PostUserId = PostUserId,
                PostDate = PostDate,
                UnpostUserId = userId,
                UnpostDate = DateTime.UtcNow,
                AuditReference = AuditReference,
                AuditReferenceDescription = AuditReferenceDescription,
                AuditReferenceUserId = AuditReferenceUserId,
                AuditReferenceDate = AuditReferenceDate
            };
        }

        public DocumentInfo UpdateAuditReference(
            string description,
            int userId)
        {
            return new DocumentInfo(
                DocumentNumber,
                DocumentDate,
                DocumentSerial,
                ReferenceNumber,
                Description,
                Processed,
                Hung,
                Posted,
                DocumentSequenceMain)
            {
                PostUserId = PostUserId,
                PostDate = PostDate,
                UnpostUserId = UnpostUserId,
                UnpostDate = UnpostDate,
                AuditReference = true,
                AuditReferenceDescription = description,
                AuditReferenceUserId = userId,
                AuditReferenceDate = DateTime.UtcNow
            };
        }
    }
} 