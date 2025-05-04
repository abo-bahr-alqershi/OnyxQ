using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ScreenLink Entity
/// </summary>
public class ScreenLink : Entity<ScreenLinkId>
{
    private ScreenLink() { }

    /// <summary>
    /// The unique identifier for the ScreenLink
    /// المعرف الفريد لـ ScreenLink
    /// </summary>
    public ScreenLinkId Id { get; private set; }

    /// <summary>
    /// UserId of the ScreenLink
    /// UserId الخاص بـ ScreenLink
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// FormNumber of the ScreenLink
    /// FormNumber الخاص بـ ScreenLink
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// FormNumberLinked of the ScreenLink
    /// FormNumberLinked الخاص بـ ScreenLink
    /// </summary>
    public decimal? FormNumberLinked { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ScreenLink
    /// OrderNumberShort الخاص بـ ScreenLink
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// SystemNumber of the ScreenLink
    /// SystemNumber الخاص بـ ScreenLink
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
