using System;
using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث إنشاء تسلسل جديد
    /// </summary>
    public class SequenceCreatedEvent : DomainEvent
    {
        public Guid SequenceId { get; }

        public SequenceCreatedEvent(Guid sequenceId)
        {
            SequenceId = sequenceId;
        }
    }

    /// <summary>
    /// حدث تحديث تسلسل
    /// </summary>
    public class SequenceUpdatedEvent : DomainEvent
    {
        public Guid SequenceId { get; }

        public SequenceUpdatedEvent(Guid sequenceId)
        {
            SequenceId = sequenceId;
        }
    }

    /// <summary>
    /// حدث حذف تسلسل
    /// </summary>
    public class SequenceDeletedEvent : DomainEvent
    {
        public Guid SequenceId { get; }

        public SequenceDeletedEvent(Guid sequenceId)
        {
            SequenceId = sequenceId;
        }
    }

    /// <summary>
    /// حدث تغيير حالة التسلسل
    /// </summary>
    public class SequenceStatusChangedEvent : DomainEvent
    {
        public Guid SequenceId { get; }
        public ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum NewStatus { get; }

        public SequenceStatusChangedEvent(Guid sequenceId, ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum newStatus)
        {
            SequenceId = sequenceId;
            NewStatus = newStatus;
        }
    }

    /// <summary>
    /// حدث إنشاء مجموعة تسلسلات جديدة
    /// </summary>
    public class SequenceGroupCreatedEvent : DomainEvent
    {
        public Guid GroupId { get; }
        public string GroupName { get; }

        public SequenceGroupCreatedEvent(Guid groupId, string groupName)
        {
            GroupId = groupId;
            GroupName = groupName;
        }
    }

    /// <summary>
    /// حدث حجز نطاق من الأرقام التسلسلية
    /// </summary>
    public class NumberRangeReservedEvent : DomainEvent
    {
        public Guid SequenceId { get; }
        public Guid AllocationId { get; }
        public long RangeStart { get; }
        public long RangeEnd { get; }

        public NumberRangeReservedEvent(Guid sequenceId, Guid allocationId, long rangeStart, long rangeEnd)
        {
            SequenceId = sequenceId;
            AllocationId = allocationId;
            RangeStart = rangeStart;
            RangeEnd = rangeEnd;
        }
    }

    /// <summary>
    /// حدث إنشاء رقم تسلسلي جديد
    /// </summary>
    public class NumberGeneratedEvent : DomainEvent
    {
        public Guid SequenceId { get; }
        public string FormattedNumber { get; }
        public long RawNumber { get; }

        public NumberGeneratedEvent(Guid sequenceId, string formattedNumber, long rawNumber)
        {
            SequenceId = sequenceId;
            FormattedNumber = formattedNumber;
            RawNumber = rawNumber;
        }
    }

    /// <summary>
    /// حدث إعادة تعيين عداد التسلسل
    /// </summary>
    public class SequenceCounterResetEvent : DomainEvent
    {
        public Guid SequenceId { get; }
        public long NewValue { get; }

        public SequenceCounterResetEvent(Guid sequenceId, long newValue)
        {
            SequenceId = sequenceId;
            NewValue = newValue;
        }
    }

    /// <summary>
    /// حدث تكامل التسلسل مع نظام خارجي
    /// </summary>
    public class SequenceIntegrationEvent : DomainEvent
    {
        public Guid SequenceId { get; }
        public string ExternalSystemCode { get; }
        public string ExternalSequenceCode { get; }

        public SequenceIntegrationEvent(Guid sequenceId, string externalSystemCode, string externalSequenceCode)
        {
            SequenceId = sequenceId;
            ExternalSystemCode = externalSystemCode;
            ExternalSequenceCode = externalSequenceCode;
        }
    }

    /// <summary>
    /// حدث تحذير من نفاد نطاق الأرقام
    /// </summary>
    public class NumberRangeExhaustionWarningEvent : DomainEvent
    {
        public Guid SequenceId { get; }
        public long RemainingCount { get; }
        public double PercentageLeft { get; }
        public DateTime ProjectedExhaustionDate { get; }

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
        }
    }
} 