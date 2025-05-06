using System;
using ERP_Pro.Domain.Common.Entities;
// تحديد استيراد Enum بشكل صريح
using DomainNumberGapEnum = ERP_Pro.Shared.Enums.Domain.NumberGapResolutionStatusEnum;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان لتتبع الفجوات في التسلسلات الرقمية
    /// </summary>
    public class NumberGap : Entity<Guid>
    {
        /// <summary>
        /// معرف التسلسل المرتبط
        /// </summary>
        public Guid SequenceId { get; private set; }
        
        /// <summary>
        /// بداية نطاق الفجوة
        /// </summary>
        public long GapStart { get; private set; }
        
        /// <summary>
        /// نهاية نطاق الفجوة
        /// </summary>
        public long GapEnd { get; private set; }
        
        /// <summary>
        /// حجم الفجوة
        /// </summary>
        public long GapSize { get; private set; }
        
        /// <summary>
        /// سبب الفجوة
        /// </summary>
        public string Reason { get; private set; }
        
        /// <summary>
        /// تاريخ اكتشاف الفجوة
        /// </summary>
        public DateTime DiscoveryDate { get; private set; }
        
        /// <summary>
        /// حالة معالجة الفجوة
        /// </summary>
        public DomainNumberGapEnum ResolutionStatus { get; private set; }
        
        /// <summary>
        /// تاريخ معالجة الفجوة
        /// </summary>
        public DateTime? ResolutionDate { get; private set; }
        
        /// <summary>
        /// معرف المستخدم الذي قام بمعالجة الفجوة
        /// </summary>
        public Guid? ResolvedByUserId { get; private set; }
        
        /// <summary>
        /// تفاصيل المعالجة
        /// </summary>
        public string ResolutionDetails { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private NumberGap() { }

        /// <summary>
        /// إنشاء فجوة رقمية جديدة
        /// </summary>
        public NumberGap(
            Guid id,
            Guid sequenceId,
            long gapStart,
            long gapEnd,
            string reason,
            DateTime discoveryDate) : base(id)
        {
            if (gapEnd < gapStart)
                throw new ArgumentException("نهاية الفجوة يجب أن تكون أكبر من أو تساوي بدايتها", nameof(gapEnd));

            SequenceId = sequenceId;
            GapStart = gapStart;
            GapEnd = gapEnd;
            GapSize = gapEnd - gapStart + 1;
            Reason = reason;
            DiscoveryDate = discoveryDate;
            ResolutionStatus = DomainNumberGapEnum.Detected;
        }

        /// <summary>
        /// تسجيل معالجة الفجوة
        /// </summary>
        public void MarkAsResolved(
            Guid resolvedByUserId, 
            string resolutionDetails, 
            DomainNumberGapEnum status = DomainNumberGapEnum.Resolved)
        {
            ResolvedByUserId = resolvedByUserId;
            ResolutionDetails = resolutionDetails;
            ResolutionStatus = status;
            ResolutionDate = DateTime.UtcNow;
        }

        /// <summary>
        /// تعيين الفجوة كقيد المعالجة
        /// </summary>
        public void MarkAsInProgress(Guid userId)
        {
            ResolvedByUserId = userId;
            ResolutionStatus = DomainNumberGapEnum.InProgress;
        }

        /// <summary>
        /// تجاهل الفجوة
        /// </summary>
        public void MarkAsIgnored(Guid userId, string reason)
        {
            ResolvedByUserId = userId;
            ResolutionDetails = reason;
            ResolutionStatus = DomainNumberGapEnum.Ignored;
            ResolutionDate = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث سبب الفجوة
        /// </summary>
        public void UpdateReason(string newReason)
        {
            Reason = newReason;
        }

        /// <summary>
        /// التحقق مما إذا كان الرقم ضمن نطاق الفجوة
        /// </summary>
        public bool IsInGap(long number)
        {
            return number >= GapStart && number <= GapEnd;
        }
    }
} 