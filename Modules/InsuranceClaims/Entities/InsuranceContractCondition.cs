using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceContractCondition Entity
/// </summary>
public class InsuranceContractCondition : Entity<InsuranceContractConditionId>
{
    private InsuranceContractCondition() { }

    /// <summary>
    /// The unique identifier for the InsuranceContractCondition
    /// المعرف الفريد لـ InsuranceContractCondition
    /// </summary>
    public InsuranceContractConditionId Id { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumberAlt of the InsuranceContractCondition
    /// InsuranceCompanyNumberAlt الخاص بـ InsuranceContractCondition
    /// </summary>
    public decimal? InsuranceCompanyNumberAlt { get; private set; }

    /// <summary>
    /// ConditionNumber of the InsuranceContractCondition
    /// ConditionNumber الخاص بـ InsuranceContractCondition
    /// </summary>
    public decimal? ConditionNumber { get; private set; }

    /// <summary>
    /// ConditionDescription of the InsuranceContractCondition
    /// ConditionDescription الخاص بـ InsuranceContractCondition
    /// </summary>
    public string ConditionDescription { get; private set; }

    /// <summary>
    /// MandatorySalesInvoiceFlag of the InsuranceContractCondition
    /// MandatorySalesInvoiceFlag الخاص بـ InsuranceContractCondition
    /// </summary>
    public decimal? MandatorySalesInvoiceFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InsuranceContractCondition
    /// CompanyNumberShort الخاص بـ InsuranceContractCondition
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InsuranceContractCondition
    /// BranchNumber الخاص بـ InsuranceContractCondition
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InsuranceContractCondition
    /// BranchYear الخاص بـ InsuranceContractCondition
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InsuranceContractCondition
    /// BranchUser الخاص بـ InsuranceContractCondition
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to InsuranceCompany
    /// </summary>
    public InsuranceCompany InsuranceCompany { get; private set; }
    #endregion
}
}
