using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
    /// <summary>
    /// Event raised when a new screen CSS is created
    /// حدث يتم رفعه عند إنشاء CSS شاشة جديد
    /// </summary>
    public record ScreenCssCreatedEvent : IDomainEvent
    {
        public ScreenCss ScreenCss { get; }
        public DateTime OccurredOn { get; }

        public ScreenCssCreatedEvent(ScreenCss screenCss)
        {
            ScreenCss = screenCss;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a screen CSS is deactivated
    /// حدث يتم رفعه عند تعطيل CSS الشاشة
    /// </summary>
    public record ScreenCssDeactivatedEvent : IDomainEvent
    {
        public ScreenCss ScreenCss { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public ScreenCssDeactivatedEvent(ScreenCss screenCss, bool oldState)
        {
            ScreenCss = screenCss;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when a screen CSS is activated
    /// حدث يتم رفعه عند تنشيط CSS الشاشة
    /// </summary>
    public record ScreenCssActivatedEvent : IDomainEvent
    {
        public ScreenCss ScreenCss { get; }
        public bool OldState { get; }
        public DateTime OccurredOn { get; }

        public ScreenCssActivatedEvent(ScreenCss screenCss, bool oldState)
        {
            ScreenCss = screenCss;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Event raised when screen CSS information is updated
    /// حدث يتم رفعه عند تحديث معلومات CSS الشاشة
    /// </summary>
    public record ScreenCssInformationUpdatedEvent : IDomainEvent
    {
        public ScreenCss ScreenCss { get; }
        public string OldCssClassName { get; }
        public string OldCssStyle { get; }
        public string? OldCssDescription { get; }
        public DateTime OccurredOn { get; }

        public ScreenCssInformationUpdatedEvent(
            ScreenCss screenCss,
            string oldCssClassName,
            string oldCssStyle,
            string? oldCssDescription)
        {
            ScreenCss = screenCss;
            OldCssClassName = oldCssClassName;
            OldCssStyle = oldCssStyle;
            OldCssDescription = oldCssDescription;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 