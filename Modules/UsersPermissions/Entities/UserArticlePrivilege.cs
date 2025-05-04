using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArticlesContent.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserArticlePrivilege Entity
/// </summary>
public class UserArticlePrivilege : Entity<UserArticlePrivilegeId>
{
    private UserArticlePrivilege() { }

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
    /// ArticleNumber of the UserArticlePrivilege
    /// ArticleNumber الخاص بـ UserArticlePrivilege
    /// </summary>
    public decimal? ArticleNumber { get; private set; }

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
    /// ManyToOne relationship to Article
    /// </summary>
    public Article Article { get; private set; }
    #endregion
}
}
