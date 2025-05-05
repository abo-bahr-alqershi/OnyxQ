using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerCashflowTemp Entity
/// </summary>
public class GeneralLedgerCashflowTemp : Entity<GeneralLedgerCashflowTempId>
{

    private GeneralLedgerCashflowTemp() { }

    public GeneralLedgerCashflowTemp(GeneralLedgerCashflowTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowTemp
    /// المعرف الفريد لـ GeneralLedgerCashflowTemp
    /// </summary>
    public GeneralLedgerCashflowTempId Id { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerCashflowTemp
    /// DocSer الخاص بـ GeneralLedgerCashflowTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerCashflowTemp
    /// RecordNumber الخاص بـ GeneralLedgerCashflowTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PeriodShort of the GeneralLedgerCashflowTemp
    /// PeriodShort الخاص بـ GeneralLedgerCashflowTemp
    /// </summary>
    public string PeriodShort { get; private set; }

    /// <summary>
    /// FieldGroup of the GeneralLedgerCashflowTemp
    /// FieldGroup الخاص بـ GeneralLedgerCashflowTemp
    /// </summary>
    public string FieldGroup { get; private set; }

    /// <summary>
    /// BalanceAmount of the GeneralLedgerCashflowTemp
    /// BalanceAmount الخاص بـ GeneralLedgerCashflowTemp
    /// </summary>
    public decimal? BalanceAmount { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

