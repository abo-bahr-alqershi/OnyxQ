using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// GeneralPermission Entity
/// </summary>
public class GeneralPermission : Entity<GeneralPermissionId>
{

    private GeneralPermission() { }

    public GeneralPermission(GeneralPermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralPermission
    /// المعرف الفريد لـ GeneralPermission
    /// </summary>
    public GeneralPermissionId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the GeneralPermission
    /// AdditionalFlag الخاص بـ GeneralPermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the GeneralPermission
    /// ViewFlag الخاص بـ GeneralPermission
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
    public GroupDetail GroupDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

