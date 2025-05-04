using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CashGroup Entity
/// </summary>
public class CashGroup : Entity<CashGroupId>
{

    private CashGroup() { }

    public CashGroup(CashGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the CashGroup
    /// المعرف الفريد لـ CashGroup
    /// </summary>
    public CashGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the CashGroup
    /// GroupNumber الخاص بـ CashGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupName of the CashGroup
    /// GroupName الخاص بـ CashGroup
    /// </summary>
    public string GroupName { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the CashGroup
    /// GroupNameEnglish الخاص بـ CashGroup
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
