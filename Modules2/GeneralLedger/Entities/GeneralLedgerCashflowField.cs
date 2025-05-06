using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerCashflowField Entity
/// </summary>
public class GeneralLedgerCashflowField : Entity<GeneralLedgerCashflowFieldId>
{

    private GeneralLedgerCashflowField() { }

    public GeneralLedgerCashflowField(GeneralLedgerCashflowFieldId id)
    {
        Id = id;
    }

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
    /// DocNo of the GeneralLedgerCashflowField
    /// DocNo الخاص بـ GeneralLedgerCashflowField
    /// </summary>
    public decimal? DocNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerCashflowAccount GeneralLedgerCashflowAccount { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

