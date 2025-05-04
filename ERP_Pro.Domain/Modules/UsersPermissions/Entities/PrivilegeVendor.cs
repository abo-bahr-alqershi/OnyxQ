using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeVendor Entity
/// </summary>
public class PrivilegeVendor : Entity<PrivilegeVendorId>
{

    private PrivilegeVendor() { }

    public PrivilegeVendor(PrivilegeVendorId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PrivilegeVendor
    /// المعرف الفريد لـ PrivilegeVendor
    /// </summary>
    public PrivilegeVendorId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeVendor
    /// AdditionalFlag الخاص بـ PrivilegeVendor
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeVendor
    /// ViewFlag الخاص بـ PrivilegeVendor
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VendorCurrency VendorCurrency { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
