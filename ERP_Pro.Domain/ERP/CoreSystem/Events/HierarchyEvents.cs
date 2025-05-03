using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// حدث إنشاء تسلسل هرمي جديد
/// Event for creating a new hierarchy
/// </summary>
public class HierarchyCreatedEvent : DomainEvent
{
    public Hierarchy Hierarchy { get; }

    public HierarchyCreatedEvent(Hierarchy hierarchy)
    {
        Hierarchy = hierarchy;
    }
}

/// <summary>
/// حدث تحديث تسلسل هرمي
/// Event for updating a hierarchy
/// </summary>
public class HierarchyUpdatedEvent : DomainEvent
{
    public Hierarchy Hierarchy { get; }

    public HierarchyUpdatedEvent(Hierarchy hierarchy)
    {
        Hierarchy = hierarchy;
    }
}

/// <summary>
/// حدث تعطيل تسلسل هرمي
/// Event for inactivating a hierarchy
/// </summary>
public class HierarchyInactivatedEvent : DomainEvent
{
    public Hierarchy Hierarchy { get; }

    public HierarchyInactivatedEvent(Hierarchy hierarchy)
    {
        Hierarchy = hierarchy;
    }
}

/// <summary>
/// حدث تفعيل تسلسل هرمي
/// Event for activating a hierarchy
/// </summary>
public class HierarchyActivatedEvent : DomainEvent
{
    public Hierarchy Hierarchy { get; }

    public HierarchyActivatedEvent(Hierarchy hierarchy)
    {
        Hierarchy = hierarchy;
    }
}

/// <summary>
/// حدث تغيير التسلسل الهرمي الأب
/// Parent hierarchy change event
/// </summary>
public class HierarchyParentChangedEvent : DomainEvent
{
    public Hierarchy Hierarchy { get; }
    public int? OldParentHierarchyNo { get; }
    public int? NewParentHierarchyNo { get; }
    public int OldLevel { get; }
    public int NewLevel { get; }
    public HierarchyParentChangedEvent(Hierarchy hierarchy, int? oldParentHierarchyNo, int? newParentHierarchyNo, int oldLevel, int newLevel)
    {
        Hierarchy = hierarchy;
        OldParentHierarchyNo = oldParentHierarchyNo;
        NewParentHierarchyNo = newParentHierarchyNo;
        OldLevel = oldLevel;
        NewLevel = newLevel;
    }
}

/// <summary>
/// حدث تغيير حالة التسلسل الهرمي
/// Hierarchy status change event
/// </summary>
public class HierarchyStatusChangedEvent : DomainEvent
{
    public Hierarchy Hierarchy { get; }
    public HierarchyStatus OldStatus { get; }
    public HierarchyStatus NewStatus { get; }
    public HierarchyStatusChangedEvent(Hierarchy hierarchy, HierarchyStatus oldStatus, HierarchyStatus newStatus)
    {
        Hierarchy = hierarchy;
        OldStatus = oldStatus;
        NewStatus = newStatus;
    }
}

/// <summary>
/// حدث إضافة تسلسل هرمي فرعي
/// Child hierarchy addition event
/// </summary>
public class HierarchyChildAddedEvent : DomainEvent
{
    public Hierarchy ParentHierarchy { get; }
    public Hierarchy ChildHierarchy { get; }
    public HierarchyChildAddedEvent(Hierarchy parentHierarchy, Hierarchy childHierarchy)
    {
        ParentHierarchy = parentHierarchy;
        ChildHierarchy = childHierarchy;
    }
}

/// <summary>
/// حدث إزالة تسلسل هرمي فرعي
/// Child hierarchy removal event
/// </summary>
public class HierarchyChildRemovedEvent : DomainEvent
{
    public Hierarchy ParentHierarchy { get; }
    public Hierarchy ChildHierarchy { get; }
    public HierarchyChildRemovedEvent(Hierarchy parentHierarchy, Hierarchy childHierarchy)
    {
        ParentHierarchy = parentHierarchy;
        ChildHierarchy = childHierarchy;
    }
} 