using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
    /// <summary>
    /// Event raised when a new period master is created
    /// حدث يتم رفعه عند إنشاء رئيسي فترة جديد
    /// </summary>
    public record PeriodMasterCreatedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public DateTime OccurredOn { get; }

        public PeriodMasterCreatedEvent(PeriodMaster periodMaster)
        {
            PeriodMaster = periodMaster;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period master is deactivated
    /// حدث يتم رفعه عند تعطيل رئيسي الفترة
    /// </summary>
    public record PeriodMasterDeactivatedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodMasterDeactivatedEvent(PeriodMaster periodMaster, bool oldState)
        {
            PeriodMaster = periodMaster;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period master is activated
    /// حدث يتم رفعه عند تنشيط رئيسي الفترة
    /// </summary>
    public record PeriodMasterActivatedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodMasterActivatedEvent(PeriodMaster periodMaster, bool oldState)
        {
            PeriodMaster = periodMaster;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period master is closed
    /// حدث يتم رفعه عند إغلاق رئيسي الفترة
    /// </summary>
    public record PeriodMasterClosedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodMasterClosedEvent(PeriodMaster periodMaster, bool oldState)
        {
            PeriodMaster = periodMaster;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period master is reopened
    /// حدث يتم رفعه عند إعادة فتح رئيسي الفترة
    /// </summary>
    public record PeriodMasterReopenedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodMasterReopenedEvent(PeriodMaster periodMaster, bool oldState)
        {
            PeriodMaster = periodMaster;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when period master information is updated
    /// حدث يتم رفعه عند تحديث معلومات رئيسي الفترة
    /// </summary>
    public record PeriodMasterInformationUpdatedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public string OldPeriodName { get; }
        public string? OldPeriodDescription { get; }
        public DateTime OldFromDate { get; }
        public DateTime OldToDate { get; }
        public DateTime OccurredOn { get; }

        public PeriodMasterInformationUpdatedEvent(
            PeriodMaster periodMaster,
            string oldPeriodName,
            string? oldPeriodDescription,
            DateTime oldFromDate,
            DateTime oldToDate)
        {
            PeriodMaster = periodMaster;
            OldPeriodName = oldPeriodName;
            OldPeriodDescription = oldPeriodDescription;
            OldFromDate = oldFromDate;
            OldToDate = oldToDate;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period detail is added to a period master
    /// حدث يتم رفعه عند إضافة تفاصيل فترة إلى رئيسي الفترة
    /// </summary>
    public record PeriodDetailAddedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public PeriodDetail PeriodDetail { get; }
        public DateTime OccurredOn { get; }

        public PeriodDetailAddedEvent(PeriodMaster periodMaster, PeriodDetail periodDetail)
        {
            PeriodMaster = periodMaster;
            PeriodDetail = periodDetail;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period day is added to a period master
    /// حدث يتم رفعه عند إضافة يوم فترة إلى رئيسي الفترة
    /// </summary>
    public record PeriodDayAddedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public PeriodDay PeriodDay { get; }
        public DateTime OccurredOn { get; }

        public PeriodDayAddedEvent(PeriodMaster periodMaster, PeriodDay periodDay)
        {
            PeriodMaster = periodMaster;
            PeriodDay = periodDay;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period branch close is added to a period master
    /// حدث يتم رفعه عند إضافة إغلاق فرع فترة إلى رئيسي الفترة
    /// </summary>
    public record PeriodBranchCloseAddedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public PeriodBranchClose PeriodBranchClose { get; }
        public DateTime OccurredOn { get; }

        public PeriodBranchCloseAddedEvent(PeriodMaster periodMaster, PeriodBranchClose periodBranchClose)
        {
            PeriodMaster = periodMaster;
            PeriodBranchClose = periodBranchClose;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period branch current close is added to a period master
    /// حدث يتم رفعه عند إضافة إغلاق فرع فترة حالي إلى رئيسي الفترة
    /// </summary>
    public record PeriodBranchCurrentCloseAddedEvent : IDomainEvent
    {
        public PeriodMaster PeriodMaster { get; }
        public PeriodBranchCurrentClose PeriodBranchCurrentClose { get; }
        public DateTime OccurredOn { get; }

        public PeriodBranchCurrentCloseAddedEvent(
            PeriodMaster periodMaster,
            PeriodBranchCurrentClose periodBranchCurrentClose)
        {
            PeriodMaster = periodMaster;
            PeriodBranchCurrentClose = periodBranchCurrentClose;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 