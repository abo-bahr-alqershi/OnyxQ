using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApexScreen Entity
/// </summary>
public class ApexScreen : Entity<ApexScreenId>
{
    private ApexScreen() { }

    /// <summary>
    /// The unique identifier for the ApexScreen
    /// المعرف الفريد لـ ApexScreen
    /// </summary>
    public ApexScreenId Id { get; private set; }

    /// <summary>
    /// ScreenNumber of the ApexScreen
    /// ScreenNumber الخاص بـ ApexScreen
    /// </summary>
    public decimal? ScreenNumber { get; private set; }

    /// <summary>
    /// LabelNumber of the ApexScreen
    /// LabelNumber الخاص بـ ApexScreen
    /// </summary>
    public decimal? LabelNumber { get; private set; }

    /// <summary>
    /// ScreenParentNumberShort of the ApexScreen
    /// ScreenParentNumberShort الخاص بـ ApexScreen
    /// </summary>
    public decimal? ScreenParentNumberShort { get; private set; }

    /// <summary>
    /// InactiveFlag of the ApexScreen
    /// InactiveFlag الخاص بـ ApexScreen
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ApexScreen
    /// OrderNumberShort الخاص بـ ApexScreen
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// ScreenType of the ApexScreen
    /// ScreenType الخاص بـ ApexScreen
    /// </summary>
    public decimal? ScreenType { get; private set; }

    /// <summary>
    /// FileNameShort of the ApexScreen
    /// FileNameShort الخاص بـ ApexScreen
    /// </summary>
    public string FileNameShort { get; private set; }

    /// <summary>
    /// ScreenIcon of the ApexScreen
    /// ScreenIcon الخاص بـ ApexScreen
    /// </summary>
    public string ScreenIcon { get; private set; }

    /// <summary>
    /// DfltFlg of the ApexScreen
    /// DfltFlg الخاص بـ ApexScreen
    /// </summary>
    public decimal? DfltFlg { get; private set; }

    /// <summary>
    /// MobileFileName of the ApexScreen
    /// MobileFileName الخاص بـ ApexScreen
    /// </summary>
    public string MobileFileName { get; private set; }

    /// <summary>
    /// MobileScreenIcon of the ApexScreen
    /// MobileScreenIcon الخاص بـ ApexScreen
    /// </summary>
    public string MobileScreenIcon { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ApexScreen to ApexFavoriteScreen
    /// </summary>
    public IReadOnlyCollection<ApexFavoriteScreen> ApexFavoriteScreens { get; private set; }
    /// <summary>
    /// One-to-many relationship: ApexScreen to ApexScreenPrivilege
    /// </summary>
    public IReadOnlyCollection<ApexScreenPrivilege> ApexScreenPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: ApexScreen to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
