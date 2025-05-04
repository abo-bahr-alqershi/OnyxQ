using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// PeriodDetail Entity
/// </summary>
public class PeriodDetail : Entity<PeriodDetailId>
{

    private PeriodDetail() { }

    public PeriodDetail(PeriodDetailId id, decimal? periodNumberShort)
    {
        Id = id;
        PeriodNumberShort = periodNumberShort;
    }

    /// <summary>
    /// The unique identifier for the PeriodDetail
    /// المعرف الفريد لـ PeriodDetail
    /// </summary>
    public PeriodDetailId Id { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the PeriodDetail
    /// PeriodNumberShort الخاص بـ PeriodDetail
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// PeriodLastName of the PeriodDetail
    /// PeriodLastName الخاص بـ PeriodDetail
    /// </summary>
    public string PeriodLastName { get; private set; }

    /// <summary>
    /// PeriodFirstName of the PeriodDetail
    /// PeriodFirstName الخاص بـ PeriodDetail
    /// </summary>
    public string PeriodFirstName { get; private set; }

    /// <summary>
    /// FDate of the PeriodDetail
    /// FDate الخاص بـ PeriodDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the PeriodDetail
    /// TDate الخاص بـ PeriodDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// YearNumber of the PeriodDetail
    /// YearNumber الخاص بـ PeriodDetail
    /// </summary>
    public decimal? YearNumber { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the PeriodDetail
    /// InactiveFlagAlt الخاص بـ PeriodDetail
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// PeriodSeason of the PeriodDetail
    /// PeriodSeason الخاص بـ PeriodDetail
    /// </summary>
    public decimal? PeriodSeason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PeriodMaster PeriodMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
