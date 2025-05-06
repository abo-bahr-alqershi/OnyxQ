using System;
using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان لتتبع سجلات تدقيق التسلسلات
    /// </summary>
    public class SequenceAudit : Entity<Guid>
    {
        /// <summary>
        /// معرف التسلسل المرتبط
        /// </summary>
        public Guid SequenceId { get; private set; }
        
        /// <summary>
        /// نوع حدث التدقيق
        /// </summary>
        public ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum Type { get; private set; }
        
        /// <summary>
        /// تاريخ الحدث
        /// </summary>
        public DateTime Timestamp { get; private set; }
        
        /// <summary>
        /// معرف المستخدم المسؤول عن الحدث
        /// </summary>
        public Guid UserId { get; private set; }
        
        /// <summary>
        /// معرف الفرع المرتبط (إن وجد)
        /// </summary>
        public Guid? BranchId { get; private set; }
        
        /// <summary>
        /// علاقة الفرع المرتبط بالحدث
        /// </summary>
        public virtual Branch Branch { get; private set; }
        
        /// <summary>
        /// تفاصيل الحدث
        /// </summary>
        public string Details { get; private set; }
        
        /// <summary>
        /// القيمة القديمة (للتغييرات)
        /// </summary>
        public string OldValue { get; private set; }
        
        /// <summary>
        /// القيمة الجديدة (للتغييرات)
        /// </summary>
        public string NewValue { get; private set; }
        
        /// <summary>
        /// المعرف المرتبط (معرف الرقم المستخدم، معرف التخصيص، إلخ)
        /// </summary>
        public Guid? RelatedId { get; private set; }
        
        /// <summary>
        /// وصف الحدث
        /// </summary>
        public string Description { get; private set; }
        
        /// <summary>
        /// بيانات إضافية (يمكن أن تكون في تنسيق JSON)
        /// </summary>
        public string AdditionalData { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private SequenceAudit() { }

        /// <summary>
        /// إنشاء سجل تدقيق جديد
        /// </summary>
        public SequenceAudit(
            Guid id,
            Guid sequenceId,
            ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum type,
            string details,
            Guid userId,
            Guid? branchId = null) : base(id)
        {
            SequenceId = sequenceId;
            Type = type;
            Details = details;
            UserId = userId;
            BranchId = branchId;
            Timestamp = DateTime.UtcNow;
        }

        /// <summary>
        /// إنشاء سجل تدقيق جديد
        /// </summary>
        public SequenceAudit(
            Guid id,
            Guid sequenceId,
            ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum type,
            Guid userId,
            string description,
            Guid? relatedId = null,
            string oldValue = null,
            string newValue = null,
            Guid? branchId = null,
            string additionalData = null) : base(id)
        {
            SequenceId = sequenceId;
            Type = type;
            Timestamp = DateTime.UtcNow;
            UserId = userId;
            BranchId = branchId;
            OldValue = oldValue;
            NewValue = newValue;
            RelatedId = relatedId;
            Description = description;
            AdditionalData = additionalData;
        }

        /// <summary>
        /// إنشاء سجل تدقيق لإنشاء تسلسل جديد
        /// </summary>
        public static SequenceAudit CreateSequenceCreatedAudit(
            Guid sequenceId,
            Guid userId,
            string sequenceCode,
            string sequenceName,
            Guid? branchId = null)
        {
            return new SequenceAudit(
                Guid.NewGuid(),
                sequenceId,
                ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum.SequenceCreated,
                $"تم إنشاء تسلسل جديد: {sequenceCode} - {sequenceName}",
                userId,
                branchId: branchId);
        }

        /// <summary>
        /// إنشاء سجل تدقيق لتعديل تسلسل
        /// </summary>
        public static SequenceAudit CreateSequenceUpdatedAudit(
            Guid sequenceId,
            Guid userId,
            string fieldName,
            string oldValue,
            string newValue,
            Guid? branchId = null)
        {
            return new SequenceAudit(
                Guid.NewGuid(),
                sequenceId,
                ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum.SequenceUpdated,
                userId,
                $"تم تعديل حقل {fieldName} في التسلسل",
                oldValue: oldValue,
                newValue: newValue,
                branchId: branchId);
        }

        /// <summary>
        /// إنشاء سجل تدقيق لتغيير حالة تسلسل
        /// </summary>
        public static SequenceAudit CreateStatusChangedAudit(
            Guid sequenceId,
            Guid userId,
            ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum oldStatus,
            ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum newStatus,
            Guid? branchId = null)
        {
            return new SequenceAudit(
                Guid.NewGuid(),
                sequenceId,
                ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum.StatusChanged,
                $"تم تغيير حالة التسلسل من {oldStatus} إلى {newStatus}",
                userId,
                branchId: branchId);
        }

        /// <summary>
        /// إنشاء سجل تدقيق لإنشاء رقم تسلسلي جديد
        /// </summary>
        public static SequenceAudit CreateNumberGeneratedAudit(
            Guid sequenceId,
            Guid userId,
            string formattedNumber,
            long rawNumber,
            Guid? branchId = null)
        {
            return new SequenceAudit(
                Guid.NewGuid(),
                sequenceId,
                ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum.NumberGenerated,
                userId,
                $"تم إنشاء رقم تسلسلي جديد: {formattedNumber}",
                newValue: formattedNumber,
                additionalData: rawNumber.ToString(),
                branchId: branchId);
        }

        /// <summary>
        /// إنشاء سجل تدقيق لإعادة تعيين عداد التسلسل
        /// </summary>
        public static SequenceAudit CreateCounterResetAudit(
            Guid sequenceId,
            Guid userId,
            long oldValue,
            long newValue,
            Guid? branchId = null)
        {
            return new SequenceAudit(
                Guid.NewGuid(),
                sequenceId,
                ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum.CounterReset,
                userId,
                $"تم إعادة تعيين عداد التسلسل من {oldValue} إلى {newValue}",
                oldValue: oldValue.ToString(),
                newValue: newValue.ToString(),
                branchId: branchId);
        }

        /// <summary>
        /// إنشاء سجل تدقيق لحجز نطاق من الأرقام
        /// </summary>
        public static SequenceAudit CreateRangeReservedAudit(
            Guid sequenceId,
            Guid userId,
            Guid allocationId,
            long rangeStart,
            long rangeEnd,
            string reason,
            Guid? branchId = null)
        {
            return new SequenceAudit(
                Guid.NewGuid(),
                sequenceId,
                ERP_Pro.Shared.Enums.Domain.SequenceAuditTypeEnum.RangeReserved,
                userId,
                $"تم حجز نطاق من الأرقام: {rangeStart} - {rangeEnd}، السبب: {reason}",
                relatedId: allocationId,
                additionalData: $"{{ \"start\": {rangeStart}, \"end\": {rangeEnd}, \"reason\": \"{reason}\" }}",
                branchId: branchId);
        }
    }
} 