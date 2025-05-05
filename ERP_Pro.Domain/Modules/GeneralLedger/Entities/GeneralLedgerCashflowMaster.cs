using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerCashflowMaster Entity
/// </summary>
public class GeneralLedgerCashflowMaster : AggregateRoot<GeneralLedgerCashflowMasterId>
{

    private GeneralLedgerCashflowMaster() { }

    public GeneralLedgerCashflowMaster(GeneralLedgerCashflowMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowMaster
    /// المعرف الفريد لـ GeneralLedgerCashflowMaster
    /// </summary>
    public GeneralLedgerCashflowMasterId Id { get; private set; }

    /// <summary>
    /// CashFlowType of the GeneralLedgerCashflowMaster
    /// CashFlowType الخاص بـ GeneralLedgerCashflowMaster
    /// </summary>
    public decimal? CashFlowType { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerCashflowMaster
    /// DocNo الخاص بـ GeneralLedgerCashflowMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the GeneralLedgerCashflowMaster
    /// DocDate الخاص بـ GeneralLedgerCashflowMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerCashflowMaster
    /// DocSer الخاص بـ GeneralLedgerCashflowMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// CashFlowName of the GeneralLedgerCashflowMaster
    /// CashFlowName الخاص بـ GeneralLedgerCashflowMaster
    /// </summary>
    public string CashFlowName { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerCashflowMaster
    /// ReferenceNumber الخاص بـ GeneralLedgerCashflowMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDesc of the GeneralLedgerCashflowMaster
    /// DocDesc الخاص بـ GeneralLedgerCashflowMaster
    /// </summary>
    public string DocDesc { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

