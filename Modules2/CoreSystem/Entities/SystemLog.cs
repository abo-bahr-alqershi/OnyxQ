using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// كيان يمثل سجل النظام ويحتوي على تفاصيل الأحداث والعمليات المنفذة.
/// </summary>
public class SystemLog : Entity<SystemLogId>
{

    private SystemLog() { }

    public SystemLog(SystemLogId id)
    {
        Id = id;
    }

    /// <summary>
    /// المعرف الفريد لسجل النظام (مفتاح رئيسي).
    /// </summary>
    public SystemLogId Id { get; private set; }

    /// <summary>
    /// رقم النموذج المرتبط بالسجل.
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// عدد السجلات.
    /// </summary>
    public decimal? LogCount { get; private set; }

    /// <summary>
    /// وصف السجل.
    /// </summary>
    public string LogDescription { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
