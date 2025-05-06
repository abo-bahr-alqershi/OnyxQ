using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemSalesman Entity
/// </summary>
public class ItemSalesman : Entity<ItemSalesmanId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<Salesman> _salesman = new List<Salesman>();

    private ItemSalesman() { }

    public ItemSalesman(ItemSalesmanId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemSalesman
    /// المعرف الفريد لـ ItemSalesman
    /// </summary>
    public ItemSalesmanId Id { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Salesman> Salesman => _salesman;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

