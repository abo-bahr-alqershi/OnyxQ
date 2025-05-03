using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a screen label is created.
/// حدث يتم رفعه عند إنشاء تسمية الشاشة
/// </summary>
public sealed record ScreenLabelCreatedEvent(ScreenLabel ScreenLabel) : IDomainEvent;

/// <summary>
/// Represents the event raised when a screen label is updated.
/// حدث يتم رفعه عند تحديث تسمية الشاشة
/// </summary>
public sealed record ScreenLabelUpdatedEvent(ScreenLabel ScreenLabel) : IDomainEvent; 