using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
    /// <summary>
    /// Event raised when a new period branch current close is created
    /// حدث يتم رفعه عند إنشاء إقفال فترة حالي جديد للفرع
    /// </summary>
    public record PeriodBranchCurrentCloseCreatedEvent : IDomainEvent
    {
        public PeriodBranchCurrentClose PeriodBranchCurrentClose { get; }
        public DateTime OccurredOn { get; }

        public PeriodBranchCurrentCloseCreatedEvent(PeriodBranchCurrentClose periodBranchCurrentClose)
        {
            PeriodBranchCurrentClose = periodBranchCurrentClose;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period branch current close is deactivated
    /// حدث يتم رفعه عند تعطيل إقفال فترة حالي للفرع
    /// </summary>
    public record PeriodBranchCurrentCloseDeactivatedEvent : IDomainEvent
    {
        public PeriodBranchCurrentClose PeriodBranchCurrentClose { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodBranchCurrentCloseDeactivatedEvent(
            PeriodBranchCurrentClose periodBranchCurrentClose,
            bool oldState)
        {
            PeriodBranchCurrentClose = periodBranchCurrentClose;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period branch current close is activated
    /// حدث يتم رفعه عند تنشيط إقفال فترة حالي للفرع
    /// </summary>
    public record PeriodBranchCurrentCloseActivatedEvent : IDomainEvent
    {
        public PeriodBranchCurrentClose PeriodBranchCurrentClose { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodBranchCurrentCloseActivatedEvent(
            PeriodBranchCurrentClose periodBranchCurrentClose,
            bool oldState)
        {
            PeriodBranchCurrentClose = periodBranchCurrentClose;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a period branch current close exchange rate is updated
    /// حدث يتم رفعه عند تحديث سعر الصرف لإقفال فترة حالي للفرع
    /// </summary>
    public record PeriodBranchCurrentCloseExchangeRateUpdatedEvent : IDomainEvent
    {
        public PeriodBranchCurrentClose PeriodBranchCurrentClose { get; }
        public ExchangeRate OldExchangeRate { get; }
        public DateTime OccurredOn { get; }

        public PeriodBranchCurrentCloseExchangeRateUpdatedEvent(
            PeriodBranchCurrentClose periodBranchCurrentClose,
            ExchangeRate oldExchangeRate)
        {
            PeriodBranchCurrentClose = periodBranchCurrentClose;
            OldExchangeRate = oldExchangeRate;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 