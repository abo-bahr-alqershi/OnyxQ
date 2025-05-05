using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryItemCostOrder Entity
/// </summary>
public class InventoryItemCostOrder : Entity<InventoryItemCostOrderId>
{

    private InventoryItemCostOrder() { }

    public InventoryItemCostOrder(InventoryItemCostOrderId id, decimal? customerCodeShort, decimal? cstType)
    {
        Id = id;
        CustomerCodeShort = customerCodeShort;
        CstType = cstType;
    }

    /// <summary>
    /// The unique identifier for the InventoryItemCostOrder
    /// المعرف الفريد لـ InventoryItemCostOrder
    /// </summary>
    public InventoryItemCostOrderId Id { get; private set; }

    /// <summary>
    /// CustomerCodeShort of the InventoryItemCostOrder
    /// CustomerCodeShort الخاص بـ InventoryItemCostOrder
    /// </summary>
    public decimal? CustomerCodeShort { get; private set; }

    /// <summary>
    /// CstType of the InventoryItemCostOrder
    /// CstType الخاص بـ InventoryItemCostOrder
    /// </summary>
    public decimal? CstType { get; private set; }

    /// <summary>
    /// CustomerOrder of the InventoryItemCostOrder
    /// CustomerOrder الخاص بـ InventoryItemCostOrder
    /// </summary>
    public decimal? CustomerOrder { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

