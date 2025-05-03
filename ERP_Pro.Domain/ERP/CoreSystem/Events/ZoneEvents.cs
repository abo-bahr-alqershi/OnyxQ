using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a zone is created.
/// حدث يتم رفعه عند إنشاء منطقة
/// </summary>
public sealed record ZoneCreatedEvent(Zone Zone) : IDomainEvent;

/// <summary>
/// Represents the event raised when a zone is updated.
/// حدث يتم رفعه عند تحديث منطقة
/// </summary>
public sealed record ZoneUpdatedEvent(Zone Zone) : IDomainEvent; 