using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceCompany Entity
/// </summary>
public class InsuranceCompany : Entity<InsuranceCompanyId>
{

    private InsuranceCompany() { }

    public InsuranceCompany(InsuranceCompanyId id, decimal? insuranceCompanyNumberAlt)
    {
        Id = id;
        InsuranceCompanyNumberAlt = insuranceCompanyNumberAlt;
    }

    /// <summary>
    /// The unique identifier for the InsuranceCompany
    /// المعرف الفريد لـ InsuranceCompany
    /// </summary>
    public InsuranceCompanyId Id { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumberAlt of the InsuranceCompany
    /// InsuranceCompanyNumberAlt الخاص بـ InsuranceCompany
    /// </summary>
    public decimal? InsuranceCompanyNumberAlt { get; private set; }

    /// <summary>
    /// InsuranceCompanyLastName of the InsuranceCompany
    /// InsuranceCompanyLastName الخاص بـ InsuranceCompany
    /// </summary>
    public string InsuranceCompanyLastName { get; private set; }

    /// <summary>
    /// InsuranceCompanyFirstName of the InsuranceCompany
    /// InsuranceCompanyFirstName الخاص بـ InsuranceCompany
    /// </summary>
    public string InsuranceCompanyFirstName { get; private set; }

    /// <summary>
    /// InsuranceCompanyTelephone of the InsuranceCompany
    /// InsuranceCompanyTelephone الخاص بـ InsuranceCompany
    /// </summary>
    public string InsuranceCompanyTelephone { get; private set; }

    /// <summary>
    /// InsuranceCompanyAddress of the InsuranceCompany
    /// InsuranceCompanyAddress الخاص بـ InsuranceCompany
    /// </summary>
    public string InsuranceCompanyAddress { get; private set; }

    /// <summary>
    /// Website of the InsuranceCompany
    /// Website الخاص بـ InsuranceCompany
    /// </summary>
    public string Website { get; private set; }

    /// <summary>
    /// DisPer of the InsuranceCompany
    /// DisPer الخاص بـ InsuranceCompany
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// InactiveFlag of the InsuranceCompany
    /// InactiveFlag الخاص بـ InsuranceCompany
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the InsuranceCompany
    /// InactiveDate الخاص بـ InsuranceCompany
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the InsuranceCompany
    /// InactiveReason الخاص بـ InsuranceCompany
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the InsuranceCompany
    /// InactivatedByUserId الخاص بـ InsuranceCompany
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CalcTaxInsuranceCompanyFlag of the InsuranceCompany
    /// CalcTaxInsuranceCompanyFlag الخاص بـ InsuranceCompany
    /// </summary>
    public decimal? CalcTaxInsuranceCompanyFlag { get; private set; }

    /// <summary>
    /// CalcInsuranceLoadAmountMethod of the InsuranceCompany
    /// CalcInsuranceLoadAmountMethod الخاص بـ InsuranceCompany
    /// </summary>
    public decimal? CalcInsuranceLoadAmountMethod { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

