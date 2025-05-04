using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// OutgoingTypePermission Entity
/// </summary>
public class OutgoingTypePermission : Entity<OutgoingTypePermissionId>
{

    private OutgoingTypePermission() { }

    public OutgoingTypePermission(OutgoingTypePermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the OutgoingTypePermission
    /// المعرف الفريد لـ OutgoingTypePermission
    /// </summary>
    public OutgoingTypePermissionId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the OutgoingTypePermission
    /// AdditionalFlag الخاص بـ OutgoingTypePermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the OutgoingTypePermission
    /// ViewFlag الخاص بـ OutgoingTypePermission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public OutgoingType OutgoingType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
