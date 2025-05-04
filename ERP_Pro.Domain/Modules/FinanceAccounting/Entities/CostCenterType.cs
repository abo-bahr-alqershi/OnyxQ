using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CostCenterType Entity
/// </summary>
public class CostCenterType : Entity<CostCenterTypeId>
{

    private CostCenterType() { }

    public CostCenterType(CostCenterTypeId id, decimal? costCenterType)
    {
        Id = id;
        CostCenterType = costCenterType;
    }

    /// <summary>
    /// The unique identifier for the CostCenterType
    /// المعرف الفريد لـ CostCenterType
    /// </summary>
    public CostCenterTypeId Id { get; private set; }

    /// <summary>
    /// CostCenterType of the CostCenterType
    /// CostCenterType الخاص بـ CostCenterType
    /// </summary>
    public decimal? CostCenterType { get; private set; }

    /// <summary>
    /// CostCenterName of the CostCenterType
    /// CostCenterName الخاص بـ CostCenterType
    /// </summary>
    public string CostCenterName { get; private set; }

    /// <summary>
    /// CostCenterNameEnglish of the CostCenterType
    /// CostCenterNameEnglish الخاص بـ CostCenterType
    /// </summary>
    public string CostCenterNameEnglish { get; private set; }

    /// <summary>
    /// AffectedByTransactionFlag of the CostCenterType
    /// AffectedByTransactionFlag الخاص بـ CostCenterType
    /// </summary>
    public decimal? AffectedByTransactionFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
