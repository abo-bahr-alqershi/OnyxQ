using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// حدث إنشاء نوع تسلسل هرمي جديد
/// Event for creating a new hierarchy type
/// </summary>
public class HierarchyTypeCreatedEvent : DomainEvent
{
    public HierarchyType HierarchyType { get; }

    public HierarchyTypeCreatedEvent(HierarchyType hierarchyType)
    {
        HierarchyType = hierarchyType;
    }
}

/// <summary>
/// حدث تحديث نوع تسلسل هرمي
/// Event for updating a hierarchy type
/// </summary>
public class HierarchyTypeUpdatedEvent : DomainEvent
{
    public HierarchyType HierarchyType { get; }

    public HierarchyTypeUpdatedEvent(HierarchyType hierarchyType)
    {
        HierarchyType = hierarchyType;
    }
}

/// <summary>
/// حدث تغيير حالة نوع تسلسل هرمي
/// Event for changing hierarchy type status
/// </summary>
public class HierarchyTypeStatusChangedEvent : DomainEvent
{
    public HierarchyType HierarchyType { get; }

    public HierarchyTypeStatusChangedEvent(HierarchyType hierarchyType)
    {
        HierarchyType = hierarchyType;
    }
}

/// <summary>
/// حدث إضافة تسلسل هرمي إلى نوع
/// Hierarchy addition to type event
/// </summary>
public class HierarchyAddedToTypeEvent : DomainEvent
{
    public HierarchyType HierarchyType { get; }
    public Hierarchy Hierarchy { get; }
    public HierarchyAddedToTypeEvent(HierarchyType hierarchyType, Hierarchy hierarchy)
    {
        HierarchyType = hierarchyType;
        Hierarchy = hierarchy;
    }
}

/// <summary>
/// حدث إزالة تسلسل هرمي من نوع
/// Hierarchy removal from type event
/// </summary>
public class HierarchyRemovedFromTypeEvent : DomainEvent
{
    public HierarchyType HierarchyType { get; }
    public Hierarchy Hierarchy { get; }
    public HierarchyRemovedFromTypeEvent(HierarchyType hierarchyType, Hierarchy hierarchy)
    {
        HierarchyType = hierarchyType;
        Hierarchy = hierarchy;
    }
} 