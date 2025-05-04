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

    /// <summary>
    /// The unique identifier for the InsuranceCompanyClass
    /// المعرف الفريد لـ InsuranceCompanyClass
    /// </summary>
    public InsuranceCompanyClassId Id { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumberAlt of the InsuranceCompanyClass
    /// InsuranceCompanyNumberAlt الخاص بـ InsuranceCompanyClass
    /// </summary>
    public decimal? InsuranceCompanyNumberAlt { get; private set; }

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
    /// One-to-many relationship: InsuranceCompanyClass to InsuranceClassGroupItemOut
    /// </summary>
    public IReadOnlyCollection<InsuranceClassGroupItemOut> InsuranceClassGroupItemOuts { get; private set; }
    /// <summary>
    /// One-to-many relationship: InsuranceCompanyClass to InsuranceClassItemType
    /// </summary>
    public IReadOnlyCollection<InsuranceClassItemType> InsuranceClassItemTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: InsuranceCompanyClass to InsuranceClassLimitDocument
    /// </summary>
    public IReadOnlyCollection<InsuranceClassLimitDocument> InsuranceClassLimitDocuments { get; private set; }
    /// <summary>
    /// One-to-many relationship: InsuranceCompanyClass to InsuranceClassLimitMonth
    /// </summary>
    public IReadOnlyCollection<InsuranceClassLimitMonth> InsuranceClassLimitMonths { get; private set; }
    /// <summary>
    /// One-to-many relationship: InsuranceCompanyClass to InsuranceClassMedicalNetwork
    /// </summary>
    public IReadOnlyCollection<InsuranceClassMedicalNetwork> InsuranceClassMedicalNetworks { get; private set; }
    /// <summary>
    /// ManyToOne relationship to InsuranceCompany
    /// </summary>
    public InsuranceCompany InsuranceCompany { get; private set; }
    #endregion
}
}
