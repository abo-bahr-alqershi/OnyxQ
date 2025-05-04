using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// WeeklyReportTemp Entity
/// </summary>
public class WeeklyReportTemp : Entity<WeeklyReportTempId>
{

    private WeeklyReportTemp() { }

    public WeeklyReportTemp(WeeklyReportTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the WeeklyReportTemp
    /// المعرف الفريد لـ WeeklyReportTemp
    /// </summary>
    public WeeklyReportTempId Id { get; private set; }

    /// <summary>
    /// FDate of the WeeklyReportTemp
    /// FDate الخاص بـ WeeklyReportTemp
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the WeeklyReportTemp
    /// TDate الخاص بـ WeeklyReportTemp
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the WeeklyReportTemp
    /// AccountCurrency الخاص بـ WeeklyReportTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WeeklyReportTemp
    /// CompanyNumberShort الخاص بـ WeeklyReportTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WeeklyReportTemp
    /// BranchNumber الخاص بـ WeeklyReportTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WeeklyReportTemp
    /// BranchYear الخاص بـ WeeklyReportTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WeeklyReportTemp
    /// BranchUser الخاص بـ WeeklyReportTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
