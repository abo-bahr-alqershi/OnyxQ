using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// MobileScreen Entity
/// </summary>
public class MobileScreen : Entity<MobileScreenId>
{
    private MobileScreen() { }

    /// <summary>
    /// The unique identifier for the MobileScreen
    /// المعرف الفريد لـ MobileScreen
    /// </summary>
    public MobileScreenId Id { get; private set; }

    /// <summary>
    /// SystemNumber of the MobileScreen
    /// SystemNumber الخاص بـ MobileScreen
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// ScreenNumber of the MobileScreen
    /// ScreenNumber الخاص بـ MobileScreen
    /// </summary>
    public decimal? ScreenNumber { get; private set; }

    /// <summary>
    /// ScreenParentNumber of the MobileScreen
    /// ScreenParentNumber الخاص بـ MobileScreen
    /// </summary>
    public decimal? ScreenParentNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the MobileScreen
    /// InactiveFlag الخاص بـ MobileScreen
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// OrderNumberShort of the MobileScreen
    /// OrderNumberShort الخاص بـ MobileScreen
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: MobileScreen to MobileScreenName
    /// </summary>
    public IReadOnlyCollection<MobileScreenName> MobileScreenNames { get; private set; }
    /// <summary>
    /// One-to-many relationship: MobileScreen to MobileScreenPrivilege
    /// </summary>
    public IReadOnlyCollection<MobileScreenPrivilege> MobileScreenPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: MobileScreen to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
