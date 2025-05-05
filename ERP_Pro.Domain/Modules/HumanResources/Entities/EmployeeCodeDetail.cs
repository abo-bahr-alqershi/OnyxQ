using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeCodeDetail Entity
/// </summary>
public class EmployeeCodeDetail : Entity<EmployeeCodeDetailId>
{

    private EmployeeCodeDetail() { }

    public EmployeeCodeDetail(EmployeeCodeDetailId id, decimal? codeNumber)
    {
        Id = id;
        CodeNumber = codeNumber;
    }

    /// <summary>
    /// The unique identifier for the EmployeeCodeDetail
    /// المعرف الفريد لـ EmployeeCodeDetail
    /// </summary>
    public EmployeeCodeDetailId Id { get; private set; }

    /// <summary>
    /// CodeNumber of the EmployeeCodeDetail
    /// CodeNumber الخاص بـ EmployeeCodeDetail
    /// </summary>
    public decimal? CodeNumber { get; private set; }

    /// <summary>
    /// CodeLastName of the EmployeeCodeDetail
    /// CodeLastName الخاص بـ EmployeeCodeDetail
    /// </summary>
    public string CodeLastName { get; private set; }

    /// <summary>
    /// CodeFirstName of the EmployeeCodeDetail
    /// CodeFirstName الخاص بـ EmployeeCodeDetail
    /// </summary>
    public string CodeFirstName { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeCodeDetail
    /// InactiveFlag الخاص بـ EmployeeCodeDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the EmployeeCodeDetail
    /// InactiveReason الخاص بـ EmployeeCodeDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the EmployeeCodeDetail
    /// InactiveDate الخاص بـ EmployeeCodeDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the EmployeeCodeDetail
    /// InactivatedByUserId الخاص بـ EmployeeCodeDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// OrderNumberShort of the EmployeeCodeDetail
    /// OrderNumberShort الخاص بـ EmployeeCodeDetail
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// Notes of the EmployeeCodeDetail
    /// Notes الخاص بـ EmployeeCodeDetail
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// ShowEmployeeInEss of the EmployeeCodeDetail
    /// ShowEmployeeInEss الخاص بـ EmployeeCodeDetail
    /// </summary>
    public decimal? ShowEmployeeInEss { get; private set; }

    /// <summary>
    /// EmpNoSqBgn of the EmployeeCodeDetail
    /// EmpNoSqBgn الخاص بـ EmployeeCodeDetail
    /// </summary>
    public decimal? EmpNoSqBgn { get; private set; }

    /// <summary>
    /// EmpNoSqEnd of the EmployeeCodeDetail
    /// EmpNoSqEnd الخاص بـ EmployeeCodeDetail
    /// </summary>
    public decimal? EmpNoSqEnd { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public EmployeeCodeMaster EmployeeCodeMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

