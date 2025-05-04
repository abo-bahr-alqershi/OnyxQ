using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// SystemLog Entity
/// </summary>
public class SystemLog : Entity<SystemLogId>
{
    private SystemLog() { }

    /// <summary>
    /// The unique identifier for the SystemLog
    /// المعرف الفريد لـ SystemLog
    /// </summary>
    public SystemLogId Id { get; private set; }

    /// <summary>
    /// FormNumber of the SystemLog
    /// FormNumber الخاص بـ SystemLog
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// LogCount of the SystemLog
    /// LogCount الخاص بـ SystemLog
    /// </summary>
    public decimal? LogCount { get; private set; }

    /// <summary>
    /// LogDescription of the SystemLog
    /// LogDescription الخاص بـ SystemLog
    /// </summary>
    public string LogDescription { get; private set; }
}
}
