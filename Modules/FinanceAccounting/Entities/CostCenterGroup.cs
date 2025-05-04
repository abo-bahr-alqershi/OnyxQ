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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CostCenterGroup to CostCenter
    /// </summary>
    public IReadOnlyCollection<CostCenter> CostCenters { get; private set; }
    #endregion
}
}
