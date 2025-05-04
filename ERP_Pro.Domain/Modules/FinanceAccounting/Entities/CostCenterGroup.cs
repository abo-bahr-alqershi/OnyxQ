using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CostCenterGroup Entity
/// </summary>
public class CostCenterGroup : Entity<CostCenterGroupId>
{

    private CostCenterGroup() { }

    public CostCenterGroup(CostCenterGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the CostCenterGroup
    /// المعرف الفريد لـ CostCenterGroup
    /// </summary>
    public CostCenterGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the CostCenterGroup
    /// GroupNumber الخاص بـ CostCenterGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupName of the CostCenterGroup
    /// GroupName الخاص بـ CostCenterGroup
    /// </summary>
    public string GroupName { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the CostCenterGroup
    /// GroupNameEnglish الخاص بـ CostCenterGroup
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
