using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApprovedUserDetail Entity
/// </summary>
public class ApprovedUserDetail : Entity<ApprovedUserDetailId>
{
    private ApprovedUserDetail() { }

    /// <summary>
    /// The unique identifier for the ApprovedUserDetail
    /// المعرف الفريد لـ ApprovedUserDetail
    /// </summary>
    public ApprovedUserDetailId Id { get; private set; }

    /// <summary>
    /// UserId of the ApprovedUserDetail
    /// UserId الخاص بـ ApprovedUserDetail
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// LevelNumber of the ApprovedUserDetail
    /// LevelNumber الخاص بـ ApprovedUserDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// DocTyp of the ApprovedUserDetail
    /// DocTyp الخاص بـ ApprovedUserDetail
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// TypeNumberShort of the ApprovedUserDetail
    /// TypeNumberShort الخاص بـ ApprovedUserDetail
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// PrivilegeFlag of the ApprovedUserDetail
    /// PrivilegeFlag الخاص بـ ApprovedUserDetail
    /// </summary>
    public decimal? PrivilegeFlag { get; private set; }

    /// <summary>
    /// FAmount of the ApprovedUserDetail
    /// FAmount الخاص بـ ApprovedUserDetail
    /// </summary>
    public decimal? FAmount { get; private set; }

    /// <summary>
    /// TAmount of the ApprovedUserDetail
    /// TAmount الخاص بـ ApprovedUserDetail
    /// </summary>
    public decimal? TAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ApprovedUser
    /// </summary>
    public ApprovedUser ApprovedUser { get; private set; }
    #endregion
}
}
