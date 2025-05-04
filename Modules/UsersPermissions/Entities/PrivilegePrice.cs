using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegePrice Entity
/// </summary>
public class PrivilegePrice : Entity<PrivilegePriceId>
{
    private PrivilegePrice() { }

    /// <summary>
    /// The unique identifier for the PrivilegePrice
    /// المعرف الفريد لـ PrivilegePrice
    /// </summary>
    public PrivilegePriceId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegePrice
    /// UserId الخاص بـ PrivilegePrice
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// LevelNumber of the PrivilegePrice
    /// LevelNumber الخاص بـ PrivilegePrice
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegePrice
    /// AdditionalFlag الخاص بـ PrivilegePrice
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegePrice
    /// ViewFlag الخاص بـ PrivilegePrice
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    /// <summary>
    /// PrivilegeLow of the PrivilegePrice
    /// PrivilegeLow الخاص بـ PrivilegePrice
    /// </summary>
    public decimal? PrivilegeLow { get; private set; }

    /// <summary>
    /// PrivilegeHigh of the PrivilegePrice
    /// PrivilegeHigh الخاص بـ PrivilegePrice
    /// </summary>
    public decimal? PrivilegeHigh { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to PricingLevel
    /// </summary>
    public PricingLevel PricingLevel { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
