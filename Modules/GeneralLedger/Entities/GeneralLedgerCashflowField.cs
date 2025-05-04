using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerCashflowField Entity
/// </summary>
public class GeneralLedgerCashflowField : Entity<GeneralLedgerCashflowFieldId>
{
    private GeneralLedgerCashflowField() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowField
    /// المعرف الفريد لـ GeneralLedgerCashflowField
    /// </summary>
    public GeneralLedgerCashflowFieldId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerCashflowField
    /// RecordNumber الخاص بـ GeneralLedgerCashflowField
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// FieldNameShort of the GeneralLedgerCashflowField
    /// FieldNameShort الخاص بـ GeneralLedgerCashflowField
    /// </summary>
    public string FieldNameShort { get; private set; }

    /// <summary>
    /// RecordNumberAccount of the GeneralLedgerCashflowField
    /// RecordNumberAccount الخاص بـ GeneralLedgerCashflowField
    /// </summary>
    public decimal? RecordNumberAccount { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerCashflowField
    /// DocNo الخاص بـ GeneralLedgerCashflowField
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerCashflowField
    /// DocSer الخاص بـ GeneralLedgerCashflowField
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// RecordNumberDetail of the GeneralLedgerCashflowField
    /// RecordNumberDetail الخاص بـ GeneralLedgerCashflowField
    /// </summary>
    public decimal? RecordNumberDetail { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerCashflowAccount
    /// </summary>
    public GeneralLedgerCashflowAccount GeneralLedgerCashflowAccount { get; private set; }
    /// <summary>
    /// One-to-many relationship: GeneralLedgerCashflowField to GeneralLedgerCashflowFieldDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerCashflowFieldDetail> GeneralLedgerCashflowFieldDetails { get; private set; }
    #endregion
}
}
