using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// CostCenterPermission Entity
/// </summary>
public class CostCenterPermission : Entity<CostCenterPermissionId>
{
    private CostCenterPermission() { }

    /// <summary>
    /// The unique identifier for the CostCenterPermission
    /// المعرف الفريد لـ CostCenterPermission
    /// </summary>
    public CostCenterPermissionId Id { get; private set; }

    /// <summary>
    /// UserId of the CostCenterPermission
    /// UserId الخاص بـ CostCenterPermission
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// CostCenterCode of the CostCenterPermission
    /// CostCenterCode الخاص بـ CostCenterPermission
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// AdditionalFlag of the CostCenterPermission
    /// AdditionalFlag الخاص بـ CostCenterPermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the CostCenterPermission
    /// ViewFlag الخاص بـ CostCenterPermission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
