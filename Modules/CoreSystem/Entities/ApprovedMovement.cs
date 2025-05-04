using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApprovedMovement Entity
/// </summary>
public class ApprovedMovement : Entity<ApprovedMovementId>
{
    private ApprovedMovement() { }

    /// <summary>
    /// The unique identifier for the ApprovedMovement
    /// المعرف الفريد لـ ApprovedMovement
    /// </summary>
    public ApprovedMovementId Id { get; private set; }

    /// <summary>
    /// LevelNumber of the ApprovedMovement
    /// LevelNumber الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// DocTyp of the ApprovedMovement
    /// DocTyp الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// DocSer of the ApprovedMovement
    /// DocSer الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocNo of the ApprovedMovement
    /// DocNo الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocJvTyp of the ApprovedMovement
    /// DocJvTyp الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? DocJvTyp { get; private set; }

    /// <summary>
    /// DocDate of the ApprovedMovement
    /// DocDate الخاص بـ ApprovedMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ApprovedFlagShort of the ApprovedMovement
    /// ApprovedFlagShort الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? ApprovedFlagShort { get; private set; }

    /// <summary>
    /// ApprovedByUserId of the ApprovedMovement
    /// ApprovedByUserId الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? ApprovedByUserId { get; private set; }

    /// <summary>
    /// ApprovedDate of the ApprovedMovement
    /// ApprovedDate الخاص بـ ApprovedMovement
    /// </summary>
    public DateTime? ApprovedDate { get; private set; }

    /// <summary>
    /// ApprovedDescription of the ApprovedMovement
    /// ApprovedDescription الخاص بـ ApprovedMovement
    /// </summary>
    public string ApprovedDescription { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ApprovedMovement
    /// OrderNumberShort الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ApprovedMovement
    /// CompanyNumberShort الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ApprovedMovement
    /// BranchNumber الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ApprovedMovement
    /// BranchYear الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ApprovedMovement
    /// BranchUser الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocAmt of the ApprovedMovement
    /// DocAmt الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ApprovedMovement
    /// ExternalPostFlag الخاص بـ ApprovedMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ApprovedLevel
    /// </summary>
    public ApprovedLevel ApprovedLevel { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
