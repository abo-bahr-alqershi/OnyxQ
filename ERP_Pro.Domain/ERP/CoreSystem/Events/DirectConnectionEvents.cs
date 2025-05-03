using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a direct connection is created.
/// حدث يتم رفعه عند إنشاء اتصال مباشر
/// </summary>
public sealed record DirectConnectionCreatedEvent(DirectConnection DirectConnection) : IDomainEvent;

/// <summary>
/// Represents the event raised when a direct connection is updated.
/// حدث يتم رفعه عند تحديث اتصال مباشر
/// </summary>
public sealed record DirectConnectionUpdatedEvent(DirectConnection DirectConnection) : IDomainEvent; 