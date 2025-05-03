using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a report extra parameters detail is created
/// حدث يتم رفعه عند إنشاء تفاصيل معلمات التقرير الإضافية
/// </summary>
public class ReportExtraParametersDetailCreated : DomainEvent
{
    public ReportExtraParametersDetail Detail { get; }

    public ReportExtraParametersDetailCreated(ReportExtraParametersDetail detail)
    {
        Detail = detail;
    }
}

/// <summary>
/// Event raised when a report extra parameters detail is updated
/// حدث يتم رفعه عند تحديث تفاصيل معلمات التقرير الإضافية
/// </summary>
public class ReportExtraParametersDetailUpdated : DomainEvent
{
    public ReportExtraParametersDetail Detail { get; }

    public ReportExtraParametersDetailUpdated(ReportExtraParametersDetail detail)
    {
        Detail = detail;
    }
}

/// <summary>
/// Event raised when a report extra parameters detail is deleted
/// حدث يتم رفعه عند حذف تفاصيل معلمات التقرير الإضافية
/// </summary>
public class ReportExtraParametersDetailDeleted : DomainEvent
{
    public ReportExtraParametersDetail Detail { get; }

    public ReportExtraParametersDetailDeleted(ReportExtraParametersDetail detail)
    {
        Detail = detail;
    }
} 