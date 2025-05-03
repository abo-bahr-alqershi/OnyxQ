using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a report extra parameters master is created
/// حدث يتم رفعه عند إنشاء رئيسي معلمات التقرير الإضافية
/// </summary>
public class ReportExtraParametersMasterCreated : DomainEvent
{
    public ReportExtraParametersMaster Master { get; }

    public ReportExtraParametersMasterCreated(ReportExtraParametersMaster master)
    {
        Master = master;
    }
}

/// <summary>
/// Event raised when a report extra parameters master is updated
/// حدث يتم رفعه عند تحديث رئيسي معلمات التقرير الإضافية
/// </summary>
public class ReportExtraParametersMasterUpdated : DomainEvent
{
    public ReportExtraParametersMaster Master { get; }

    public ReportExtraParametersMasterUpdated(ReportExtraParametersMaster master)
    {
        Master = master;
    }
}

/// <summary>
/// Event raised when a report extra parameters master is deleted
/// حدث يتم رفعه عند حذف رئيسي معلمات التقرير الإضافية
/// </summary>
public class ReportExtraParametersMasterDeleted : DomainEvent
{
    public ReportExtraParametersMaster Master { get; }

    public ReportExtraParametersMasterDeleted(ReportExtraParametersMaster master)
    {
        Master = master;
    }
} 