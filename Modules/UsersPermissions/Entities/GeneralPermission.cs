using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// GeneralPermission Entity
/// </summary>
public class GeneralPermission : Entity<GeneralPermissionId>
{
    private GeneralPermission() { }

    /// <summary>
    /// The unique identifier for the GeneralPermission
    /// المعرف الفريد لـ GeneralPermission
    /// </summary>
    public GeneralPermissionId Id { get; private set; }

    /// <summary>
    /// UserId of the GeneralPermission
    /// UserId الخاص بـ GeneralPermission
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// GuarantorCode of the GeneralPermission
    /// GuarantorCode الخاص بـ GeneralPermission
    /// </summary>
    public string GuarantorCode { get; private set; }

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
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion
}
}
