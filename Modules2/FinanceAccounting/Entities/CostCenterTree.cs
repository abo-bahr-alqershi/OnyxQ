using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CostCenterTree Entity
/// </summary>
public class CostCenterTree : Entity<CostCenterTreeId>
{

    private CostCenterTree() { }

    public CostCenterTree(CostCenterTreeId id, string costCenterCode, string costCenterTree)
    {
        Id = id;
        CostCenterCode = costCenterCode;
        CostCenterTree = costCenterTree;
    }

    /// <summary>
    /// The unique identifier for the CostCenterTree
    /// المعرف الفريد لـ CostCenterTree
    /// </summary>
    public CostCenterTreeId Id { get; private set; }

    /// <summary>
    /// CostCenterNumber of the CostCenterTree
    /// CostCenterNumber الخاص بـ CostCenterTree
    /// </summary>
    public decimal? CostCenterNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the CostCenterTree
    /// CostCenterCode الخاص بـ CostCenterTree
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CostCenterTree of the CostCenterTree
    /// CostCenterTree الخاص بـ CostCenterTree
    /// </summary>
    public string CostCenterTree { get; private set; }

    /// <summary>
    /// CostCenterNameArabic of the CostCenterTree
    /// CostCenterNameArabic الخاص بـ CostCenterTree
    /// </summary>
    public string CostCenterNameArabic { get; private set; }

    /// <summary>
    /// CostCenterNameEnglish of the CostCenterTree
    /// CostCenterNameEnglish الخاص بـ CostCenterTree
    /// </summary>
    public string CostCenterNameEnglish { get; private set; }

    /// <summary>
    /// CLevel of the CostCenterTree
    /// CLevel الخاص بـ CostCenterTree
    /// </summary>
    public decimal? CLevel { get; private set; }

    /// <summary>
    /// CParent of the CostCenterTree
    /// CParent الخاص بـ CostCenterTree
    /// </summary>
    public string CParent { get; private set; }

    /// <summary>
    /// CSM of the CostCenterTree
    /// CSM الخاص بـ CostCenterTree
    /// </summary>
    public decimal? CSM { get; private set; }

    /// <summary>
    /// MainSubject of the CostCenterTree
    /// MainSubject الخاص بـ CostCenterTree
    /// </summary>
    public decimal? MainSubject { get; private set; }

    /// <summary>
    /// CGrouping of the CostCenterTree
    /// CGrouping الخاص بـ CostCenterTree
    /// </summary>
    public decimal? CGrouping { get; private set; }

    /// <summary>
    /// InactiveFlag of the CostCenterTree
    /// InactiveFlag الخاص بـ CostCenterTree
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

