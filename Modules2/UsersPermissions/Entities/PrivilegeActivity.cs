using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeActivity Entity
/// </summary>
public class PrivilegeActivity : Entity<PrivilegeActivityId>
{

    private PrivilegeActivity() { }

    public PrivilegeActivity(PrivilegeActivityId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PrivilegeActivity
    /// المعرف الفريد لـ PrivilegeActivity
    /// </summary>
    public PrivilegeActivityId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
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

