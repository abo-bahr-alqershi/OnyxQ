using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// حدث إنشاء علامة جديدة
/// Flag creation event
/// </summary>
public class FlagCreatedEvent : DomainEvent
{
    public Flag Flag { get; }
    public FlagCreatedEvent(Flag flag) => Flag = flag;
}

/// <summary>
/// حدث تحديث معلومات العلامة
/// Flag information update event
/// </summary>
public class FlagUpdatedEvent : DomainEvent
{
    public Flag Flag { get; }
    public FlagUpdatedEvent(Flag flag) => Flag = flag;
}

/// <summary>
/// حدث تغيير حالة العلامة
/// Flag status change event
/// </summary>
public class FlagStatusChangedEvent : DomainEvent
{
    public Flag Flag { get; }
    public FlagStatus OldStatus { get; }
    public FlagStatus NewStatus { get; }
    public FlagStatusChangedEvent(Flag flag, FlagStatus oldStatus, FlagStatus newStatus)
    {
        Flag = flag;
        OldStatus = oldStatus;
        NewStatus = newStatus;
    }
}

/// <summary>
/// حدث إضافة صلاحية للعلامة
/// Flag privilege addition event
/// </summary>
public class FlagPrivilegeAddedEvent : DomainEvent
{
    public Flag Flag { get; }
    public FlagPrivilege Privilege { get; }
    public FlagPrivilegeAddedEvent(Flag flag, FlagPrivilege privilege)
    {
        Flag = flag;
        Privilege = privilege;
    }
}

/// <summary>
/// حدث إزالة صلاحية من العلامة
/// Flag privilege removal event
/// </summary>
public class FlagPrivilegeRemovedEvent : DomainEvent
{
    public Flag Flag { get; }
    public FlagPrivilege Privilege { get; }
    public FlagPrivilegeRemovedEvent(Flag flag, FlagPrivilege privilege)
    {
        Flag = flag;
        Privilege = privilege;
    }
} 