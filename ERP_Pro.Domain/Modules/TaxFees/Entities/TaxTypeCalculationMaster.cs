using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;
namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxTypeCalculationMaster Entity
/// </summary>
public class TaxTypeCalculationMaster : AggregateRoot<TaxTypeCalculationMasterId>
{

    private TaxTypeCalculationMaster() { }

    public TaxTypeCalculationMaster(TaxTypeCalculationMasterId id, decimal? calcTypeNumber)
    {
        Id = id;
        CalcTypeNumber = calcTypeNumber;
    }

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

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

