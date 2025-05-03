using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// حدث إنشاء صلاحية علامة جديدة
/// Event for creating a new flag privilege
/// </summary>
public class SystemFlagPrivilegeCreatedEvent : DomainEvent
{
    public SystemFlagPrivilege Privilege { get; }

    public SystemFlagPrivilegeCreatedEvent(SystemFlagPrivilege privilege)
    {
        Privilege = privilege;
    }
}

/// <summary>
/// حدث تحديث صلاحية علامة
/// Event for updating a flag privilege
/// </summary>
public class SystemFlagPrivilegeUpdatedEvent : DomainEvent
{
    public SystemFlagPrivilege Privilege { get; }

    public SystemFlagPrivilegeUpdatedEvent(SystemFlagPrivilege privilege)
    {
        Privilege = privilege;
    }
}

/// <summary>
/// حدث تغيير حالة صلاحية علامة
/// Event for changing flag privilege status
/// </summary>
public class SystemFlagPrivilegeStatusChangedEvent : DomainEvent
{
    public SystemFlagPrivilege Privilege { get; }

    public SystemFlagPrivilegeStatusChangedEvent(SystemFlagPrivilege privilege)
    {
        Privilege = privilege;
    }
}

/// <summary>
/// حدث تمديد فترة صلاحية علامة النظام
/// System flag privilege period extension event
/// </summary>
public class SystemFlagPrivilegePeriodExtendedEvent : DomainEvent
{
    public SystemFlagPrivilege Privilege { get; }
    public DateTime? OldEndDate { get; }
    public DateTime NewEndDate { get; }
    public SystemFlagPrivilegePeriodExtendedEvent(SystemFlagPrivilege privilege, DateTime? oldEndDate, DateTime newEndDate)
    {
        Privilege = privilege;
        OldEndDate = oldEndDate;
        NewEndDate = newEndDate;
    }
} 