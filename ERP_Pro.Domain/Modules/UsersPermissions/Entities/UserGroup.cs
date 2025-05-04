using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserGroup Entity
/// </summary>
public class UserGroup : Entity<UserGroupId>
{

    private UserGroup() { }

    public UserGroup(UserGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the UserGroup
    /// المعرف الفريد لـ UserGroup
    /// </summary>
    public UserGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the UserGroup
    /// GroupNumber الخاص بـ UserGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupNameArabic of the UserGroup
    /// GroupNameArabic الخاص بـ UserGroup
    /// </summary>
    public string GroupNameArabic { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the UserGroup
    /// GroupNameEnglish الخاص بـ UserGroup
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    /// <summary>
    /// AdminUser of the UserGroup
    /// AdminUser الخاص بـ UserGroup
    /// </summary>
    public decimal? AdminUser { get; private set; }

    /// <summary>
    /// RestaurantGroup of the UserGroup
    /// RestaurantGroup الخاص بـ UserGroup
    /// </summary>
    public decimal? RestaurantGroup { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
