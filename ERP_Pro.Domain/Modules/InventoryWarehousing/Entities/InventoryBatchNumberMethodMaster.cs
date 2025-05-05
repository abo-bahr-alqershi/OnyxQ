using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryBatchNumberMethodMaster Entity
/// </summary>
public class InventoryBatchNumberMethodMaster : AggregateRoot<InventoryBatchNumberMethodMasterId>
{

    private InventoryBatchNumberMethodMaster() { }

    public InventoryBatchNumberMethodMaster(InventoryBatchNumberMethodMasterId id, decimal? methodNumber)
    {
        Id = id;
        MethodNumber = methodNumber;
    }

    /// <summary>
    /// The unique identifier for the InventoryBatchNumberMethodMaster
    /// المعرف الفريد لـ InventoryBatchNumberMethodMaster
    /// </summary>
    public InventoryBatchNumberMethodMasterId Id { get; private set; }

    /// <summary>
    /// MethodNumber of the InventoryBatchNumberMethodMaster
    /// MethodNumber الخاص بـ InventoryBatchNumberMethodMaster
    /// </summary>
    public decimal? MethodNumber { get; private set; }

    /// <summary>
    /// MethodLastName of the InventoryBatchNumberMethodMaster
    /// MethodLastName الخاص بـ InventoryBatchNumberMethodMaster
    /// </summary>
    public string MethodLastName { get; private set; }

    /// <summary>
    /// MethodFirstName of the InventoryBatchNumberMethodMaster
    /// MethodFirstName الخاص بـ InventoryBatchNumberMethodMaster
    /// </summary>
    public string MethodFirstName { get; private set; }

    /// <summary>
    /// MethodNumberColumn of the InventoryBatchNumberMethodMaster
    /// MethodNumberColumn الخاص بـ InventoryBatchNumberMethodMaster
    /// </summary>
    public decimal? MethodNumberColumn { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

