using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// FavoriteScreen Entity
/// </summary>
public class FavoriteScreen : Entity<FavoriteScreenId>
{
    private FavoriteScreen() { }

    /// <summary>
    /// The unique identifier for the FavoriteScreen
    /// المعرف الفريد لـ FavoriteScreen
    /// </summary>
    public FavoriteScreenId Id { get; private set; }

    /// <summary>
    /// UserId of the FavoriteScreen
    /// UserId الخاص بـ FavoriteScreen
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// FormNumber of the FavoriteScreen
    /// FormNumber الخاص بـ FavoriteScreen
    /// </summary>
    public decimal? FormNumber { get; private set; }

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
    /// ManyToOne relationship to FormDetail
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
