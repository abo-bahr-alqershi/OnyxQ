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

    public PrivilegeCustomer(PrivilegeCustomerId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PrivilegeCustomer
    /// المعرف الفريد لـ PrivilegeCustomer
    /// </summary>
    public PrivilegeCustomerId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerCurrency CustomerCurrency { get; private set; }
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
