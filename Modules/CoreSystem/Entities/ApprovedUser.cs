using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApprovedUser Entity
/// </summary>
public class ApprovedUser : Entity<ApprovedUserId>
{
    private ApprovedUser() { }

    /// <summary>
    /// The unique identifier for the ApprovedUser
    /// المعرف الفريد لـ ApprovedUser
    /// </summary>
    public ApprovedUserId Id { get; private set; }

    /// <summary>
    /// LevelNumber of the ApprovedUser
    /// LevelNumber الخاص بـ ApprovedUser
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// DocTyp of the ApprovedUser
    /// DocTyp الخاص بـ ApprovedUser
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// UserId of the ApprovedUser
    /// UserId الخاص بـ ApprovedUser
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// PrivilegeFlag of the ApprovedUser
    /// PrivilegeFlag الخاص بـ ApprovedUser
    /// </summary>
    public decimal? PrivilegeFlag { get; private set; }

    /// <summary>
    /// FAmount of the ApprovedUser
    /// FAmount الخاص بـ ApprovedUser
    /// </summary>
    public decimal? FAmount { get; private set; }

    /// <summary>
    /// TAmount of the ApprovedUser
    /// TAmount الخاص بـ ApprovedUser
    /// </summary>
    public decimal? TAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ApprovedLevel
    /// </summary>
    public ApprovedLevel ApprovedLevel { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// One-to-many relationship: ApprovedUser to ApprovedUserDetail
    /// </summary>
    public IReadOnlyCollection<ApprovedUserDetail> ApprovedUserDetails { get; private set; }
    #endregion
}
}
