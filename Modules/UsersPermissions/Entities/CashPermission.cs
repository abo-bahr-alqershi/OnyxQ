using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// CashPermission Entity
/// </summary>
public class CashPermission : Entity<CashPermissionId>
{
    private CashPermission() { }

    /// <summary>
    /// The unique identifier for the CashPermission
    /// المعرف الفريد لـ CashPermission
    /// </summary>
    public CashPermissionId Id { get; private set; }

    /// <summary>
    /// UserId of the CashPermission
    /// UserId الخاص بـ CashPermission
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// CashNumber of the CashPermission
    /// CashNumber الخاص بـ CashPermission
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the CashPermission
    /// AccountCurrency الخاص بـ CashPermission
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CashType of the CashPermission
    /// CashType الخاص بـ CashPermission
    /// </summary>
    public decimal? CashType { get; private set; }

    /// <summary>
    /// AdditionalFlag of the CashPermission
    /// AdditionalFlag الخاص بـ CashPermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the CashPermission
    /// ViewFlag الخاص بـ CashPermission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    /// <summary>
    /// Payment of the CashPermission
    /// Payment الخاص بـ CashPermission
    /// </summary>
    public decimal? Payment { get; private set; }

    /// <summary>
    /// ReceivedFlag of the CashPermission
    /// ReceivedFlag الخاص بـ CashPermission
    /// </summary>
    public decimal? ReceivedFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
