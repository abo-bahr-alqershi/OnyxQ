using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClassItemType Entity
/// </summary>
public class InsuranceClassItemType : Entity<InsuranceClassItemTypeId>
{
    private InsuranceClassItemType() { }

    /// <summary>
    /// The unique identifier for the InsuranceClassItemType
    /// المعرف الفريد لـ InsuranceClassItemType
    /// </summary>
    public InsuranceClassItemTypeId Id { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumberAlt of the InsuranceClassItemType
    /// InsuranceCompanyNumberAlt الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? InsuranceCompanyNumberAlt { get; private set; }

    /// <summary>
    /// ClassNumber of the InsuranceClassItemType
    /// ClassNumber الخاص بـ InsuranceClassItemType
    /// </summary>
    public string ClassNumber { get; private set; }

    /// <summary>
    /// ItemType of the InsuranceClassItemType
    /// ItemType الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// OutgoingType of the InsuranceClassItemType
    /// OutgoingType الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? OutgoingType { get; private set; }

    /// <summary>
    /// LimitAmountLocalNetDocument of the InsuranceClassItemType
    /// LimitAmountLocalNetDocument الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? LimitAmountLocalNetDocument { get; private set; }

    /// <summary>
    /// DiscPer of the InsuranceClassItemType
    /// DiscPer الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? DiscPer { get; private set; }

    /// <summary>
    /// LoadPercent of the InsuranceClassItemType
    /// LoadPercent الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? LoadPercent { get; private set; }

    /// <summary>
    /// LoadPercentOutNet of the InsuranceClassItemType
    /// LoadPercentOutNet الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? LoadPercentOutNet { get; private set; }

    /// <summary>
    /// LimitAmountLocalOutNetDocument of the InsuranceClassItemType
    /// LimitAmountLocalOutNetDocument الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? LimitAmountLocalOutNetDocument { get; private set; }

    /// <summary>
    /// InsuranceGroupNumber of the InsuranceClassItemType
    /// InsuranceGroupNumber الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? InsuranceGroupNumber { get; private set; }

    /// <summary>
    /// DiscPerChronic of the InsuranceClassItemType
    /// DiscPerChronic الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? DiscPerChronic { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to InsuranceCompanyClass
    /// </summary>
    public InsuranceCompanyClass InsuranceCompanyClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to InsuranceItemGroupMaster
    /// </summary>
    public InsuranceItemGroupMaster InsuranceItemGroupMaster { get; private set; }
    #endregion
}
}
