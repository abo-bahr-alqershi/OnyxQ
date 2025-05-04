using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// SystemFlagPrivilege Entity
/// </summary>
public class SystemFlagPrivilege : Entity<SystemFlagPrivilegeId>
{
    private SystemFlagPrivilege() { }

    /// <summary>
    /// The unique identifier for the SystemFlagPrivilege
    /// المعرف الفريد لـ SystemFlagPrivilege
    /// </summary>
    public SystemFlagPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the SystemFlagPrivilege
    /// UserId الخاص بـ SystemFlagPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// FlagCode of the SystemFlagPrivilege
    /// FlagCode الخاص بـ SystemFlagPrivilege
    /// </summary>
    public string FlagCode { get; private set; }

    /// <summary>
    /// FlagValue of the SystemFlagPrivilege
    /// FlagValue الخاص بـ SystemFlagPrivilege
    /// </summary>
    public decimal? FlagValue { get; private set; }

    /// <summary>
    /// PrivateFlag of the SystemFlagPrivilege
    /// PrivateFlag الخاص بـ SystemFlagPrivilege
    /// </summary>
    public decimal? PrivateFlag { get; private set; }
}
}
