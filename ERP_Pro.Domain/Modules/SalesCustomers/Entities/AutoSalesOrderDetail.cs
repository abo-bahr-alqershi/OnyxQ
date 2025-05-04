using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// AutoSalesOrderDetail Entity
/// </summary>
public class AutoSalesOrderDetail : Entity<AutoSalesOrderDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<AutoSalesOrderMaster> _autoSalesOrderMaster = new List<AutoSalesOrderMaster>();

    private AutoSalesOrderDetail() { }

    public AutoSalesOrderDetail(AutoSalesOrderDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AutoSalesOrderDetail
    /// المعرف الفريد لـ AutoSalesOrderDetail
    /// </summary>
    public AutoSalesOrderDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AutoSalesOrderDetail
    /// DocNo الخاص بـ AutoSalesOrderDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemUnit of the AutoSalesOrderDetail
    /// ItemUnit الخاص بـ AutoSalesOrderDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemQuantity of the AutoSalesOrderDetail
    /// ItemQuantity الخاص بـ AutoSalesOrderDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AutoSalesOrderMaster> AutoSalesOrderMaster => _autoSalesOrderMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
