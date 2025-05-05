using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableChargeTdsSlice Entity
/// </summary>
public class AccountsPayableChargeTdsSlice : Entity<AccountsPayableChargeTdsSliceId>
{

    private AccountsPayableChargeTdsSlice() { }

    public AccountsPayableChargeTdsSlice(AccountsPayableChargeTdsSliceId id, decimal? sliceNumber)
    {
        Id = id;
        SliceNumber = sliceNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableChargeTdsSlice
    /// المعرف الفريد لـ AccountsPayableChargeTdsSlice
    /// </summary>
    public AccountsPayableChargeTdsSliceId Id { get; private set; }

    /// <summary>
    /// SliceNumber of the AccountsPayableChargeTdsSlice
    /// SliceNumber الخاص بـ AccountsPayableChargeTdsSlice
    /// </summary>
    public decimal? SliceNumber { get; private set; }

    /// <summary>
    /// FAmount of the AccountsPayableChargeTdsSlice
    /// FAmount الخاص بـ AccountsPayableChargeTdsSlice
    /// </summary>
    public decimal? FAmount { get; private set; }

    /// <summary>
    /// TAmount of the AccountsPayableChargeTdsSlice
    /// TAmount الخاص بـ AccountsPayableChargeTdsSlice
    /// </summary>
    public decimal? TAmount { get; private set; }

    /// <summary>
    /// SocialClassPanAmount of the AccountsPayableChargeTdsSlice
    /// SocialClassPanAmount الخاص بـ AccountsPayableChargeTdsSlice
    /// </summary>
    public decimal? SocialClassPanAmount { get; private set; }

    /// <summary>
    /// SocialClassNoPanAmount of the AccountsPayableChargeTdsSlice
    /// SocialClassNoPanAmount الخاص بـ AccountsPayableChargeTdsSlice
    /// </summary>
    public decimal? SocialClassNoPanAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsPayableCharge AccountsPayableCharge { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

