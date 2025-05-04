using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// SystemType Entity
/// </summary>
public class SystemType : Entity<SystemTypeId>
{
    private SystemType() { }

    /// <summary>
    /// The unique identifier for the SystemType
    /// المعرف الفريد لـ SystemType
    /// </summary>
    public SystemTypeId Id { get; private set; }

    /// <summary>
    /// FormNumber of the SystemType
    /// FormNumber الخاص بـ SystemType
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// ObjectNameShort of the SystemType
    /// ObjectNameShort الخاص بـ SystemType
    /// </summary>
    public string ObjectNameShort { get; private set; }

    /// <summary>
    /// TpName of the SystemType
    /// TpName الخاص بـ SystemType
    /// </summary>
    public string TpName { get; private set; }

    /// <summary>
    /// LabelNumberShort of the SystemType
    /// LabelNumberShort الخاص بـ SystemType
    /// </summary>
    public decimal? LabelNumberShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to FormDetail
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    /// <summary>
    /// One-to-many relationship: SystemType to UserTypePrivilege
    /// </summary>
    public IReadOnlyCollection<UserTypePrivilege> UserTypePrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: SystemType to FormDetail
    /// </summary>
    public IReadOnlyCollection<FormDetail> FormDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: SystemType to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
