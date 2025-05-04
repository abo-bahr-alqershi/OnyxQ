using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxTypeCalculationBranch Entity
/// </summary>
public class TaxTypeCalculationBranch : Entity<TaxTypeCalculationBranchId>
{
    private TaxTypeCalculationBranch() { }

    /// <summary>
    /// The unique identifier for the TaxTypeCalculationBranch
    /// المعرف الفريد لـ TaxTypeCalculationBranch
    /// </summary>
    public TaxTypeCalculationBranchId Id { get; private set; }

    /// <summary>
    /// CalcTypeNumber of the TaxTypeCalculationBranch
    /// CalcTypeNumber الخاص بـ TaxTypeCalculationBranch
    /// </summary>
    public decimal? CalcTypeNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the TaxTypeCalculationBranch
    /// BranchNumber الخاص بـ TaxTypeCalculationBranch
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// ActivityDate of the TaxTypeCalculationBranch
    /// ActivityDate الخاص بـ TaxTypeCalculationBranch
    /// </summary>
    public DateTime? ActivityDate { get; private set; }

    /// <summary>
    /// ExpirationDate of the TaxTypeCalculationBranch
    /// ExpirationDate الخاص بـ TaxTypeCalculationBranch
    /// </summary>
    public DateTime? ExpirationDate { get; private set; }

    /// <summary>
    /// TransactionPeriod of the TaxTypeCalculationBranch
    /// TransactionPeriod الخاص بـ TaxTypeCalculationBranch
    /// </summary>
    public decimal? TransactionPeriod { get; private set; }

    /// <summary>
    /// StartTransportPeriod of the TaxTypeCalculationBranch
    /// StartTransportPeriod الخاص بـ TaxTypeCalculationBranch
    /// </summary>
    public DateTime? StartTransportPeriod { get; private set; }

    /// <summary>
    /// EndTransportPeriod of the TaxTypeCalculationBranch
    /// EndTransportPeriod الخاص بـ TaxTypeCalculationBranch
    /// </summary>
    public DateTime? EndTransportPeriod { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Branch
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// ManyToOne relationship to TaxTypeCalculationMaster
    /// </summary>
    public TaxTypeCalculationMaster TaxTypeCalculationMaster { get; private set; }
    #endregion
}
}
