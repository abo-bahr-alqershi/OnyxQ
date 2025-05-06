using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableBillType Entity
/// </summary>
public class AccountsPayableBillType : Entity<AccountsPayableBillTypeId>
{

    private AccountsPayableBillType() { }

    public AccountsPayableBillType(AccountsPayableBillTypeId id, decimal? billTypeNumber)
    {
        Id = id;
        BillTypeNumber = billTypeNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableBillType
    /// المعرف الفريد لـ AccountsPayableBillType
    /// </summary>
    public AccountsPayableBillTypeId Id { get; private set; }

    /// <summary>
    /// BillTypeNumber of the AccountsPayableBillType
    /// BillTypeNumber الخاص بـ AccountsPayableBillType
    /// </summary>
    public decimal? BillTypeNumber { get; private set; }

    /// <summary>
    /// TypeLastName of the AccountsPayableBillType
    /// TypeLastName الخاص بـ AccountsPayableBillType
    /// </summary>
    public string TypeLastName { get; private set; }

    /// <summary>
    /// TypeFirstName of the AccountsPayableBillType
    /// TypeFirstName الخاص بـ AccountsPayableBillType
    /// </summary>
    public string TypeFirstName { get; private set; }

    /// <summary>
    /// TypeNumber of the AccountsPayableBillType
    /// TypeNumber الخاص بـ AccountsPayableBillType
    /// </summary>
    public decimal? TypeNumber { get; private set; }

    /// <summary>
    /// BillWithoutOtherAmount of the AccountsPayableBillType
    /// BillWithoutOtherAmount الخاص بـ AccountsPayableBillType
    /// </summary>
    public decimal? BillWithoutOtherAmount { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

