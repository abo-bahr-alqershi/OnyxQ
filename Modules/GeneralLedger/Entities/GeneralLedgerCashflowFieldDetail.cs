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
    /// RecordNumberField of the GeneralLedgerCashflowFieldDetail
    /// RecordNumberField الخاص بـ GeneralLedgerCashflowFieldDetail
    /// </summary>
    public decimal? RecordNumberField { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerCashflowFieldDetail
    /// DocNo الخاص بـ GeneralLedgerCashflowFieldDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerCashflowFieldDetail
    /// DocSer الخاص بـ GeneralLedgerCashflowFieldDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// RecordNumberDetail of the GeneralLedgerCashflowFieldDetail
    /// RecordNumberDetail الخاص بـ GeneralLedgerCashflowFieldDetail
    /// </summary>
    public decimal? RecordNumberDetail { get; private set; }

    /// <summary>
    /// RecordNumberAccount of the GeneralLedgerCashflowFieldDetail
    /// RecordNumberAccount الخاص بـ GeneralLedgerCashflowFieldDetail
    /// </summary>
    public decimal? RecordNumberAccount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerCashflowField
    /// </summary>
    public GeneralLedgerCashflowField GeneralLedgerCashflowField { get; private set; }
    #endregion
}
}
