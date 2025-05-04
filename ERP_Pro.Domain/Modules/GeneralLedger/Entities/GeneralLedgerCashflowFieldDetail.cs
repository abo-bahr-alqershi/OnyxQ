using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerCashflowFieldDetail Entity
/// </summary>
public class GeneralLedgerCashflowFieldDetail : Entity<GeneralLedgerCashflowFieldDetailId>
{

    private GeneralLedgerCashflowFieldDetail() { }

    public GeneralLedgerCashflowFieldDetail(GeneralLedgerCashflowFieldDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowFieldDetail
    /// المعرف الفريد لـ GeneralLedgerCashflowFieldDetail
    /// </summary>
    public GeneralLedgerCashflowFieldDetailId Id { get; private set; }

    /// <summary>
    /// FieldValue of the GeneralLedgerCashflowFieldDetail
    /// FieldValue الخاص بـ GeneralLedgerCashflowFieldDetail
    /// </summary>
    public string FieldValue { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerCashflowFieldDetail
    /// DocNo الخاص بـ GeneralLedgerCashflowFieldDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerCashflowField GeneralLedgerCashflowField { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
