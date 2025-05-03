using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a new log check before close record is created
/// حدث يتم رفعه عند إنشاء سجل تحقق جديد قبل الإغلاق
/// </summary>
public class LogCheckBeforeCloseCreatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the log check record
    /// سجل التحقق
    /// </summary>
    public LogCheckBeforeClose LogCheck { get; }

    public LogCheckBeforeCloseCreatedEvent(LogCheckBeforeClose logCheck)
    {
        LogCheck = logCheck;
    }
}

/// <summary>
/// Event raised when a log check before close record is updated
/// حدث يتم رفعه عند تحديث سجل التحقق قبل الإغلاق
/// </summary>
public class LogCheckBeforeCloseUpdatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the log check record
    /// سجل التحقق
    /// </summary>
    public LogCheckBeforeClose LogCheck { get; }

    public LogCheckBeforeCloseUpdatedEvent(LogCheckBeforeClose logCheck)
    {
        LogCheck = logCheck;
    }
}

/// <summary>
/// Event raised when a log check before close report details are updated
/// حدث يتم رفعه عند تحديث تفاصيل تقرير سجل التحقق قبل الإغلاق
/// </summary>
public class LogCheckBeforeCloseReportUpdatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the log check record
    /// سجل التحقق
    /// </summary>
    public LogCheckBeforeClose LogCheck { get; }

    public LogCheckBeforeCloseReportUpdatedEvent(LogCheckBeforeClose logCheck)
    {
        LogCheck = logCheck;
    }
} 