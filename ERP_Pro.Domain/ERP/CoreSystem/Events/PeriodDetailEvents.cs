using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
    /// <summary>
    /// Event raised when a new period detail is created
    /// حدث يتم رفعه عند إنشاء تفاصيل فترة جديدة
    /// </summary>
    public record PeriodDetailCreatedEvent : IDomainEvent
    {
        public PeriodDetail PeriodDetail { get; }
        public DateTime OccurredOn { get; }

        public PeriodDetailCreatedEvent(PeriodDetail periodDetail)
        {
            PeriodDetail = periodDetail;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period detail is deactivated
    /// حدث يتم رفعه عند تعطيل تفاصيل الفترة
    /// </summary>
    public record PeriodDetailDeactivatedEvent : IDomainEvent
    {
        public PeriodDetail PeriodDetail { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodDetailDeactivatedEvent(PeriodDetail periodDetail, bool oldState)
        {
            PeriodDetail = periodDetail;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period detail is activated
    /// حدث يتم رفعه عند تنشيط تفاصيل الفترة
    /// </summary>
    public record PeriodDetailActivatedEvent : IDomainEvent
    {
        public PeriodDetail PeriodDetail { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodDetailActivatedEvent(PeriodDetail periodDetail, bool oldState)
        {
            PeriodDetail = periodDetail;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period detail is closed
    /// حدث يتم رفعه عند إغلاق تفاصيل الفترة
    /// </summary>
    public record PeriodDetailClosedEvent : IDomainEvent
    {
        public PeriodDetail PeriodDetail { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodDetailClosedEvent(PeriodDetail periodDetail, bool oldState)
        {
            PeriodDetail = periodDetail;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period detail is reopened
    /// حدث يتم رفعه عند إعادة فتح تفاصيل الفترة
    /// </summary>
    public record PeriodDetailReopenedEvent : IDomainEvent
    {
        public PeriodDetail PeriodDetail { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodDetailReopenedEvent(PeriodDetail periodDetail, bool oldState)
        {
            PeriodDetail = periodDetail;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when period detail information is updated
    /// حدث يتم رفعه عند تحديث معلومات تفاصيل الفترة
    /// </summary>
    public record PeriodDetailInformationUpdatedEvent : IDomainEvent
    {
        public PeriodDetail PeriodDetail { get; }
        public string OldPeriodName { get; }
        public string? OldPeriodDescription { get; }
        public DateTime OldFromDate { get; }
        public DateTime OldToDate { get; }
        public DateTime OccurredOn { get; }

        public PeriodDetailInformationUpdatedEvent(
            PeriodDetail periodDetail,
            string oldPeriodName,
            string? oldPeriodDescription,
            DateTime oldFromDate,
            DateTime oldToDate)
        {
            PeriodDetail = periodDetail;
            OldPeriodName = oldPeriodName;
            OldPeriodDescription = oldPeriodDescription;
            OldFromDate = oldFromDate;
            OldToDate = oldToDate;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 