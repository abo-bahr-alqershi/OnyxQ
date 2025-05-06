using System;
using ERP_Pro.Domain.Common.Exceptions;

namespace ERP_Pro.Domain.Common.ValueObjects
{
    public record AuditInfo
    {
        /// <summary> رقم المستخدم الذي أنشأ السجل </summary>
        public int CreatedBy { get; init; }
        /// <summary> تاريخ إنشاء السجل </summary>
        public DateTime CreatedOn { get; init; }
        /// <summary> محطة إنشاء السجل </summary>
        public string CreatedTerminal { get; init; }
        /// <summary> رقم المستخدم الذي دقق السجل </summary>
        public int? AuditedBy { get; init; }
        /// <summary> تاريخ تدقيق السجل </summary>
        public DateTime? AuditedOn { get; init; }
        /// <summary> محطة تدقيق السجل </summary>
        public string? AuditedTerminal { get; init; }
        /// <summary> وصف التدقيق </summary>
        public string? AuditDescription { get; init; }
        /// <summary> رقم المستخدم الذي عدل السجل </summary>
        public int? ModifiedBy { get; init; }
        /// <summary> تاريخ تعديل السجل </summary>
        public DateTime? ModifiedOn { get; init; }
        /// <summary> محطة تعديل السجل </summary>
        public string? ModifiedTerminal { get; init; }

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
                throw new ValueObjectValidationException("Terminal is required");

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