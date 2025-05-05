using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// PeriodWorkEmployee Entity
/// </summary>
public class PeriodWorkEmployee : Entity<PeriodWorkEmployeeId>
{

    private PeriodWorkEmployee() { }

    public PeriodWorkEmployee(PeriodWorkEmployeeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PeriodWorkEmployee
    /// المعرف الفريد لـ PeriodWorkEmployee
    /// </summary>
    public PeriodWorkEmployeeId Id { get; private set; }

    /// <summary>
    /// WorkPeriodNumber of the PeriodWorkEmployee
    /// WorkPeriodNumber الخاص بـ PeriodWorkEmployee
    /// </summary>
    public decimal? WorkPeriodNumber { get; private set; }

    /// <summary>
    /// EmpNo of the PeriodWorkEmployee
    /// EmpNo الخاص بـ PeriodWorkEmployee
    /// </summary>
    public decimal? EmpNo { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

