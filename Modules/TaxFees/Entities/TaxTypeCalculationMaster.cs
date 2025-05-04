using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxTypeCalculationMaster Entity
/// </summary>
public class TaxTypeCalculationMaster : Entity<TaxTypeCalculationMasterId>
{
    private TaxTypeCalculationMaster() { }

    /// <summary>
    /// The unique identifier for the TaxTypeCalculationMaster
    /// المعرف الفريد لـ TaxTypeCalculationMaster
    /// </summary>
    public TaxTypeCalculationMasterId Id { get; private set; }

    /// <summary>
    /// CalcTypeNumber of the TaxTypeCalculationMaster
    /// CalcTypeNumber الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? CalcTypeNumber { get; private set; }

    /// <summary>
    /// CalcTypeLastName of the TaxTypeCalculationMaster
    /// CalcTypeLastName الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public string CalcTypeLastName { get; private set; }

    /// <summary>
    /// CalcTypeFirstName of the TaxTypeCalculationMaster
    /// CalcTypeFirstName الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public string CalcTypeFirstName { get; private set; }

    /// <summary>
    /// CalcTypeDefaultFlag of the TaxTypeCalculationMaster
    /// CalcTypeDefaultFlag الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? CalcTypeDefaultFlag { get; private set; }

    /// <summary>
    /// CalcTaxType of the TaxTypeCalculationMaster
    /// CalcTaxType الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? CalcTaxType { get; private set; }

    /// <summary>
    /// PurchaseExpense of the TaxTypeCalculationMaster
    /// PurchaseExpense الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? PurchaseExpense { get; private set; }

    /// <summary>
    /// FixedAssetSystemFlag of the TaxTypeCalculationMaster
    /// FixedAssetSystemFlag الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? FixedAssetSystemFlag { get; private set; }

    /// <summary>
    /// RemarkSystemFlag of the TaxTypeCalculationMaster
    /// RemarkSystemFlag الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? RemarkSystemFlag { get; private set; }

    /// <summary>
    /// PmsSystemFlag of the TaxTypeCalculationMaster
    /// PmsSystemFlag الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? PmsSystemFlag { get; private set; }

    /// <summary>
    /// CalcTypeNumberExempt of the TaxTypeCalculationMaster
    /// CalcTypeNumberExempt الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? CalcTypeNumberExempt { get; private set; }

    /// <summary>
    /// InactiveFlag of the TaxTypeCalculationMaster
    /// InactiveFlag الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the TaxTypeCalculationMaster
    /// InactivatedByUserId الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the TaxTypeCalculationMaster
    /// InactiveDate الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the TaxTypeCalculationMaster
    /// InactiveReason الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// TransactionPeriod of the TaxTypeCalculationMaster
    /// TransactionPeriod الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? TransactionPeriod { get; private set; }

    /// <summary>
    /// CalcTypeNumberTransport of the TaxTypeCalculationMaster
    /// CalcTypeNumberTransport الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public decimal? CalcTypeNumberTransport { get; private set; }

    /// <summary>
    /// TaxCode of the TaxTypeCalculationMaster
    /// TaxCode الخاص بـ TaxTypeCalculationMaster
    /// </summary>
    public string TaxCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to RequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<RequestTaxItemMovement> RequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to BranchRequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchRequestTaxItemMovement> BranchRequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to TaxInputMovement
    /// </summary>
    public IReadOnlyCollection<TaxInputMovement> TaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to BranchTaxInputMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxInputMovement> BranchTaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to TaxItemMovement
    /// </summary>
    public IReadOnlyCollection<TaxItemMovement> TaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to BranchTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxItemMovement> BranchTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to TaxTypeCalculationBranch
    /// </summary>
    public IReadOnlyCollection<TaxTypeCalculationBranch> TaxTypeCalculationBranches { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to TaxTypeCalculationDetail
    /// </summary>
    public IReadOnlyCollection<TaxTypeCalculationDetail> TaxTypeCalculationDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxTypeCalculationMaster to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    #endregion
}
}
