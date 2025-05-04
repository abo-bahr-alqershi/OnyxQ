using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditHistory Entity
/// </summary>
public class AuditHistory : Entity<AuditHistoryId>
{

    private AuditHistory() { }

    public AuditHistory(AuditHistoryId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AuditHistory
    /// المعرف الفريد لـ AuditHistory
    /// </summary>
    public AuditHistoryId Id { get; private set; }

    /// <summary>
    /// OperatorType of the AuditHistory
    /// OperatorType الخاص بـ AuditHistory
    /// </summary>
    public decimal? OperatorType { get; private set; }

    /// <summary>
    /// OperatorSerial of the AuditHistory
    /// OperatorSerial الخاص بـ AuditHistory
    /// </summary>
    public decimal? OperatorSerial { get; private set; }

    /// <summary>
    /// FormNumber of the AuditHistory
    /// FormNumber الخاص بـ AuditHistory
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// TerminalName of the AuditHistory
    /// TerminalName الخاص بـ AuditHistory
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// TabNameShort of the AuditHistory
    /// TabNameShort الخاص بـ AuditHistory
    /// </summary>
    public string TabNameShort { get; private set; }

    /// <summary>
    /// ColumnNameShort of the AuditHistory
    /// ColumnNameShort الخاص بـ AuditHistory
    /// </summary>
    public string ColumnNameShort { get; private set; }

    /// <summary>
    /// OldValue of the AuditHistory
    /// OldValue الخاص بـ AuditHistory
    /// </summary>
    public string OldValue { get; private set; }

    /// <summary>
    /// NewValue of the AuditHistory
    /// NewValue الخاص بـ AuditHistory
    /// </summary>
    public string NewValue { get; private set; }

    /// <summary>
    /// ColumnPrimaryKey1 of the AuditHistory
    /// ColumnPrimaryKey1 الخاص بـ AuditHistory
    /// </summary>
    public string ColumnPrimaryKey1 { get; private set; }

    /// <summary>
    /// ColumnPrimaryKey2 of the AuditHistory
    /// ColumnPrimaryKey2 الخاص بـ AuditHistory
    /// </summary>
    public string ColumnPrimaryKey2 { get; private set; }

    /// <summary>
    /// ColumnPrimaryKey3 of the AuditHistory
    /// ColumnPrimaryKey3 الخاص بـ AuditHistory
    /// </summary>
    public string ColumnPrimaryKey3 { get; private set; }

    /// <summary>
    /// AuditUserId of the AuditHistory
    /// AuditUserId الخاص بـ AuditHistory
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the AuditHistory
    /// AuditDate الخاص بـ AuditHistory
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditHistory
    /// CompanyNumberShort الخاص بـ AuditHistory
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditHistory
    /// BranchNumber الخاص بـ AuditHistory
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the AuditHistory
    /// BranchUser الخاص بـ AuditHistory
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the AuditHistory
    /// BranchYear الخاص بـ AuditHistory
    /// </summary>
    public decimal? BranchYear { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
