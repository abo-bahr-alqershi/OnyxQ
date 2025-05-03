using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
    /// <summary>
    /// Event raised when a new period day is created
    /// حدث يتم رفعه عند إنشاء يوم فترة جديد
    /// </summary>
    public record PeriodDayCreatedEvent : IDomainEvent
    {
        public PeriodDay PeriodDay { get; }
        public DateTime OccurredOn { get; }

        public PeriodDayCreatedEvent(PeriodDay periodDay)
        {
            PeriodDay = periodDay;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period day is deactivated
    /// حدث يتم رفعه عند تعطيل يوم الفترة
    /// </summary>
    public record PeriodDayDeactivatedEvent : IDomainEvent
    {
        public PeriodDay PeriodDay { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodDayDeactivatedEvent(PeriodDay periodDay, bool oldState)
        {
            PeriodDay = periodDay;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period day is activated
    /// حدث يتم رفعه عند تنشيط يوم الفترة
    /// </summary>
    public record PeriodDayActivatedEvent : IDomainEvent
    {
        public PeriodDay PeriodDay { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodDayActivatedEvent(PeriodDay periodDay, bool oldState)
        {
            PeriodDay = periodDay;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period day is set as a holiday
    /// حدث يتم رفعه عند تعيين يوم الفترة كعطلة
    /// </summary>
    public record PeriodDayHolidaySetEvent : IDomainEvent
    {
        public PeriodDay PeriodDay { get; }
        public bool OldIsHoliday { get; }
        public string? OldHolidayReason { get; }
        public DateTime OccurredOn { get; }

        public PeriodDayHolidaySetEvent(
            PeriodDay periodDay,
            bool oldIsHoliday,
            string? oldHolidayReason)
        {
            PeriodDay = periodDay;
            OldIsHoliday = oldIsHoliday;
            OldHolidayReason = oldHolidayReason;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period day holiday is unset
    /// حدث يتم رفعه عند إلغاء تعيين يوم الفترة كعطلة
    /// </summary>
    public record PeriodDayHolidayUnsetEvent : IDomainEvent
    {
        public PeriodDay PeriodDay { get; }
        public bool OldIsHoliday { get; }
        public string? OldHolidayReason { get; }
        public DateTime OccurredOn { get; }

        public PeriodDayHolidayUnsetEvent(
            PeriodDay periodDay,
            bool oldIsHoliday,
            string? oldHolidayReason)
        {
            PeriodDay = periodDay;
            OldIsHoliday = oldIsHoliday;
            OldHolidayReason = oldHolidayReason;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 