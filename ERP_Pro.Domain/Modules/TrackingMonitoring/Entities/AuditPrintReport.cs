using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;
namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditPrintReport Entity
/// </summary>
public class AuditPrintReport : Entity<AuditPrintReportId>
{

    private AuditPrintReport() { }

    public AuditPrintReport(AuditPrintReportId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AuditPrintReport
    /// المعرف الفريد لـ AuditPrintReport
    /// </summary>
    public AuditPrintReportId Id { get; private set; }

    /// <summary>
    /// FormNumber of the AuditPrintReport
    /// FormNumber الخاص بـ AuditPrintReport
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// RepNameShort of the AuditPrintReport
    /// RepNameShort الخاص بـ AuditPrintReport
    /// </summary>
    public string RepNameShort { get; private set; }

    /// <summary>
    /// AuditUserId of the AuditPrintReport
    /// AuditUserId الخاص بـ AuditPrintReport
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the AuditPrintReport
    /// AuditDate الخاص بـ AuditPrintReport
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// TerminalName of the AuditPrintReport
    /// TerminalName الخاص بـ AuditPrintReport
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditPrintReport
    /// CompanyNumberShort الخاص بـ AuditPrintReport
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditPrintReport
    /// BranchNumber الخاص بـ AuditPrintReport
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the AuditPrintReport
    /// BranchUser الخاص بـ AuditPrintReport
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the AuditPrintReport
    /// BranchYear الخاص بـ AuditPrintReport
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// RepWhere of the AuditPrintReport
    /// RepWhere الخاص بـ AuditPrintReport
    /// </summary>
    public string RepWhere { get; private set; }

    /// <summary>
    /// RepTitle of the AuditPrintReport
    /// RepTitle الخاص بـ AuditPrintReport
    /// </summary>
    public string RepTitle { get; private set; }

    /// <summary>
    /// RepWhere1 of the AuditPrintReport
    /// RepWhere1 الخاص بـ AuditPrintReport
    /// </summary>
    public string RepWhere1 { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

