using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class AccountingDocumentInfo : ValueObject
    {
        public string? DocumentNo { get; private set; }
        public DateTime? DocumentDate { get; private set; }
        public int? DocumentType { get; private set; }
        public int? JournalType { get; private set; }
        public long? JournalNumber { get; private set; }
        public long? JournalSerial { get; private set; }
        public string? ReferenceNo { get; private set; }
        public DateTime? ReferenceDate { get; private set; }
        public bool IsPosted { get; private set; }
        public DateTime? PostedDate { get; private set; }
        public int? PostedByUserId { get; private set; }
        public string? DocumentDescription { get; private set; }
        public int? DocumentSequence { get; private set; }
        public int? DocumentBranchNo { get; private set; }
        public string? ExternalReferenceNo { get; private set; }
        
        private AccountingDocumentInfo() { }
        
        public static AccountingDocumentInfo Create(
            string? documentNo = null,
            DateTime? documentDate = null,
            int? documentType = null,
            int? journalType = null,
            long? journalNumber = null,
            long? journalSerial = null,
            string? referenceNo = null,
            DateTime? referenceDate = null,
            bool isPosted = false,
            DateTime? postedDate = null,
            int? postedByUserId = null,
            string? documentDescription = null,
            int? documentSequence = null,
            int? documentBranchNo = null,
            string? externalReferenceNo = null)
        {
            var info = new AccountingDocumentInfo
            {
                DocumentNo = documentNo,
                DocumentDate = documentDate,
                DocumentType = documentType,
                JournalType = journalType,
                JournalNumber = journalNumber,
                JournalSerial = journalSerial,
                ReferenceNo = referenceNo,
                ReferenceDate = referenceDate,
                IsPosted = isPosted,
                PostedDate = postedDate,
                PostedByUserId = postedByUserId,
                DocumentDescription = documentDescription,
                DocumentSequence = documentSequence,
                DocumentBranchNo = documentBranchNo,
                ExternalReferenceNo = externalReferenceNo
            };
            
            info.ValidateState();
            return info;
        }

        public AccountingDocumentInfo SetPosted(int userId)
        {
            return Create(
                DocumentNo,
                DocumentDate,
                DocumentType,
                JournalType,
                JournalNumber,
                JournalSerial,
                ReferenceNo,
                ReferenceDate,
                true,
                DateTime.UtcNow,
                userId,
                DocumentDescription,
                DocumentSequence,
                DocumentBranchNo,
                ExternalReferenceNo);
        }

        public AccountingDocumentInfo SetUnposted()
        {
            return Create(
                DocumentNo,
                DocumentDate,
                DocumentType,
                JournalType,
                JournalNumber,
                JournalSerial,
                ReferenceNo,
                ReferenceDate,
                false,
                null,
                null,
                DocumentDescription,
                DocumentSequence,
                DocumentBranchNo,
                ExternalReferenceNo);
        }
        
        private void ValidateState()
        {
            if (DocumentDate.HasValue && ReferenceDate.HasValue && DocumentDate > ReferenceDate)
                throw new DomainException("تاريخ المستند يجب أن يكون قبل أو يساوي تاريخ المرجع");
                
            if (IsPosted && !PostedDate.HasValue)
                throw new DomainException("تاريخ الترحيل مطلوب عند ترحيل المستند");
                
            if (IsPosted && !PostedByUserId.HasValue)
                throw new DomainException("معرف المستخدم مطلوب عند ترحيل المستند");
        }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return DocumentNo ?? string.Empty;
            yield return DocumentDate ?? DateTime.MinValue;
            yield return DocumentType ?? 0;
            yield return JournalType ?? 0;
            yield return JournalNumber ?? 0;
            yield return JournalSerial ?? 0;
            yield return ReferenceNo ?? string.Empty;
            yield return ReferenceDate ?? DateTime.MinValue;
            yield return IsPosted;
            yield return PostedDate ?? DateTime.MinValue;
            yield return PostedByUserId ?? 0;
            yield return DocumentDescription ?? string.Empty;
            yield return DocumentSequence ?? 0;
            yield return DocumentBranchNo ?? 0;
            yield return ExternalReferenceNo ?? string.Empty;
        }
    }
} 