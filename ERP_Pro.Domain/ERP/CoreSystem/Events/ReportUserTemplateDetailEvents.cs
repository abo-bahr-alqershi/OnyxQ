using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a report user template detail is created
/// حدث يتم رفعه عند إنشاء تفاصيل قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateDetailCreatedEvent : DomainEvent
{
    public ReportUserTemplateDetail TemplateDetail { get; }

    public ReportUserTemplateDetailCreatedEvent(ReportUserTemplateDetail templateDetail)
    {
        TemplateDetail = templateDetail;
    }
}

/// <summary>
/// Event raised when a report user template detail is updated
/// حدث يتم رفعه عند تحديث تفاصيل قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateDetailUpdatedEvent : DomainEvent
{
    public ReportUserTemplateDetail TemplateDetail { get; }

    public ReportUserTemplateDetailUpdatedEvent(ReportUserTemplateDetail templateDetail)
    {
        TemplateDetail = templateDetail;
    }
}

/// <summary>
/// Event raised when a report user template detail is deleted
/// حدث يتم رفعه عند حذف تفاصيل قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateDetailDeletedEvent : DomainEvent
{
    public ReportUserTemplateDetail TemplateDetail { get; }

    public ReportUserTemplateDetailDeletedEvent(ReportUserTemplateDetail templateDetail)
    {
        TemplateDetail = templateDetail;
    }
} 