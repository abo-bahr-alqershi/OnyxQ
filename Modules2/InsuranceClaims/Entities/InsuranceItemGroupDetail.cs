using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceItemGroupDetail Entity
/// </summary>
public class InsuranceItemGroupDetail : Entity<InsuranceItemGroupDetailId>
{

    private InsuranceItemGroupDetail() { }

    public InsuranceItemGroupDetail(InsuranceItemGroupDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceItemGroupDetail
    /// المعرف الفريد لـ InsuranceItemGroupDetail
    /// </summary>
    public InsuranceItemGroupDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the InsuranceItemGroupDetail
    /// RecordNumber الخاص بـ InsuranceItemGroupDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// InsuranceGroupType of the InsuranceItemGroupDetail
    /// InsuranceGroupType الخاص بـ InsuranceItemGroupDetail
    /// </summary>
    public decimal? InsuranceGroupType { get; private set; }

    /// <summary>
    /// BranchYear of the InsuranceItemGroupDetail
    /// BranchYear الخاص بـ InsuranceItemGroupDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InsuranceItemGroupDetail
    /// BranchUser الخاص بـ InsuranceItemGroupDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// InsuranceGroupValue of the InsuranceItemGroupDetail
    /// InsuranceGroupValue الخاص بـ InsuranceItemGroupDetail
    /// </summary>
    public string InsuranceGroupValue { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InsuranceItemGroupMaster InsuranceItemGroupMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

