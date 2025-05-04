using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.HumanResources.Entities;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCounterEmployee Entity
/// </summary>
public class StationCounterEmployee : Entity<StationCounterEmployeeId>
{
    private StationCounterEmployee() { }

    /// <summary>
    /// The unique identifier for the StationCounterEmployee
    /// المعرف الفريد لـ StationCounterEmployee
    /// </summary>
    public StationCounterEmployeeId Id { get; private set; }

    /// <summary>
    /// CuntrNo of the StationCounterEmployee
    /// CuntrNo الخاص بـ StationCounterEmployee
    /// </summary>
    public decimal? CuntrNo { get; private set; }

    /// <summary>
    /// EmpNo of the StationCounterEmployee
    /// EmpNo الخاص بـ StationCounterEmployee
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// BranchNumber of the StationCounterEmployee
    /// BranchNumber الخاص بـ StationCounterEmployee
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the StationCounterEmployee
    /// PeriodNumberShort الخاص بـ StationCounterEmployee
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
    /// <summary>
    /// ManyToOne relationship to StationCounter
    /// </summary>
    public StationCounter StationCounter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to StationPeriod
    /// </summary>
    public StationPeriod StationPeriod { get; private set; }
    #endregion
}
}
