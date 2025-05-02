using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class EndorsementInfo : ValueObject
    {
        public bool IsEndorsed { get; private set; }
        public DateTime? EndorsementDate { get; private set; }
        public bool IsEndorsementPosted { get; private set; }
        public DateTime? EndorsementPostDate { get; private set; }
        public int? EndorsementPostedByUserId { get; private set; }
        public int? EndorsementUnpostedByUserId { get; private set; }
        public DateTime? EndorsementUnpostDate { get; private set; }
        public string? EndorsementAccountCode { get; private set; }
        public string? EndorsementBeneficiaryCode { get; private set; }
        public string? EndorsementVendorCode { get; private set; }
        public string? EndorsementNotes { get; private set; }
        public bool EndorsementAudited { get; private set; }
        public string? EndorsementAuditDescription { get; private set; }
        public int? EndorsementAuditUserId { get; private set; }
        public DateTime? EndorsementAuditDate { get; private set; }

        private EndorsementInfo() { }

        public static EndorsementInfo Create(
            bool isEndorsed = false,
            DateTime? endorsementDate = null,
            bool isEndorsementPosted = false,
            DateTime? endorsementPostDate = null,
            int? endorsementPostedByUserId = null,
            int? endorsementUnpostedByUserId = null,
            DateTime? endorsementUnpostDate = null,
            string? endorsementAccountCode = null,
            string? endorsementBeneficiaryCode = null,
            string? endorsementVendorCode = null,
            string? endorsementNotes = null,
            bool endorsementAudited = false,
            string? endorsementAuditDescription = null,
            int? endorsementAuditUserId = null,
            DateTime? endorsementAuditDate = null)
        {
            var info = new EndorsementInfo
            {
                IsEndorsed = isEndorsed,
                EndorsementDate = endorsementDate,
                IsEndorsementPosted = isEndorsementPosted,
                EndorsementPostDate = endorsementPostDate,
                EndorsementPostedByUserId = endorsementPostedByUserId,
                EndorsementUnpostedByUserId = endorsementUnpostedByUserId,
                EndorsementUnpostDate = endorsementUnpostDate,
                EndorsementAccountCode = endorsementAccountCode,
                EndorsementBeneficiaryCode = endorsementBeneficiaryCode,
                EndorsementVendorCode = endorsementVendorCode,
                EndorsementNotes = endorsementNotes,
                EndorsementAudited = endorsementAudited,
                EndorsementAuditDescription = endorsementAuditDescription,
                EndorsementAuditUserId = endorsementAuditUserId,
                EndorsementAuditDate = endorsementAuditDate
            };

            info.ValidateState();
            return info;
        }

        public EndorsementInfo WithEndorsement(
            DateTime endorsementDate,
            string? accountCode = null,
            string? beneficiaryCode = null,
            string? vendorCode = null,
            string? notes = null)
        {
            return Create(
                true,
                endorsementDate,
                IsEndorsementPosted,
                EndorsementPostDate,
                EndorsementPostedByUserId,
                EndorsementUnpostedByUserId,
                EndorsementUnpostDate,
                accountCode ?? EndorsementAccountCode,
                beneficiaryCode ?? EndorsementBeneficiaryCode,
                vendorCode ?? EndorsementVendorCode,
                notes ?? EndorsementNotes,
                EndorsementAudited,
                EndorsementAuditDescription,
                EndorsementAuditUserId,
                EndorsementAuditDate);
        }

        public EndorsementInfo WithEndorsementPosted(int userId)
        {
            if (!IsEndorsed)
                throw new DomainException("لا يمكن ترحيل التظهير قبل إنشائه");

            return Create(
                true,
                EndorsementDate,
                true,
                DateTime.UtcNow,
                userId,
                EndorsementUnpostedByUserId,
                EndorsementUnpostDate,
                EndorsementAccountCode,
                EndorsementBeneficiaryCode,
                EndorsementVendorCode,
                EndorsementNotes,
                EndorsementAudited,
                EndorsementAuditDescription,
                EndorsementAuditUserId,
                EndorsementAuditDate);
        }

        public EndorsementInfo WithEndorsementUnposted(int userId)
        {
            if (!IsEndorsementPosted)
                throw new DomainException("لا يمكن إلغاء ترحيل تظهير غير مرحل");

            return Create(
                true,
                EndorsementDate,
                false,
                null,
                EndorsementPostedByUserId,
                userId,
                DateTime.UtcNow,
                EndorsementAccountCode,
                EndorsementBeneficiaryCode,
                EndorsementVendorCode,
                EndorsementNotes,
                EndorsementAudited,
                EndorsementAuditDescription,
                EndorsementAuditUserId,
                EndorsementAuditDate);
        }

        public EndorsementInfo WithEndorsementAudited(int userId, string? description = null)
        {
            return Create(
                IsEndorsed,
                EndorsementDate,
                IsEndorsementPosted,
                EndorsementPostDate,
                EndorsementPostedByUserId,
                EndorsementUnpostedByUserId,
                EndorsementUnpostDate,
                EndorsementAccountCode,
                EndorsementBeneficiaryCode,
                EndorsementVendorCode,
                EndorsementNotes,
                true,
                description ?? EndorsementAuditDescription,
                userId,
                DateTime.UtcNow);
        }

        private void ValidateState()
        {
            if (IsEndorsed && !EndorsementDate.HasValue)
                throw new DomainException("تاريخ التظهير مطلوب");

            if (IsEndorsementPosted && !EndorsementPostDate.HasValue)
                throw new DomainException("تاريخ ترحيل التظهير مطلوب");

            if (IsEndorsementPosted && !EndorsementPostedByUserId.HasValue)
                throw new DomainException("معرف مستخدم ترحيل التظهير مطلوب");

            if (EndorsementAudited && !EndorsementAuditUserId.HasValue)
                throw new DomainException("معرف مستخدم تدقيق التظهير مطلوب");

            if (EndorsementAudited && !EndorsementAuditDate.HasValue)
                throw new DomainException("تاريخ تدقيق التظهير مطلوب");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return IsEndorsed;
            yield return EndorsementDate ?? DateTime.MinValue;
            yield return IsEndorsementPosted;
            yield return EndorsementPostDate ?? DateTime.MinValue;
            yield return EndorsementPostedByUserId ?? 0;
            yield return EndorsementUnpostedByUserId ?? 0;
            yield return EndorsementUnpostDate ?? DateTime.MinValue;
            yield return EndorsementAccountCode ?? string.Empty;
            yield return EndorsementBeneficiaryCode ?? string.Empty;
            yield return EndorsementVendorCode ?? string.Empty;
            yield return EndorsementNotes ?? string.Empty;
            yield return EndorsementAudited;
            yield return EndorsementAuditDescription ?? string.Empty;
            yield return EndorsementAuditUserId ?? 0;
            yield return EndorsementAuditDate ?? DateTime.MinValue;
        }
    }
} 