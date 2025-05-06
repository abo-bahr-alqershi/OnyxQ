using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeePrivilege Entity
/// </summary>
public class EmployeePrivilege : Entity<EmployeePrivilegeId>
{

    private EmployeePrivilege() { }

    public EmployeePrivilege(EmployeePrivilegeId id, decimal? userId, decimal? empPrvTyp, decimal? empnoHrchyno)
    {
        Id = id;
        UserId = userId;
        EmpPrvTyp = empPrvTyp;
        EmpnoHrchyno = empnoHrchyno;
    }

    /// <summary>
    /// The unique identifier for the EmployeePrivilege
    /// المعرف الفريد لـ EmployeePrivilege
    /// </summary>
    public EmployeePrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the EmployeePrivilege
    /// UserId الخاص بـ EmployeePrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// EmpPrvTyp of the EmployeePrivilege
    /// EmpPrvTyp الخاص بـ EmployeePrivilege
    /// </summary>
    public decimal? EmpPrvTyp { get; private set; }

    /// <summary>
    /// EmpnoHrchyno of the EmployeePrivilege
    /// EmpnoHrchyno الخاص بـ EmployeePrivilege
    /// </summary>
    public decimal? EmpnoHrchyno { get; private set; }

    /// <summary>
    /// AdditionalFlag of the EmployeePrivilege
    /// AdditionalFlag الخاص بـ EmployeePrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the EmployeePrivilege
    /// ViewFlag الخاص بـ EmployeePrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

