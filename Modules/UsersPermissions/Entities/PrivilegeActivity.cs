using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeActivity Entity
/// </summary>
public class PrivilegeActivity : Entity<PrivilegeActivityId>
{
    private PrivilegeActivity() { }

    /// <summary>
    /// The unique identifier for the PrivilegeActivity
    /// المعرف الفريد لـ PrivilegeActivity
    /// </summary>
    public PrivilegeActivityId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegeActivity
    /// UserId الخاص بـ PrivilegeActivity
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// ActivityNumber of the PrivilegeActivity
    /// ActivityNumber الخاص بـ PrivilegeActivity
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeActivity
    /// AdditionalFlag الخاص بـ PrivilegeActivity
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeActivity
    /// ViewFlag الخاص بـ PrivilegeActivity
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
