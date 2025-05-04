using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerItemActivity Entity
/// </summary>
public class CustomerItemActivity : Entity<CustomerItemActivityId>
{
    private CustomerItemActivity() { }

    /// <summary>
    /// The unique identifier for the CustomerItemActivity
    /// المعرف الفريد لـ CustomerItemActivity
    /// </summary>
    public CustomerItemActivityId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerItemActivity
    /// CCode الخاص بـ CustomerItemActivity
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the CustomerItemActivity
    /// WarehouseCode الخاص بـ CustomerItemActivity
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the CustomerItemActivity
    /// ActivityNumber الخاص بـ CustomerItemActivity
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

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
    /// ManyToOne relationship to ItemActivity
    /// </summary>
    public ItemActivity ItemActivity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
