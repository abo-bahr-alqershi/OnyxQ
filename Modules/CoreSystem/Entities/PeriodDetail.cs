using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// PeriodDetail Entity
/// </summary>
public class PeriodDetail : Entity<PeriodDetailId>
{
    private PeriodDetail() { }

    /// <summary>
    /// The unique identifier for the PeriodDetail
    /// المعرف الفريد لـ PeriodDetail
    /// </summary>
    public PeriodDetailId Id { get; private set; }

    /// <summary>
    /// PeriodTypeShort of the PeriodDetail
    /// PeriodTypeShort الخاص بـ PeriodDetail
    /// </summary>
    public decimal? PeriodTypeShort { get; private set; }

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
    /// One-to-many relationship: PeriodDetail to PeriodDay
    /// </summary>
    public IReadOnlyCollection<PeriodDay> PeriodDaies { get; private set; }
    /// <summary>
    /// ManyToOne relationship to PeriodMaster
    /// </summary>
    public PeriodMaster PeriodMaster { get; private set; }
    /// <summary>
    /// One-to-many relationship: PeriodDetail to PeriodExchangeRate
    /// </summary>
    public IReadOnlyCollection<PeriodExchangeRate> PeriodExchangeRates { get; private set; }
    /// <summary>
    /// One-to-many relationship: PeriodDetail to PostDetail
    /// </summary>
    public IReadOnlyCollection<PostDetail> PostDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: PeriodDetail to PostMaster
    /// </summary>
    public IReadOnlyCollection<PostMaster> PostMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: PeriodDetail to CollectionPlan
    /// </summary>
    public IReadOnlyCollection<CollectionPlan> CollectionPlans { get; private set; }
    #endregion
}
}
