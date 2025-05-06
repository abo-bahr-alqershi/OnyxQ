using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.HumanResources.Entities;

using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;
namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCounterEmployee Entity
/// </summary>
public class StationCounterEmployee : Entity<StationCounterEmployeeId>
{

    private StationCounterEmployee() { }

    public StationCounterEmployee(StationCounterEmployeeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the StationCounterEmployee
    /// المعرف الفريد لـ StationCounterEmployee
    /// </summary>
    public StationCounterEmployeeId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the StationCounterEmployee
    /// BranchNumber الخاص بـ StationCounterEmployee
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Employee Employee { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public StationCounter StationCounter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public StationPeriod StationPeriod { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

