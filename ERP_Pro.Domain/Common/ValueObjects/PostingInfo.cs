using System;
using ERP_Pro.Domain.Common.Exceptions;

namespace ERP_Pro.Domain.Common.ValueObjects
{
    public record PostingInfo
    {
        /// <summary> رقم المستخدم الذي أنشأ السجل </summary>
        public int CreatedBy { get; init; }
        /// <summary> تاريخ إنشاء السجل </summary>
        public DateTime CreatedOn { get; init; }
        /// <summary> محطة إنشاء السجل </summary>
        public string CreatedTerminal { get; init; }
        /// <summary> رقم المستخدم الذي رحل السجل </summary>
        public int? PostedBy { get; init; }
        /// <summary> تاريخ ترحيل السجل </summary>
        public DateTime? PostedOn { get; init; }
        /// <summary> محطة ترحيل السجل </summary>
        public string? PostedTerminal { get; init; }
        /// <summary> رقم المستخدم الذي عدل السجل </summary>
        public int? ModifiedBy { get; init; }
        /// <summary> تاريخ تعديل السجل </summary>
        public DateTime? ModifiedOn { get; init; }
        /// <summary> محطة تعديل السجل </summary>
        public string? ModifiedTerminal { get; init; }

        private PostingInfo(
            int createdBy,
            DateTime createdOn,
            string createdTerminal,
            int? postedBy = null,
            DateTime? postedOn = null,
            string? postedTerminal = null,
            int? modifiedBy = null,
            DateTime? modifiedOn = null,
            string? modifiedTerminal = null)
        {
            if (string.IsNullOrWhiteSpace(createdTerminal))
                throw new ValueObjectValidationException("Terminal is required");

            CreatedBy = createdBy;
            CreatedOn = createdOn;
            CreatedTerminal = createdTerminal;
            PostedBy = postedBy;
            PostedOn = postedOn;
            PostedTerminal = postedTerminal;
            ModifiedBy = modifiedBy;
            ModifiedOn = modifiedOn;
            ModifiedTerminal = modifiedTerminal;
        }

        public static PostingInfo Create(int userId, string terminal) =>
            new(userId, DateTime.UtcNow, terminal);

        public PostingInfo Post(int userId, string terminal) =>
            this with
            {
                PostedBy = userId,
                PostedOn = DateTime.UtcNow,
                PostedTerminal = terminal
            };

        public PostingInfo Unpost() =>
            this with
            {
                PostedBy = null,
                PostedOn = null,
                PostedTerminal = null
            };

        public PostingInfo Modify(int userId, string terminal) =>
            this with
            {
                ModifiedBy = userId,
                ModifiedOn = DateTime.UtcNow,
                ModifiedTerminal = terminal
            };
    }
} 