using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events;

/// <summary>
/// Represents the event raised when a user type privilege is created.
/// حدث يتم رفعه عند إنشاء امتياز نوع المستخدم
/// </summary>
public sealed record UserTypePrivilegeCreatedEvent(UserTypePrivilege UserTypePrivilege) : IDomainEvent;

/// <summary>
/// Represents the event raised when a user type privilege is updated.
/// حدث يتم رفعه عند تحديث امتياز نوع المستخدم
/// </summary>
public sealed record UserTypePrivilegeUpdatedEvent(UserTypePrivilege UserTypePrivilege) : IDomainEvent; 