using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
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
    /// FSystem of the SystemLog
    /// FSystem الخاص بـ SystemLog
    /// </summary>
    public string FSystem { get; private set; }

    /// <summary>
    /// DocType of the SystemLog
    /// DocType الخاص بـ SystemLog
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocSer of the SystemLog
    /// DocSer الخاص بـ SystemLog
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the SystemLog
    /// DocDate الخاص بـ SystemLog
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// LogDate of the SystemLog
    /// LogDate الخاص بـ SystemLog
    /// </summary>
    public DateTime? LogDate { get; private set; }

    /// <summary>
    /// LogDescription of the SystemLog
    /// LogDescription الخاص بـ SystemLog
    /// </summary>
    public string LogDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SystemLog
    /// CompanyNumberShort الخاص بـ SystemLog
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SystemLog
    /// BranchNumber الخاص بـ SystemLog
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SystemLog
    /// BranchYear الخاص بـ SystemLog
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SystemLog
    /// BranchUser الخاص بـ SystemLog
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
