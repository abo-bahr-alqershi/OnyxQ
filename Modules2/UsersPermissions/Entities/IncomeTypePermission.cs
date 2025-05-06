using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// IncomeTypePermission Entity
/// </summary>
public class IncomeTypePermission : Entity<IncomeTypePermissionId>
{

    private IncomeTypePermission() { }

    public IncomeTypePermission(IncomeTypePermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the IncomeTypePermission
    /// المعرف الفريد لـ IncomeTypePermission
    /// </summary>
    public IncomeTypePermissionId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the IncomeTypePermission
    /// AdditionalFlag الخاص بـ IncomeTypePermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the IncomeTypePermission
    /// ViewFlag الخاص بـ IncomeTypePermission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public IncomeType IncomeType { get; private set; }
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

