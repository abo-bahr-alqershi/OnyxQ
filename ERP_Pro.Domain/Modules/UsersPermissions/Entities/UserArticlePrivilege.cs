using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArticlesContent.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserArticlePrivilege Entity
/// </summary>
public class UserArticlePrivilege : Entity<UserArticlePrivilegeId>
{

    private UserArticlePrivilege() { }

    public UserArticlePrivilege(UserArticlePrivilegeId id, decimal? userId)
    {
        Id = id;
        UserId = userId;
    }

    /// <summary>
    /// The unique identifier for the UserArticlePrivilege
    /// المعرف الفريد لـ UserArticlePrivilege
    /// </summary>
    public UserArticlePrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the UserArticlePrivilege
    /// UserId الخاص بـ UserArticlePrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AdditionalFlag of the UserArticlePrivilege
    /// AdditionalFlag الخاص بـ UserArticlePrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the UserArticlePrivilege
    /// ViewFlag الخاص بـ UserArticlePrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Article Article { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

