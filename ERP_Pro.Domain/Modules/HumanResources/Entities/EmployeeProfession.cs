using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeProfession Entity
/// </summary>
public class EmployeeProfession : Entity<EmployeeProfessionId>
{

    private EmployeeProfession() { }

    public EmployeeProfession(EmployeeProfessionId id, decimal? systemNumber, decimal? professionNumber)
    {
        Id = id;
        SystemNumber = systemNumber;
        ProfessionNumber = professionNumber;
    }

    /// <summary>
    /// The unique identifier for the EmployeeProfession
    /// المعرف الفريد لـ EmployeeProfession
    /// </summary>
    public EmployeeProfessionId Id { get; private set; }

    /// <summary>
    /// SystemNumber of the EmployeeProfession
    /// SystemNumber الخاص بـ EmployeeProfession
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// ProfessionNumber of the EmployeeProfession
    /// ProfessionNumber الخاص بـ EmployeeProfession
    /// </summary>
    public decimal? ProfessionNumber { get; private set; }

    /// <summary>
    /// LabelNumberShort of the EmployeeProfession
    /// LabelNumberShort الخاص بـ EmployeeProfession
    /// </summary>
    public decimal? LabelNumberShort { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
