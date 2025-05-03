using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a select field is created
/// حدث يتم رفعه عند إنشاء حقل اختيار
/// </summary>
public class SelectFieldCreated : DomainEvent
{
    public SelectField Field { get; }

    public SelectFieldCreated(SelectField field)
    {
        Field = field;
    }
}

/// <summary>
/// Event raised when a select field is updated
/// حدث يتم رفعه عند تحديث حقل اختيار
/// </summary>
public class SelectFieldUpdated : DomainEvent
{
    public SelectField Field { get; }

    public SelectFieldUpdated(SelectField field)
    {
        Field = field;
    }
}

/// <summary>
/// Event raised when a select field is deleted
/// حدث يتم رفعه عند حذف حقل اختيار
/// </summary>
public class SelectFieldDeleted : DomainEvent
{
    public SelectField Field { get; }

    public SelectFieldDeleted(SelectField field)
    {
        Field = field;
    }
} 