using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// IncomeTypePermission Entity
/// </summary>
public class IncomeTypePermission : Entity<IncomeTypePermissionId>
{
    private IncomeTypePermission() { }

    /// <summary>
    /// The unique identifier for the IncomeTypePermission
    /// المعرف الفريد لـ IncomeTypePermission
    /// </summary>
    public IncomeTypePermissionId Id { get; private set; }

    /// <summary>
    /// UserId of the IncomeTypePermission
    /// UserId الخاص بـ IncomeTypePermission
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// IncomeType of the IncomeTypePermission
    /// IncomeType الخاص بـ IncomeTypePermission
    /// </summary>
    public decimal? IncomeType { get; private set; }

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
    /// ManyToOne relationship to IncomeType
    /// </summary>
    public IncomeType IncomeType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
