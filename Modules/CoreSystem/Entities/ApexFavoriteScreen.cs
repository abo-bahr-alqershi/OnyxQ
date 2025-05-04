using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApexFavoriteScreen Entity
/// </summary>
public class ApexFavoriteScreen : Entity<ApexFavoriteScreenId>
{
    private ApexFavoriteScreen() { }

    /// <summary>
    /// The unique identifier for the ApexFavoriteScreen
    /// المعرف الفريد لـ ApexFavoriteScreen
    /// </summary>
    public ApexFavoriteScreenId Id { get; private set; }

    /// <summary>
    /// ScreenNumber of the ApexFavoriteScreen
    /// ScreenNumber الخاص بـ ApexFavoriteScreen
    /// </summary>
    public decimal? ScreenNumber { get; private set; }

    /// <summary>
    /// UserId of the ApexFavoriteScreen
    /// UserId الخاص بـ ApexFavoriteScreen
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ApexFavoriteScreen
    /// OrderNumberShort الخاص بـ ApexFavoriteScreen
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ApexScreen
    /// </summary>
    public ApexScreen ApexScreen { get; private set; }
    #endregion
}
}
