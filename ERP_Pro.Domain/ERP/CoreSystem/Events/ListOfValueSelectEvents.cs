using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a list of value select is created
/// حدث يتم رفعه عند إنشاء اختيار قائمة القيم
/// </summary>
public class ListOfValueSelectCreatedEvent : DomainEvent
{
    public ListOfValueSelect Select { get; }

    public ListOfValueSelectCreatedEvent(ListOfValueSelect select)
    {
        Select = select;
    }
}

/// <summary>
/// Event raised when a list of value select is updated
/// حدث يتم رفعه عند تحديث اختيار قائمة القيم
/// </summary>
public class ListOfValueSelectUpdatedEvent : DomainEvent
{
    public ListOfValueSelect Select { get; }

    public ListOfValueSelectUpdatedEvent(ListOfValueSelect select)
    {
        Select = select;
    }
} 