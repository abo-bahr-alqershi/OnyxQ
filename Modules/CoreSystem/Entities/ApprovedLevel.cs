using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApprovedLevel Entity
/// </summary>
public class ApprovedLevel : Entity<ApprovedLevelId>
{
    private ApprovedLevel() { }

    /// <summary>
    /// The unique identifier for the ApprovedLevel
    /// المعرف الفريد لـ ApprovedLevel
    /// </summary>
    public ApprovedLevelId Id { get; private set; }

    /// <summary>
    /// LevelNumber of the ApprovedLevel
    /// LevelNumber الخاص بـ ApprovedLevel
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// LevelName of the ApprovedLevel
    /// LevelName الخاص بـ ApprovedLevel
    /// </summary>
    public string LevelName { get; private set; }

    /// <summary>
    /// DocTyp of the ApprovedLevel
    /// DocTyp الخاص بـ ApprovedLevel
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ApprovedLevel
    /// OrderNumberShort الخاص بـ ApprovedLevel
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// FormNumber of the ApprovedLevel
    /// FormNumber الخاص بـ ApprovedLevel
    /// </summary>
    public decimal? FormNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ApprovedLevel to ApprovedMovement
    /// </summary>
    public IReadOnlyCollection<ApprovedMovement> ApprovedMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: ApprovedLevel to ApprovedUser
    /// </summary>
    public IReadOnlyCollection<ApprovedUser> ApprovedUsers { get; private set; }
    /// <summary>
    /// One-to-many relationship: ApprovedLevel to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
