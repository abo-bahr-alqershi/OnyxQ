using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// حدث إنشاء صلاحية مستخدم فرع جديدة
/// Branch user privilege creation event
/// </summary>
public class BranchUserPrivilegeCreatedEvent : DomainEvent
{
    public BranchUserPrivilege Privilege { get; }
    public BranchUserPrivilegeCreatedEvent(BranchUserPrivilege privilege) => Privilege = privilege;
}

/// <summary>
/// حدث تحديث معلومات صلاحية مستخدم الفرع
/// Branch user privilege information update event
/// </summary>
public class BranchUserPrivilegeUpdatedEvent : DomainEvent
{
    public BranchUserPrivilege Privilege { get; }
    public BranchUserPrivilegeUpdatedEvent(BranchUserPrivilege privilege) => Privilege = privilege;
}

/// <summary>
/// حدث تغيير حالة صلاحية مستخدم الفرع
/// Branch user privilege status change event
/// </summary>
public class BranchUserPrivilegeStatusChangedEvent : DomainEvent
{
    public BranchUserPrivilege Privilege { get; }
    public PrivilegeStatus OldStatus { get; }
    public PrivilegeStatus NewStatus { get; }
    public BranchUserPrivilegeStatusChangedEvent(BranchUserPrivilege privilege, PrivilegeStatus oldStatus, PrivilegeStatus newStatus)
    {
        Privilege = privilege;
        OldStatus = oldStatus;
        NewStatus = newStatus;
    }
}

/// <summary>
/// حدث تمديد فترة صلاحية مستخدم الفرع
/// Branch user privilege period extension event
/// </summary>
public class BranchUserPrivilegePeriodExtendedEvent : DomainEvent
{
    public BranchUserPrivilege Privilege { get; }
    public DateTime? OldEndDate { get; }
    public DateTime NewEndDate { get; }
    public BranchUserPrivilegePeriodExtendedEvent(BranchUserPrivilege privilege, DateTime? oldEndDate, DateTime newEndDate)
    {
        Privilege = privilege;
        OldEndDate = oldEndDate;
        NewEndDate = newEndDate;
    }
} 