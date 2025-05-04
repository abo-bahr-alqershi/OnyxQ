using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ScreenCssPrivilege Entity
/// </summary>
public class ScreenCssPrivilege : Entity<ScreenCssPrivilegeId>
{

    private ScreenCssPrivilege() { }

    public ScreenCssPrivilege(ScreenCssPrivilegeId id, decimal? screenNumber)
    {
        Id = id;
        ScreenNumber = screenNumber;
    }

    /// <summary>
    /// The unique identifier for the ScreenCssPrivilege
    /// المعرف الفريد لـ ScreenCssPrivilege
    /// </summary>
    public ScreenCssPrivilegeId Id { get; private set; }

    /// <summary>
    /// ScreenNumber of the ScreenCssPrivilege
    /// ScreenNumber الخاص بـ ScreenCssPrivilege
    /// </summary>
    public decimal? ScreenNumber { get; private set; }

    /// <summary>
    /// IncomeFlag of the ScreenCssPrivilege
    /// IncomeFlag الخاص بـ ScreenCssPrivilege
    /// </summary>
    public decimal? IncomeFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
