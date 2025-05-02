using System;

namespace ERP_Pro.Domain.Common.ValueObjects
{
    public record AuditInfo
    {
        /// <summary> رقم المستخدم الذي أنشأ السجل </summary>
        public int CreatedBy { get; }
        /// <summary> تاريخ إنشاء السجل </summary>
        public DateTime CreatedOn { get; }
        /// <summary> محطة إنشاء السجل </summary>
        public string CreatedTerminal { get; }
        /// <summary> رقم المستخدم الذي دقق السجل </summary>
        public int? AuditedBy { get; }
        /// <summary> تاريخ تدقيق السجل </summary>
        public DateTime? AuditedOn { get; }
        /// <summary> محطة تدقيق السجل </summary>
        public string? AuditedTerminal { get; }
        /// <summary> وصف التدقيق </summary>
        public string? AuditDescription { get; }
        /// <summary> رقم المستخدم الذي عدل السجل </summary>
        public int? ModifiedBy { get; }
        /// <summary> تاريخ تعديل السجل </summary>
        public DateTime? ModifiedOn { get; }
        /// <summary> محطة تعديل السجل </summary>
        public string? ModifiedTerminal { get; }

        private AuditInfo(
            int createdBy,
            DateTime createdOn,
            string createdTerminal,
            int? auditedBy = null,
            DateTime? auditedOn = null,
            string? auditedTerminal = null,
            string? auditDescription = null,
            int? modifiedBy = null,
            DateTime? modifiedOn = null,
            string? modifiedTerminal = null)
        {
            if (string.IsNullOrWhiteSpace(createdTerminal))
                throw new DomainException("Terminal is required");

            CreatedBy = createdBy;
            CreatedOn = createdOn;
            CreatedTerminal = createdTerminal;
            AuditedBy = auditedBy;
            AuditedOn = auditedOn;
            AuditedTerminal = auditedTerminal;
            AuditDescription = auditDescription;
            ModifiedBy = modifiedBy;
            ModifiedOn = modifiedOn;
            ModifiedTerminal = modifiedTerminal;
        }

        public static AuditInfo Create(int userId, string terminal) =>
            new(userId, DateTime.UtcNow, terminal);

        public AuditInfo Audit(int userId, string terminal, string description) =>
            this with
            {
                AuditedBy = userId,
                AuditedOn = DateTime.UtcNow,
                AuditedTerminal = terminal,
                AuditDescription = description
            };

        public AuditInfo Modify(int userId, string terminal) =>
            this with
            {
                ModifiedBy = userId,
                ModifiedOn = DateTime.UtcNow,
                ModifiedTerminal = terminal
            };
    }
} 