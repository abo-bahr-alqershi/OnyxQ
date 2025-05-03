using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a report user template master is created
/// حدث يتم رفعه عند إنشاء رئيسي قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateMasterCreatedEvent : DomainEvent
{
    public ReportUserTemplateMaster TemplateMaster { get; }

    public ReportUserTemplateMasterCreatedEvent(ReportUserTemplateMaster templateMaster)
    {
        TemplateMaster = templateMaster;
    }
}

/// <summary>
/// Event raised when a report user template master is updated
/// حدث يتم رفعه عند تحديث رئيسي قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateMasterUpdatedEvent : DomainEvent
{
    public ReportUserTemplateMaster TemplateMaster { get; }

    public ReportUserTemplateMasterUpdatedEvent(ReportUserTemplateMaster templateMaster)
    {
        TemplateMaster = templateMaster;
    }
}

/// <summary>
/// Event raised when a report user template master is activated
/// حدث يتم رفعه عند تفعيل رئيسي قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateMasterActivatedEvent : DomainEvent
{
    public ReportUserTemplateMaster TemplateMaster { get; }

    public ReportUserTemplateMasterActivatedEvent(ReportUserTemplateMaster templateMaster)
    {
        TemplateMaster = templateMaster;
    }
}

/// <summary>
/// Event raised when a report user template master is deactivated
/// حدث يتم رفعه عند تعطيل رئيسي قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateMasterDeactivatedEvent : DomainEvent
{
    public ReportUserTemplateMaster TemplateMaster { get; }
    public string Reason { get; }
    public DateTime DeactivationDate { get; }

    public ReportUserTemplateMasterDeactivatedEvent(
        ReportUserTemplateMaster templateMaster,
        string reason,
        DateTime deactivationDate)
    {
        TemplateMaster = templateMaster;
        Reason = reason;
        DeactivationDate = deactivationDate;
    }
}

/// <summary>
/// Event raised when a report user template master is deleted
/// حدث يتم رفعه عند حذف رئيسي قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateMasterDeletedEvent : DomainEvent
{
    public ReportUserTemplateMaster TemplateMaster { get; }

    public ReportUserTemplateMasterDeletedEvent(ReportUserTemplateMaster templateMaster)
    {
        TemplateMaster = templateMaster;
    }
} 