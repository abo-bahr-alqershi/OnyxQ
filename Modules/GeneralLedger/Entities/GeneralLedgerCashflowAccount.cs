using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerCashflowAccount Entity
/// </summary>
public class GeneralLedgerCashflowAccount : Entity<GeneralLedgerCashflowAccountId>
{
    private GeneralLedgerCashflowAccount() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowAccount
    /// المعرف الفريد لـ GeneralLedgerCashflowAccount
    /// </summary>
    public GeneralLedgerCashflowAccountId Id { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerCashflowAccount
    /// AccountCode الخاص بـ GeneralLedgerCashflowAccount
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// RecordNumberDetail of the GeneralLedgerCashflowAccount
    /// RecordNumberDetail الخاص بـ GeneralLedgerCashflowAccount
    /// </summary>
    public decimal? RecordNumberDetail { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerCashflowAccount
    /// DocNo الخاص بـ GeneralLedgerCashflowAccount
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerCashflowAccount
    /// DocSer الخاص بـ GeneralLedgerCashflowAccount
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AccountAnalysis of the GeneralLedgerCashflowAccount
    /// AccountAnalysis الخاص بـ GeneralLedgerCashflowAccount
    /// </summary>
    public decimal? AccountAnalysis { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerCashflowAccount
    /// RecordNumber الخاص بـ GeneralLedgerCashflowAccount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerCashflowDetail
    /// </summary>
    public GeneralLedgerCashflowDetail GeneralLedgerCashflowDetail { get; private set; }
    /// <summary>
    /// One-to-many relationship: GeneralLedgerCashflowAccount to GeneralLedgerCashflowField
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerCashflowField> GeneralLedgerCashflowFields { get; private set; }
    #endregion
}
}
