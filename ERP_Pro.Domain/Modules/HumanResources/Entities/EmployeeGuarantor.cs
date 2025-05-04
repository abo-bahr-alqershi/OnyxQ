using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeGuarantor Entity
/// </summary>
public class EmployeeGuarantor : Entity<EmployeeGuarantorId>
{

    private EmployeeGuarantor() { }

    public EmployeeGuarantor(EmployeeGuarantorId id, decimal? guarantorNumber)
    {
        Id = id;
        GuarantorNumber = guarantorNumber;
    }

    /// <summary>
    /// The unique identifier for the EmployeeGuarantor
    /// المعرف الفريد لـ EmployeeGuarantor
    /// </summary>
    public EmployeeGuarantorId Id { get; private set; }

    /// <summary>
    /// GuarantorNumber of the EmployeeGuarantor
    /// GuarantorNumber الخاص بـ EmployeeGuarantor
    /// </summary>
    public decimal? GuarantorNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeGuarantor
    /// InactiveFlag الخاص بـ EmployeeGuarantor
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the EmployeeGuarantor
    /// InactiveReason الخاص بـ EmployeeGuarantor
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the EmployeeGuarantor
    /// InactiveDate الخاص بـ EmployeeGuarantor
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the EmployeeGuarantor
    /// InactivatedByUserId الخاص بـ EmployeeGuarantor
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// SalaryFlagShort of the EmployeeGuarantor
    /// SalaryFlagShort الخاص بـ EmployeeGuarantor
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
