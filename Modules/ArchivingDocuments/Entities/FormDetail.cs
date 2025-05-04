using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// FormDetail Entity
/// </summary>
public class FormDetail : Entity<FormDetailId>
{
    private FormDetail() { }

    /// <summary>
    /// The unique identifier for the FormDetail
    /// المعرف الفريد لـ FormDetail
    /// </summary>
    public FormDetailId Id { get; private set; }

    /// <summary>
    /// FSystem of the FormDetail
    /// FSystem الخاص بـ FormDetail
    /// </summary>
    public string FSystem { get; private set; }

    /// <summary>
    /// SystemNumber of the FormDetail
    /// SystemNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// FormNumber of the FormDetail
    /// FormNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// FParentNumber of the FormDetail
    /// FParentNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? FParentNumber { get; private set; }

    /// <summary>
    /// FFileName of the FormDetail
    /// FFileName الخاص بـ FormDetail
    /// </summary>
    public string FFileName { get; private set; }

    /// <summary>
    /// FBtPrivilege of the FormDetail
    /// FBtPrivilege الخاص بـ FormDetail
    /// </summary>
    public decimal? FBtPrivilege { get; private set; }

    /// <summary>
    /// FInactiveFlag of the FormDetail
    /// FInactiveFlag الخاص بـ FormDetail
    /// </summary>
    public decimal? FInactiveFlag { get; private set; }

    /// <summary>
    /// FOrderNumber of the FormDetail
    /// FOrderNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? FOrderNumber { get; private set; }

    /// <summary>
    /// ScreenOriginal of the FormDetail
    /// ScreenOriginal الخاص بـ FormDetail
    /// </summary>
    public decimal? ScreenOriginal { get; private set; }

    /// <summary>
    /// ScreenThemeNumber of the FormDetail
    /// ScreenThemeNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? ScreenThemeNumber { get; private set; }

    /// <summary>
    /// ScreenType of the FormDetail
    /// ScreenType الخاص بـ FormDetail
    /// </summary>
    public decimal? ScreenType { get; private set; }

    /// <summary>
    /// DocTyp of the FormDetail
    /// DocTyp الخاص بـ FormDetail
    /// </summary>
    public decimal? DocTyp { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: FormDetail to ScreenLink
    /// </summary>
    public IReadOnlyCollection<ScreenLink> ScreenLinks { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to SystemType
    /// </summary>
    public IReadOnlyCollection<SystemType> SystemTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to UserTypePrivilege
    /// </summary>
    public IReadOnlyCollection<UserTypePrivilege> UserTypePrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to Audit
    /// </summary>
    public IReadOnlyCollection<Audit> Audits { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to Permission
    /// </summary>
    public IReadOnlyCollection<Permission> Permissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to FavoriteScreen
    /// </summary>
    public IReadOnlyCollection<FavoriteScreen> FavoriteScreens { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to FormFieldPrivilege
    /// </summary>
    public IReadOnlyCollection<FormFieldPrivilege> FormFieldPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to FormName
    /// </summary>
    public IReadOnlyCollection<FormName> FormNames { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to FormField
    /// </summary>
    public IReadOnlyCollection<FormField> FormFields { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to FormDetail
    /// </summary>
    public IReadOnlyCollection<FormDetail> FormDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormDetail to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
