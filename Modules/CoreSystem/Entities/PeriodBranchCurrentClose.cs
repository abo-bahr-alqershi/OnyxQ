using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// PeriodBranchCurrentClose Entity
/// </summary>
public class PeriodBranchCurrentClose : Entity<PeriodBranchCurrentCloseId>
{
    private PeriodBranchCurrentClose() { }

    /// <summary>
    /// The unique identifier for the PeriodBranchCurrentClose
    /// المعرف الفريد لـ PeriodBranchCurrentClose
    /// </summary>
    public PeriodBranchCurrentCloseId Id { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the PeriodBranchCurrentClose
    /// PeriodNumberShort الخاص بـ PeriodBranchCurrentClose
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PeriodBranchCurrentClose
    /// BranchNumber الخاص بـ PeriodBranchCurrentClose
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CurCode of the PeriodBranchCurrentClose
    /// CurCode الخاص بـ PeriodBranchCurrentClose
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurRate of the PeriodBranchCurrentClose
    /// CurRate الخاص بـ PeriodBranchCurrentClose
    /// </summary>
    public decimal? CurRate { get; private set; }
}
}
