using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// FavoriteScreen Entity
/// </summary>
public class FavoriteScreen : Entity<FavoriteScreenId>
{

    private FavoriteScreen() { }

    public FavoriteScreen(FavoriteScreenId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the FavoriteScreen
    /// المعرف الفريد لـ FavoriteScreen
    /// </summary>
    public FavoriteScreenId Id { get; private set; }

    /// <summary>
    /// OrderNumberShort of the FavoriteScreen
    /// OrderNumberShort الخاص بـ FavoriteScreen
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// SystemNumber of the FavoriteScreen
    /// SystemNumber الخاص بـ FavoriteScreen
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

