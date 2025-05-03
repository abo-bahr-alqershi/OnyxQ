using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a screen CSS privilege is created.
/// حدث يتم رفعه عند إنشاء امتياز CSS للشاشة
/// </summary>
public sealed record ScreenCssPrivilegeCreatedEvent(ScreenCssPrivilege ScreenCssPrivilege) : IDomainEvent;

/// <summary>
/// Represents the event raised when a screen CSS privilege is updated.
/// حدث يتم رفعه عند تحديث امتياز CSS للشاشة
/// </summary>
public sealed record ScreenCssPrivilegeUpdatedEvent(ScreenCssPrivilege ScreenCssPrivilege) : IDomainEvent; 