using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeCustomer Entity
/// </summary>
public class PrivilegeCustomer : Entity<PrivilegeCustomerId>
{
    private PrivilegeCustomer() { }

    /// <summary>
    /// The unique identifier for the PrivilegeCustomer
    /// المعرف الفريد لـ PrivilegeCustomer
    /// </summary>
    public PrivilegeCustomerId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegeCustomer
    /// UserId الخاص بـ PrivilegeCustomer
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// CCode of the PrivilegeCustomer
    /// CCode الخاص بـ PrivilegeCustomer
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the PrivilegeCustomer
    /// AccountCurrency الخاص بـ PrivilegeCustomer
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeCustomer
    /// AdditionalFlag الخاص بـ PrivilegeCustomer
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeCustomer
    /// ViewFlag الخاص بـ PrivilegeCustomer
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to CustomerCurrency
    /// </summary>
    public CustomerCurrency CustomerCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
