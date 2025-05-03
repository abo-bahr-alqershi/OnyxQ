using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a YearReMoveDataDetail is created
/// حدث يتم رفعه عند إنشاء تفاصيل نقل بيانات السنة
/// </summary>
public class YearReMoveDataDetailCreated : DomainEvent
{
    /// <summary>
    /// Gets the YearReMoveDataDetail entity
    /// كيان تفاصيل نقل بيانات السنة
    /// </summary>
    public YearReMoveDataDetail YearReMoveDataDetail { get; }

    public YearReMoveDataDetailCreated(YearReMoveDataDetail yearReMoveDataDetail)
    {
        YearReMoveDataDetail = yearReMoveDataDetail;
    }
}

/// <summary>
/// Event raised when a YearReMoveDataDetail is updated
/// حدث يتم رفعه عند تحديث تفاصيل نقل بيانات السنة
/// </summary>
public class YearReMoveDataDetailUpdated : DomainEvent
{
    /// <summary>
    /// Gets the YearReMoveDataDetail entity
    /// كيان تفاصيل نقل بيانات السنة
    /// </summary>
    public YearReMoveDataDetail YearReMoveDataDetail { get; }

    public YearReMoveDataDetailUpdated(YearReMoveDataDetail yearReMoveDataDetail)
    {
        YearReMoveDataDetail = yearReMoveDataDetail;
    }
}

/// <summary>
/// Event raised when a YearReMoveDataDetail is deleted
/// حدث يتم رفعه عند حذف تفاصيل نقل بيانات السنة
/// </summary>
public class YearReMoveDataDetailDeleted : DomainEvent
{
    /// <summary>
    /// Gets the YearReMoveDataDetail entity
    /// كيان تفاصيل نقل بيانات السنة
    /// </summary>
    public YearReMoveDataDetail YearReMoveDataDetail { get; }

    public YearReMoveDataDetailDeleted(YearReMoveDataDetail yearReMoveDataDetail)
    {
        YearReMoveDataDetail = yearReMoveDataDetail;
    }
} 