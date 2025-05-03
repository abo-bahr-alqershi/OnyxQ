using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a list select is created
/// حدث يتم رفعه عند إنشاء اختيار القائمة
/// </summary>
public class ListSelectCreatedEvent : DomainEvent
{
    public ListSelect ListSelect { get; }

    public ListSelectCreatedEvent(ListSelect listSelect)
    {
        ListSelect = listSelect;
    }
}

/// <summary>
/// Event raised when a list select is updated
/// حدث يتم رفعه عند تحديث اختيار القائمة
/// </summary>
public class ListSelectUpdatedEvent : DomainEvent
{
    public ListSelect ListSelect { get; }

    public ListSelectUpdatedEvent(ListSelect listSelect)
    {
        ListSelect = listSelect;
    }
}

/// <summary>
/// Event raised when a list select is deleted
/// حدث يتم رفعه عند حذف اختيار القائمة
/// </summary>
public class ListSelectDeletedEvent : DomainEvent
{
    public ListSelect ListSelect { get; }

    public ListSelectDeletedEvent(ListSelect listSelect)
    {
        ListSelect = listSelect;
    }
} 