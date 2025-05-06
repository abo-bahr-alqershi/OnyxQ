using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// Permission Entity
/// </summary>
public class Permission : Entity<PermissionId>
{

    private Permission() { }

    public Permission(PermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the Permission
    /// المعرف الفريد لـ Permission
    /// </summary>
    public PermissionId Id { get; private set; }

    /// <summary>
    /// IncludeFlag of the Permission
    /// IncludeFlag الخاص بـ Permission
    /// </summary>
    public decimal? IncludeFlag { get; private set; }

    /// <summary>
    /// AdditionalFlag of the Permission
    /// AdditionalFlag الخاص بـ Permission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// DelFlag of the Permission
    /// DelFlag الخاص بـ Permission
    /// </summary>
    public decimal? DelFlag { get; private set; }

    /// <summary>
    /// ModifyFlag of the Permission
    /// ModifyFlag الخاص بـ Permission
    /// </summary>
    public decimal? ModifyFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the Permission
    /// ViewFlag الخاص بـ Permission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    /// <summary>
    /// PrintFlag of the Permission
    /// PrintFlag الخاص بـ Permission
    /// </summary>
    public decimal? PrintFlag { get; private set; }

    /// <summary>
    /// ViewReportFlag of the Permission
    /// ViewReportFlag الخاص بـ Permission
    /// </summary>
    public decimal? ViewReportFlag { get; private set; }

    /// <summary>
    /// VerifyFlagShort of the Permission
    /// VerifyFlagShort الخاص بـ Permission
    /// </summary>
    public decimal? VerifyFlagShort { get; private set; }

    /// <summary>
    /// PostFlag of the Permission
    /// PostFlag الخاص بـ Permission
    /// </summary>
    public decimal? PostFlag { get; private set; }

    /// <summary>
    /// FOrderNumber of the Permission
    /// FOrderNumber الخاص بـ Permission
    /// </summary>
    public decimal? FOrderNumber { get; private set; }

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

