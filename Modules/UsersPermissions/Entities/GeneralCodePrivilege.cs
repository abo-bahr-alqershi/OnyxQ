using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// GeneralCodePrivilege Entity
/// </summary>
public class GeneralCodePrivilege : Entity<GeneralCodePrivilegeId>
{
    private GeneralCodePrivilege() { }

    /// <summary>
    /// The unique identifier for the GeneralCodePrivilege
    /// المعرف الفريد لـ GeneralCodePrivilege
    /// </summary>
    public GeneralCodePrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the GeneralCodePrivilege
    /// UserId الخاص بـ GeneralCodePrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// MainType of the GeneralCodePrivilege
    /// MainType الخاص بـ GeneralCodePrivilege
    /// </summary>
    public decimal? MainType { get; private set; }

    /// <summary>
    /// SubType of the GeneralCodePrivilege
    /// SubType الخاص بـ GeneralCodePrivilege
    /// </summary>
    public decimal? SubType { get; private set; }

    /// <summary>
    /// AdditionalFlag of the GeneralCodePrivilege
    /// AdditionalFlag الخاص بـ GeneralCodePrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the GeneralCodePrivilege
    /// ViewFlag الخاص بـ GeneralCodePrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    /// <summary>
    /// FillFlag of the GeneralCodePrivilege
    /// FillFlag الخاص بـ GeneralCodePrivilege
    /// </summary>
    public decimal? FillFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
