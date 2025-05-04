using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// PeriodDay Entity
/// </summary>
public class PeriodDay : Entity<PeriodDayId>
{
    private PeriodDay() { }

    /// <summary>
    /// The unique identifier for the PeriodDay
    /// المعرف الفريد لـ PeriodDay
    /// </summary>
    public PeriodDayId Id { get; private set; }

    /// <summary>
    /// PeriodTypeShort of the PeriodDay
    /// PeriodTypeShort الخاص بـ PeriodDay
    /// </summary>
    public decimal? PeriodTypeShort { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the PeriodDay
    /// PeriodNumberShort الخاص بـ PeriodDay
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// PeriodDate of the PeriodDay
    /// PeriodDate الخاص بـ PeriodDay
    /// </summary>
    public DateTime? PeriodDate { get; private set; }

    /// <summary>
    /// YearNumber of the PeriodDay
    /// YearNumber الخاص بـ PeriodDay
    /// </summary>
    public decimal? YearNumber { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the PeriodDay
    /// InactiveFlagAlt الخاص بـ PeriodDay
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to PeriodDetail
    /// </summary>
    public PeriodDetail PeriodDetail { get; private set; }
    #endregion
}
}
