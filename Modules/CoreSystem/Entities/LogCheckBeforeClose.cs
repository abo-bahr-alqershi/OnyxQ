using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// LogCheckBeforeClose Entity
/// </summary>
public class LogCheckBeforeClose : Entity<LogCheckBeforeCloseId>
{
    private LogCheckBeforeClose() { }

    /// <summary>
    /// The unique identifier for the LogCheckBeforeClose
    /// المعرف الفريد لـ LogCheckBeforeClose
    /// </summary>
    public LogCheckBeforeCloseId Id { get; private set; }

    /// <summary>
    /// MessageNumber of the LogCheckBeforeClose
    /// MessageNumber الخاص بـ LogCheckBeforeClose
    /// </summary>
    public decimal? MessageNumber { get; private set; }

    /// <summary>
    /// MessageTextFixed of the LogCheckBeforeClose
    /// MessageTextFixed الخاص بـ LogCheckBeforeClose
    /// </summary>
    public string MessageTextFixed { get; private set; }

    /// <summary>
    /// ReportNameShort of the LogCheckBeforeClose
    /// ReportNameShort الخاص بـ LogCheckBeforeClose
    /// </summary>
    public string ReportNameShort { get; private set; }

    /// <summary>
    /// ReportWhere of the LogCheckBeforeClose
    /// ReportWhere الخاص بـ LogCheckBeforeClose
    /// </summary>
    public string ReportWhere { get; private set; }
}
}
