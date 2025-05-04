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

    public GeneralLedgerCashflowAccount(GeneralLedgerCashflowAccountId id)
    {
        Id = id;
    }

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
    /// DocNo of the GeneralLedgerCashflowAccount
    /// DocNo الخاص بـ GeneralLedgerCashflowAccount
    /// </summary>
    public decimal? DocNo { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerCashflowDetail GeneralLedgerCashflowDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
