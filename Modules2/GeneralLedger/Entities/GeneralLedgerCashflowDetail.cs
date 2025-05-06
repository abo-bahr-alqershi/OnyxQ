using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerCashflowDetail Entity
/// </summary>
public class GeneralLedgerCashflowDetail : Entity<GeneralLedgerCashflowDetailId>
{

    private GeneralLedgerCashflowDetail() { }

    public GeneralLedgerCashflowDetail(GeneralLedgerCashflowDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowDetail
    /// المعرف الفريد لـ GeneralLedgerCashflowDetail
    /// </summary>
    public GeneralLedgerCashflowDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerCashflowDetail
    /// RecordNumber الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordName of the GeneralLedgerCashflowDetail
    /// RecordName الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string RecordName { get; private set; }

    /// <summary>
    /// RecordFirstName of the GeneralLedgerCashflowDetail
    /// RecordFirstName الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string RecordFirstName { get; private set; }

    /// <summary>
    /// RecordCalculation of the GeneralLedgerCashflowDetail
    /// RecordCalculation الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string RecordCalculation { get; private set; }

    /// <summary>
    /// RecordReference of the GeneralLedgerCashflowDetail
    /// RecordReference الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string RecordReference { get; private set; }

    /// <summary>
    /// RecordDescription of the GeneralLedgerCashflowDetail
    /// RecordDescription الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string RecordDescription { get; private set; }

    /// <summary>
    /// RecordOrder of the GeneralLedgerCashflowDetail
    /// RecordOrder الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public decimal? RecordOrder { get; private set; }

    /// <summary>
    /// RecordConnectionType of the GeneralLedgerCashflowDetail
    /// RecordConnectionType الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public decimal? RecordConnectionType { get; private set; }

    /// <summary>
    /// RecordFormula of the GeneralLedgerCashflowDetail
    /// RecordFormula الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string RecordFormula { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerCashflowDetail
    /// DocNo الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// UseDocumentType of the GeneralLedgerCashflowDetail
    /// UseDocumentType الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public decimal? UseDocumentType { get; private set; }

    /// <summary>
    /// SelectDocumentTypeShort of the GeneralLedgerCashflowDetail
    /// SelectDocumentTypeShort الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string SelectDocumentTypeShort { get; private set; }

    /// <summary>
    /// RecordFormulaDescription of the GeneralLedgerCashflowDetail
    /// RecordFormulaDescription الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string RecordFormulaDescription { get; private set; }

    /// <summary>
    /// FactorType of the GeneralLedgerCashflowDetail
    /// FactorType الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public decimal? FactorType { get; private set; }

    /// <summary>
    /// HideFlag of the GeneralLedgerCashflowDetail
    /// HideFlag الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public decimal? HideFlag { get; private set; }

    /// <summary>
    /// FontSize of the GeneralLedgerCashflowDetail
    /// FontSize الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public decimal? FontSize { get; private set; }

    /// <summary>
    /// FontColor of the GeneralLedgerCashflowDetail
    /// FontColor الخاص بـ GeneralLedgerCashflowDetail
    /// </summary>
    public string FontColor { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerCashflowMaster GeneralLedgerCashflowMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

