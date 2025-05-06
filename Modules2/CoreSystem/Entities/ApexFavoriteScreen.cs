using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApexFavoriteScreen Entity
/// </summary>
public class ApexFavoriteScreen : Entity<ApexFavoriteScreenId>
{

    private ApexFavoriteScreen() { }

    public ApexFavoriteScreen(ApexFavoriteScreenId id, decimal? userId)
    {
        Id = id;
        UserId = userId;
    }

    /// <summary>
    /// The unique identifier for the ApexFavoriteScreen
    /// المعرف الفريد لـ ApexFavoriteScreen
    /// </summary>
    public ApexFavoriteScreenId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public ApexScreen ApexScreen { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
