using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a screen link is created.
/// حدث يتم رفعه عند إنشاء رابط الشاشة
/// </summary>
public sealed record ScreenLinkCreatedEvent(ScreenLink ScreenLink) : IDomainEvent;

/// <summary>
/// Represents the event raised when a screen link is updated.
/// حدث يتم رفعه عند تحديث رابط الشاشة
/// </summary>
public sealed record ScreenLinkUpdatedEvent(ScreenLink ScreenLink) : IDomainEvent; 