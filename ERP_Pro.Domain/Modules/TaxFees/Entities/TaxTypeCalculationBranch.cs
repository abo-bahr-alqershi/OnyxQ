using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;
namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxTypeCalculationBranch Entity
/// </summary>
public class TaxTypeCalculationBranch : Entity<TaxTypeCalculationBranchId>
{

    private TaxTypeCalculationBranch() { }

    public TaxTypeCalculationBranch(TaxTypeCalculationBranchId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TaxTypeCalculationBranch
    /// المعرف الفريد لـ TaxTypeCalculationBranch
    /// </summary>
    public TaxTypeCalculationBranchId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public TaxTypeCalculationMaster TaxTypeCalculationMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

