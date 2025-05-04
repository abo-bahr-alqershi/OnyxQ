using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// ColumnDetailGeneralLedger Entity
/// </summary>
public class ColumnDetailGeneralLedger : Entity<ColumnDetailGeneralLedgerId>
{

    private ColumnDetailGeneralLedger() { }

    public ColumnDetailGeneralLedger(ColumnDetailGeneralLedgerId id, string columnChar, string columnCode)
    {
        Id = id;
        ColumnChar = columnChar;
        ColumnCode = columnCode;
    }

    /// <summary>
    /// The unique identifier for the ColumnDetailGeneralLedger
    /// المعرف الفريد لـ ColumnDetailGeneralLedger
    /// </summary>
    public ColumnDetailGeneralLedgerId Id { get; private set; }

    /// <summary>
    /// ColumnNumber of the ColumnDetailGeneralLedger
    /// ColumnNumber الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public decimal? ColumnNumber { get; private set; }

    /// <summary>
    /// LabelNumber of the ColumnDetailGeneralLedger
    /// LabelNumber الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public decimal? LabelNumber { get; private set; }

    /// <summary>
    /// ColumnChar of the ColumnDetailGeneralLedger
    /// ColumnChar الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public string ColumnChar { get; private set; }

    /// <summary>
    /// ColumnCode of the ColumnDetailGeneralLedger
    /// ColumnCode الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public string ColumnCode { get; private set; }

    /// <summary>
    /// ColumnName of the ColumnDetailGeneralLedger
    /// ColumnName الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public string ColumnName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ColumnDetailGeneralLedger
    /// CompanyNumberShort الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ColumnDetailGeneralLedger
    /// BranchNumber الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ColumnDetailGeneralLedger
    /// BranchYear الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ColumnDetailGeneralLedger
    /// BranchUser الخاص بـ ColumnDetailGeneralLedger
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
