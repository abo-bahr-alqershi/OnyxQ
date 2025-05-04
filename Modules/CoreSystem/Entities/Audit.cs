using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// Audit Entity
/// </summary>
public class Audit : Entity<AuditId>
{
    private Audit() { }

    /// <summary>
    /// The unique identifier for the Audit
    /// المعرف الفريد لـ Audit
    /// </summary>
    public AuditId Id { get; private set; }

    /// <summary>
    /// UserId of the Audit
    /// UserId الخاص بـ Audit
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// FormNumber of the Audit
    /// FormNumber الخاص بـ Audit
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// AuditModifyFlag of the Audit
    /// AuditModifyFlag الخاص بـ Audit
    /// </summary>
    public decimal? AuditModifyFlag { get; private set; }

    /// <summary>
    /// AuditDeleteFlag of the Audit
    /// AuditDeleteFlag الخاص بـ Audit
    /// </summary>
    public decimal? AuditDeleteFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to FormDetail
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
