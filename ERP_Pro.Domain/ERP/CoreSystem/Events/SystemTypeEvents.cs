using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a system type is created.
/// حدث يتم رفعه عند إنشاء نوع نظام
/// </summary>
public sealed record SystemTypeCreatedEvent(SystemType SystemType) : IDomainEvent;

/// <summary>
/// Represents the event raised when a system type is updated.
/// حدث يتم رفعه عند تحديث نوع نظام
/// </summary>
public sealed record SystemTypeUpdatedEvent(SystemType SystemType) : IDomainEvent; 