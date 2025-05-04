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

    /// <summary>
    /// The unique identifier for the TaxTypeCalculationDetail
    /// المعرف الفريد لـ TaxTypeCalculationDetail
    /// </summary>
    public TaxTypeCalculationDetailId Id { get; private set; }

    /// <summary>
    /// CalcTypeNumber of the TaxTypeCalculationDetail
    /// CalcTypeNumber الخاص بـ TaxTypeCalculationDetail
    /// </summary>
    public decimal? CalcTypeNumber { get; private set; }

    /// <summary>
    /// TaxNumber of the TaxTypeCalculationDetail
    /// TaxNumber الخاص بـ TaxTypeCalculationDetail
    /// </summary>
    public decimal? TaxNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to TaxTypeCalculationMaster
    /// </summary>
    public TaxTypeCalculationMaster TaxTypeCalculationMaster { get; private set; }
    #endregion
}
}
