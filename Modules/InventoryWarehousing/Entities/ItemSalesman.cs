using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemSalesman Entity
/// </summary>
public class ItemSalesman : Entity<ItemSalesmanId>
{
    private ItemSalesman() { }

    /// <summary>
    /// The unique identifier for the ItemSalesman
    /// المعرف الفريد لـ ItemSalesman
    /// </summary>
    public ItemSalesmanId Id { get; private set; }

    /// <summary>
    /// RepCode of the ItemSalesman
    /// RepCode الخاص بـ ItemSalesman
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ItemCode of the ItemSalesman
    /// ItemCode الخاص بـ ItemSalesman
    /// </summary>
    public string ItemCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    #endregion
}
}
