using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerGroup Entity
/// </summary>
public class CustomerGroup : Entity<CustomerGroupId>
{

    private CustomerGroup() { }

    public CustomerGroup(CustomerGroupId id, decimal? cGroupCode)
    {
        Id = id;
        CGroupCode = cGroupCode;
    }

    /// <summary>
    /// The unique identifier for the CustomerGroup
    /// المعرف الفريد لـ CustomerGroup
    /// </summary>
    public CustomerGroupId Id { get; private set; }

    /// <summary>
    /// CGroupCode of the CustomerGroup
    /// CGroupCode الخاص بـ CustomerGroup
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CGroupAName of the CustomerGroup
    /// CGroupAName الخاص بـ CustomerGroup
    /// </summary>
    public string CGroupAName { get; private set; }

    /// <summary>
    /// CGroupEName of the CustomerGroup
    /// CGroupEName الخاص بـ CustomerGroup
    /// </summary>
    public string CGroupEName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
