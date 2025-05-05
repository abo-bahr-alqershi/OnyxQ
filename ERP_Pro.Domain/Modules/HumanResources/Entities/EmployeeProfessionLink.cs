using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeProfessionLink Entity
/// </summary>
public class EmployeeProfessionLink : Entity<EmployeeProfessionLinkId>
{

    private EmployeeProfessionLink() { }

    public EmployeeProfessionLink(EmployeeProfessionLinkId id, decimal? systemNumber, decimal? professionNumber, decimal? empNo)
    {
        Id = id;
        SystemNumber = systemNumber;
        ProfessionNumber = professionNumber;
        EmpNo = empNo;
    }

    /// <summary>
    /// The unique identifier for the EmployeeProfessionLink
    /// المعرف الفريد لـ EmployeeProfessionLink
    /// </summary>
    public EmployeeProfessionLinkId Id { get; private set; }

    /// <summary>
    /// SystemNumber of the EmployeeProfessionLink
    /// SystemNumber الخاص بـ EmployeeProfessionLink
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// ProfessionNumber of the EmployeeProfessionLink
    /// ProfessionNumber الخاص بـ EmployeeProfessionLink
    /// </summary>
    public decimal? ProfessionNumber { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeProfessionLink
    /// EmpNo الخاص بـ EmployeeProfessionLink
    /// </summary>
    public decimal? EmpNo { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

