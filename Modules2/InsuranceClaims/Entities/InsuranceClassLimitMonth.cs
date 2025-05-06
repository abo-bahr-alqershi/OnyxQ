using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClassLimitMonth Entity
/// </summary>
public class InsuranceClassLimitMonth : Entity<InsuranceClassLimitMonthId>
{
    private readonly List<InsuranceCompanyClass> _insuranceCompanyClass = new List<InsuranceCompanyClass>();
    private readonly List<InsuranceItemGroupMaster> _insuranceItemGroupMaster = new List<InsuranceItemGroupMaster>();

    private InsuranceClassLimitMonth() { }

    public InsuranceClassLimitMonth(InsuranceClassLimitMonthId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceClassLimitMonth
    /// المعرف الفريد لـ InsuranceClassLimitMonth
    /// </summary>
    public InsuranceClassLimitMonthId Id { get; private set; }

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

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<InsuranceCompanyClass> InsuranceCompanyClass => _insuranceCompanyClass;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<InsuranceItemGroupMaster> InsuranceItemGroupMaster => _insuranceItemGroupMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

