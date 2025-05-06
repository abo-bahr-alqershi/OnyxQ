using System;
using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث إنشاء تسلسل جديد
    /// </summary>
    public class SequenceCreatedEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public DateTime OccurredOn { get; }

        public SequenceCreatedEvent(Guid sequenceId)
        {
            SequenceId = sequenceId;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث تحديث تسلسل
    /// </summary>
    public class SequenceUpdatedEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public DateTime OccurredOn { get; }

        public SequenceUpdatedEvent(Guid sequenceId)
        {
            SequenceId = sequenceId;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث حذف تسلسل
    /// </summary>
    public class SequenceDeletedEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public DateTime OccurredOn { get; }

        public SequenceDeletedEvent(Guid sequenceId)
        {
            SequenceId = sequenceId;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث تغيير حالة التسلسل
    /// </summary>
    public class SequenceStatusChangedEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public SequenceStatusEnum NewStatus { get; }
        public DateTime OccurredOn { get; }

        public SequenceStatusChangedEvent(Guid sequenceId, SequenceStatusEnum newStatus)
        {
            SequenceId = sequenceId;
            NewStatus = newStatus;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث إنشاء مجموعة تسلسلات جديدة
    /// </summary>
    public class SequenceGroupCreatedEvent : IDomainEvent
    {
        public Guid GroupId { get; }
        public string GroupName { get; }
        public DateTime OccurredOn { get; }

        public SequenceGroupCreatedEvent(Guid groupId, string groupName)
        {
            GroupId = groupId;
            GroupName = groupName;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث حجز نطاق من الأرقام التسلسلية
    /// </summary>
    public class NumberRangeReservedEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public Guid AllocationId { get; }
        public long RangeStart { get; }
        public long RangeEnd { get; }
        public DateTime OccurredOn { get; }

        public NumberRangeReservedEvent(Guid sequenceId, Guid allocationId, long rangeStart, long rangeEnd)
        {
            SequenceId = sequenceId;
            AllocationId = allocationId;
            RangeStart = rangeStart;
            RangeEnd = rangeEnd;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث إنشاء رقم تسلسلي جديد
    /// </summary>
    public class NumberGeneratedEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public string FormattedNumber { get; }
        public long RawNumber { get; }
        public DateTime OccurredOn { get; }

        public NumberGeneratedEvent(Guid sequenceId, string formattedNumber, long rawNumber)
        {
            SequenceId = sequenceId;
            FormattedNumber = formattedNumber;
            RawNumber = rawNumber;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث إعادة تعيين عداد التسلسل
    /// </summary>
    public class SequenceCounterResetEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public long NewValue { get; }
        public DateTime OccurredOn { get; }

        public SequenceCounterResetEvent(Guid sequenceId, long newValue)
        {
            SequenceId = sequenceId;
            NewValue = newValue;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث تكامل التسلسل مع نظام خارجي
    /// </summary>
    public class SequenceIntegrationEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public string ExternalSystemCode { get; }
        public string ExternalSequenceCode { get; }
        public DateTime OccurredOn { get; }

        public SequenceIntegrationEvent(Guid sequenceId, string externalSystemCode, string externalSequenceCode)
        {
            SequenceId = sequenceId;
            ExternalSystemCode = externalSystemCode;
            ExternalSequenceCode = externalSequenceCode;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// حدث تحذير من نفاد نطاق الأرقام
    /// </summary>
    public class NumberRangeExhaustionWarningEvent : IDomainEvent
    {
        public Guid SequenceId { get; }
        public long RemainingCount { get; }
        public double PercentageLeft { get; }
        public DateTime ProjectedExhaustionDate { get; }
        public DateTime OccurredOn { get; }

        public NumberRangeExhaustionWarningEvent(
            Guid sequenceId, 
            long remainingCount, 
            double percentageLeft, 
            DateTime projectedExhaustionDate)
        {
            SequenceId = sequenceId;
            RemainingCount = remainingCount;
            PercentageLeft = percentageLeft;
            ProjectedExhaustionDate = projectedExhaustionDate;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 