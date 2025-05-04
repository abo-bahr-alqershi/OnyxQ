using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BankGroup Entity
/// </summary>
public class BankGroup : Entity<BankGroupId>
{

    private BankGroup() { }

    public BankGroup(BankGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the BankGroup
    /// المعرف الفريد لـ BankGroup
    /// </summary>
    public BankGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the BankGroup
    /// GroupNumber الخاص بـ BankGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupName of the BankGroup
    /// GroupName الخاص بـ BankGroup
    /// </summary>
    public string GroupName { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the BankGroup
    /// GroupNameEnglish الخاص بـ BankGroup
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
