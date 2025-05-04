using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClassLimitMonth Entity
/// </summary>
public class InsuranceClassLimitMonth : Entity<InsuranceClassLimitMonthId>
{
    private InsuranceClassLimitMonth() { }

    /// <summary>
    /// The unique identifier for the InsuranceClassLimitMonth
    /// المعرف الفريد لـ InsuranceClassLimitMonth
    /// </summary>
    public InsuranceClassLimitMonthId Id { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumberAlt of the InsuranceClassLimitMonth
    /// InsuranceCompanyNumberAlt الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? InsuranceCompanyNumberAlt { get; private set; }

    /// <summary>
    /// ClassNumber of the InsuranceClassLimitMonth
    /// ClassNumber الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public string ClassNumber { get; private set; }

    /// <summary>
    /// RelationType1 of the InsuranceClassLimitMonth
    /// RelationType1 الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? RelationType1 { get; private set; }

    /// <summary>
    /// RelationType2 of the InsuranceClassLimitMonth
    /// RelationType2 الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? RelationType2 { get; private set; }

    /// <summary>
    /// RelationType3 of the InsuranceClassLimitMonth
    /// RelationType3 الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? RelationType3 { get; private set; }

    /// <summary>
    /// RelationType4 of the InsuranceClassLimitMonth
    /// RelationType4 الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? RelationType4 { get; private set; }

    /// <summary>
    /// RelationType5 of the InsuranceClassLimitMonth
    /// RelationType5 الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? RelationType5 { get; private set; }

    /// <summary>
    /// ItemType of the InsuranceClassLimitMonth
    /// ItemType الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// LimitAmountNetLocal of the InsuranceClassLimitMonth
    /// LimitAmountNetLocal الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? LimitAmountNetLocal { get; private set; }

    /// <summary>
    /// LimitAmountNetLocalYear of the InsuranceClassLimitMonth
    /// LimitAmountNetLocalYear الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? LimitAmountNetLocalYear { get; private set; }

    /// <summary>
    /// InsuranceGroupNumber of the InsuranceClassLimitMonth
    /// InsuranceGroupNumber الخاص بـ InsuranceClassLimitMonth
    /// </summary>
    public decimal? InsuranceGroupNumber { get; private set; }

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
