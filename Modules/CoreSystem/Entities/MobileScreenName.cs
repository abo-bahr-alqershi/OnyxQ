using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// MobileScreenName Entity
/// </summary>
public class MobileScreenName : Entity<MobileScreenNameId>
{
    private MobileScreenName() { }

    /// <summary>
    /// The unique identifier for the MobileScreenName
    /// المعرف الفريد لـ MobileScreenName
    /// </summary>
    public MobileScreenNameId Id { get; private set; }

    /// <summary>
    /// ScreenNumber of the MobileScreenName
    /// ScreenNumber الخاص بـ MobileScreenName
    /// </summary>
    public decimal? ScreenNumber { get; private set; }

    /// <summary>
    /// LanguageNumber of the MobileScreenName
    /// LanguageNumber الخاص بـ MobileScreenName
    /// </summary>
    public decimal? LanguageNumber { get; private set; }

    /// <summary>
    /// ScreenName of the MobileScreenName
    /// ScreenName الخاص بـ MobileScreenName
    /// </summary>
    public string ScreenName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to MobileScreen
    /// </summary>
    public MobileScreen MobileScreen { get; private set; }
    #endregion
}
}
