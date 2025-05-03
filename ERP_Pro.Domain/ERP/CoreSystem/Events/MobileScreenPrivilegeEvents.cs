using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a new mobile screen privilege is created
/// حدث يتم رفعه عند إنشاء صلاحية شاشة موبايل جديدة
/// </summary>
public class MobileScreenPrivilegeCreatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen privilege
    /// صلاحية شاشة الموبايل
    /// </summary>
    public MobileScreenPrivilege Privilege { get; }

    public MobileScreenPrivilegeCreatedEvent(MobileScreenPrivilege privilege)
    {
        Privilege = privilege;
    }
}

/// <summary>
/// Event raised when a mobile screen privilege is updated
/// حدث يتم رفعه عند تحديث صلاحية شاشة الموبايل
/// </summary>
public class MobileScreenPrivilegeUpdatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen privilege
    /// صلاحية شاشة الموبايل
    /// </summary>
    public MobileScreenPrivilege Privilege { get; }

    public MobileScreenPrivilegeUpdatedEvent(MobileScreenPrivilege privilege)
    {
        Privilege = privilege;
    }
} 