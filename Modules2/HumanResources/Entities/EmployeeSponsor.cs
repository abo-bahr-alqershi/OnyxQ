using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeSponsor Entity
/// </summary>
public class EmployeeSponsor : Entity<EmployeeSponsorId>
{

    private EmployeeSponsor() { }

    public EmployeeSponsor(EmployeeSponsorId id, decimal? sponsorNumber)
    {
        Id = id;
        SponsorNumber = sponsorNumber;
    }

    /// <summary>
    /// The unique identifier for the EmployeeSponsor
    /// المعرف الفريد لـ EmployeeSponsor
    /// </summary>
    public EmployeeSponsorId Id { get; private set; }

    /// <summary>
    /// SponsorNumber of the EmployeeSponsor
    /// SponsorNumber الخاص بـ EmployeeSponsor
    /// </summary>
    public decimal? SponsorNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeSponsor
    /// InactiveFlag الخاص بـ EmployeeSponsor
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the EmployeeSponsor
    /// InactiveReason الخاص بـ EmployeeSponsor
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the EmployeeSponsor
    /// InactiveDate الخاص بـ EmployeeSponsor
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the EmployeeSponsor
    /// InactivatedByUserId الخاص بـ EmployeeSponsor
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// SalaryFlagShort of the EmployeeSponsor
    /// SalaryFlagShort الخاص بـ EmployeeSponsor
    /// </summary>
    public decimal? SalaryFlagShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Employee Employee { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

