using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeMovement Entity
/// </summary>
public class EmployeeMovement : Entity<EmployeeMovementId>
{
    private EmployeeMovement() { }

    /// <summary>
    /// The unique identifier for the EmployeeMovement
    /// المعرف الفريد لـ EmployeeMovement
    /// </summary>
    public EmployeeMovementId Id { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeMovement
    /// EmpNo الخاص بـ EmployeeMovement
    /// </summary>
    public decimal? EmpNo { get; private set; }
}
}
