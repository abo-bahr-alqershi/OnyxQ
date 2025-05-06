using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.FixedAssets.ValueObjects;
namespace ERP_Pro.Domain.ERP.FixedAssets.Entities
{
/// <summary>
/// DateOptionPrivilege Entity
/// </summary>
public class DateOptionPrivilege : Entity<DateOptionPrivilegeId>
{
    private readonly List<DateOption> _dateOption = new List<DateOption>();
    private readonly List<User> _user = new List<User>();

    private DateOptionPrivilege() { }

    public DateOptionPrivilege(DateOptionPrivilegeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the DateOptionPrivilege
    /// المعرف الفريد لـ DateOptionPrivilege
    /// </summary>
    public DateOptionPrivilegeId Id { get; private set; }

    /// <summary>
    /// OptionFlag of the DateOptionPrivilege
    /// OptionFlag الخاص بـ DateOptionPrivilege
    /// </summary>
    public decimal? OptionFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<DateOption> DateOption => _dateOption;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<User> User => _user;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

