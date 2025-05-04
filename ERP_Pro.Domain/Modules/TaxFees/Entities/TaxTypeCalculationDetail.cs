using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxTypeCalculationDetail Entity
/// </summary>
public class TaxTypeCalculationDetail : Entity<TaxTypeCalculationDetailId>
{

    private TaxTypeCalculationDetail() { }

    public TaxTypeCalculationDetail(TaxTypeCalculationDetailId id, decimal? taxNumber)
    {
        Id = id;
        TaxNumber = taxNumber;
    }

    /// <summary>
    /// The unique identifier for the TaxTypeCalculationDetail
    /// المعرف الفريد لـ TaxTypeCalculationDetail
    /// </summary>
    public TaxTypeCalculationDetailId Id { get; private set; }

    /// <summary>
    /// TaxNumber of the TaxTypeCalculationDetail
    /// TaxNumber الخاص بـ TaxTypeCalculationDetail
    /// </summary>
    public decimal? TaxNumber { get; private set; }

    #region Navigation Properties
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
