using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClassItemType Entity
/// </summary>
public class InsuranceClassItemType : Entity<InsuranceClassItemTypeId>
{
    private readonly List<InsuranceCompanyClass> _insuranceCompanyClass = new List<InsuranceCompanyClass>();
    private readonly List<InsuranceItemGroupMaster> _insuranceItemGroupMaster = new List<InsuranceItemGroupMaster>();

    private InsuranceClassItemType() { }

    public InsuranceClassItemType(InsuranceClassItemTypeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceClassItemType
    /// المعرف الفريد لـ InsuranceClassItemType
    /// </summary>
    public InsuranceClassItemTypeId Id { get; private set; }

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
    /// DiscPerChronic of the InsuranceClassItemType
    /// DiscPerChronic الخاص بـ InsuranceClassItemType
    /// </summary>
    public decimal? DiscPerChronic { get; private set; }

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

