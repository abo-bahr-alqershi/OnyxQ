using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceCompanyClass Entity
/// </summary>
public class InsuranceCompanyClass : Entity<InsuranceCompanyClassId>
{

    private InsuranceCompanyClass() { }

    public InsuranceCompanyClass(InsuranceCompanyClassId id, string classNumber)
    {
        Id = id;
        ClassNumber = classNumber;
    }

    /// <summary>
    /// The unique identifier for the InsuranceCompanyClass
    /// المعرف الفريد لـ InsuranceCompanyClass
    /// </summary>
    public InsuranceCompanyClassId Id { get; private set; }

    /// <summary>
    /// ClassNumber of the InsuranceCompanyClass
    /// ClassNumber الخاص بـ InsuranceCompanyClass
    /// </summary>
    public string ClassNumber { get; private set; }

    /// <summary>
    /// ClassLastName of the InsuranceCompanyClass
    /// ClassLastName الخاص بـ InsuranceCompanyClass
    /// </summary>
    public string ClassLastName { get; private set; }

    /// <summary>
    /// ClassFirstName of the InsuranceCompanyClass
    /// ClassFirstName الخاص بـ InsuranceCompanyClass
    /// </summary>
    public string ClassFirstName { get; private set; }

    /// <summary>
    /// InactiveFlag of the InsuranceCompanyClass
    /// InactiveFlag الخاص بـ InsuranceCompanyClass
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the InsuranceCompanyClass
    /// InactiveDate الخاص بـ InsuranceCompanyClass
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the InsuranceCompanyClass
    /// InactiveReason الخاص بـ InsuranceCompanyClass
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the InsuranceCompanyClass
    /// InactivatedByUserId الخاص بـ InsuranceCompanyClass
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// BeneficiaryNumber of the InsuranceCompanyClass
    /// BeneficiaryNumber الخاص بـ InsuranceCompanyClass
    /// </summary>
    public decimal? BeneficiaryNumber { get; private set; }

    /// <summary>
    /// DiscPer of the InsuranceCompanyClass
    /// DiscPer الخاص بـ InsuranceCompanyClass
    /// </summary>
    public decimal? DiscPer { get; private set; }

    /// <summary>
    /// ContractFromDate of the InsuranceCompanyClass
    /// ContractFromDate الخاص بـ InsuranceCompanyClass
    /// </summary>
    public DateTime? ContractFromDate { get; private set; }

    /// <summary>
    /// ContractTransactionDate of the InsuranceCompanyClass
    /// ContractTransactionDate الخاص بـ InsuranceCompanyClass
    /// </summary>
    public DateTime? ContractTransactionDate { get; private set; }

    /// <summary>
    /// AllowUpdateLoadPercentLimit of the InsuranceCompanyClass
    /// AllowUpdateLoadPercentLimit الخاص بـ InsuranceCompanyClass
    /// </summary>
    public decimal? AllowUpdateLoadPercentLimit { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InsuranceCompany InsuranceCompany { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
