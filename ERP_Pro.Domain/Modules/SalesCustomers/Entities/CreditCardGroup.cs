using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CreditCardGroup Entity
/// </summary>
public class CreditCardGroup : Entity<CreditCardGroupId>
{

    private CreditCardGroup() { }

    public CreditCardGroup(CreditCardGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the CreditCardGroup
    /// المعرف الفريد لـ CreditCardGroup
    /// </summary>
    public CreditCardGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the CreditCardGroup
    /// GroupNumber الخاص بـ CreditCardGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupLastName of the CreditCardGroup
    /// GroupLastName الخاص بـ CreditCardGroup
    /// </summary>
    public string GroupLastName { get; private set; }

    /// <summary>
    /// GroupFirstName of the CreditCardGroup
    /// GroupFirstName الخاص بـ CreditCardGroup
    /// </summary>
    public string GroupFirstName { get; private set; }

    /// <summary>
    /// GroupTypeShort of the CreditCardGroup
    /// GroupTypeShort الخاص بـ CreditCardGroup
    /// </summary>
    public decimal? GroupTypeShort { get; private set; }

    /// <summary>
    /// DfltFlg of the CreditCardGroup
    /// DfltFlg الخاص بـ CreditCardGroup
    /// </summary>
    public decimal? DfltFlg { get; private set; }

    /// <summary>
    /// UserName of the CreditCardGroup
    /// UserName الخاص بـ CreditCardGroup
    /// </summary>
    public string UserName { get; private set; }

    /// <summary>
    /// UserPassword of the CreditCardGroup
    /// UserPassword الخاص بـ CreditCardGroup
    /// </summary>
    public string UserPassword { get; private set; }

    /// <summary>
    /// ExePath of the CreditCardGroup
    /// ExePath الخاص بـ CreditCardGroup
    /// </summary>
    public string ExePath { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

