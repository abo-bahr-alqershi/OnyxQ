using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerItemActivity Entity
/// </summary>
public class CustomerItemActivity : Entity<CustomerItemActivityId>
{
    private readonly List<ItemActivity> _itemActivity = new List<ItemActivity>();
    private readonly List<Customer> _customer = new List<Customer>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private CustomerItemActivity() { }

    public CustomerItemActivity(CustomerItemActivityId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerItemActivity
    /// المعرف الفريد لـ CustomerItemActivity
    /// </summary>
    public CustomerItemActivityId Id { get; private set; }

    /// <summary>
    /// ShowAvailableQuantityFlag of the CustomerItemActivity
    /// ShowAvailableQuantityFlag الخاص بـ CustomerItemActivity
    /// </summary>
    public decimal? ShowAvailableQuantityFlag { get; private set; }

    /// <summary>
    /// AllowAddSalesOrderFlag of the CustomerItemActivity
    /// AllowAddSalesOrderFlag الخاص بـ CustomerItemActivity
    /// </summary>
    public decimal? AllowAddSalesOrderFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemActivity> ItemActivity => _itemActivity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Customer> Customer => _customer;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

