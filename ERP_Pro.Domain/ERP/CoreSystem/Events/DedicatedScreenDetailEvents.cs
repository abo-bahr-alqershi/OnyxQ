using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a dedicated screen detail is created.
/// حدث يتم رفعه عند إنشاء تفاصيل الشاشة المخصصة
/// </summary>
public sealed record DedicatedScreenDetailCreatedEvent(DedicatedScreenDetail DedicatedScreenDetail) : IDomainEvent;

/// <summary>
/// Represents the event raised when a dedicated screen detail is updated.
/// حدث يتم رفعه عند تحديث تفاصيل الشاشة المخصصة
/// </summary>
public sealed record DedicatedScreenDetailUpdatedEvent(DedicatedScreenDetail DedicatedScreenDetail) : IDomainEvent; 