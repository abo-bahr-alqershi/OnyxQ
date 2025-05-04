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
    private AutoSalesOrderDetail() { }

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
    /// DocSrl of the AutoSalesOrderDetail
    /// DocSrl الخاص بـ AutoSalesOrderDetail
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// ItemCode of the AutoSalesOrderDetail
    /// ItemCode الخاص بـ AutoSalesOrderDetail
    /// </summary>
    public string ItemCode { get; private set; }

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
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AutoSalesOrderMaster
    /// </summary>
    public AutoSalesOrderMaster AutoSalesOrderMaster { get; private set; }
    #endregion
}
}
