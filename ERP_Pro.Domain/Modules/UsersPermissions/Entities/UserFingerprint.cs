using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserFingerprint Entity
/// </summary>
public class UserFingerprint : Entity<UserFingerprintId>
{

    private UserFingerprint() { }

    public UserFingerprint(UserFingerprintId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the UserFingerprint
    /// المعرف الفريد لـ UserFingerprint
    /// </summary>
    public UserFingerprintId Id { get; private set; }

    /// <summary>
    /// UserId of the UserFingerprint
    /// UserId الخاص بـ UserFingerprint
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// UserFingerId of the UserFingerprint
    /// UserFingerId الخاص بـ UserFingerprint
    /// </summary>
    public decimal? UserFingerId { get; private set; }

    /// <summary>
    /// UserFingerNumber of the UserFingerprint
    /// UserFingerNumber الخاص بـ UserFingerprint
    /// </summary>
    public decimal? UserFingerNumber { get; private set; }

    /// <summary>
    /// UserFingerString of the UserFingerprint
    /// UserFingerString الخاص بـ UserFingerprint
    /// </summary>
    public string UserFingerString { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
