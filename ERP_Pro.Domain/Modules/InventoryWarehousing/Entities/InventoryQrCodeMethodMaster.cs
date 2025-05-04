using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryQrCodeMethodMaster Entity
/// </summary>
public class InventoryQrCodeMethodMaster : Entity<InventoryQrCodeMethodMasterId>
{

    private InventoryQrCodeMethodMaster() { }

    public InventoryQrCodeMethodMaster(InventoryQrCodeMethodMasterId id, decimal? methodNumber)
    {
        Id = id;
        MethodNumber = methodNumber;
    }

    /// <summary>
    /// The unique identifier for the InventoryQrCodeMethodMaster
    /// المعرف الفريد لـ InventoryQrCodeMethodMaster
    /// </summary>
    public InventoryQrCodeMethodMasterId Id { get; private set; }

    /// <summary>
    /// MethodNumber of the InventoryQrCodeMethodMaster
    /// MethodNumber الخاص بـ InventoryQrCodeMethodMaster
    /// </summary>
    public decimal? MethodNumber { get; private set; }

    /// <summary>
    /// MethodLastName of the InventoryQrCodeMethodMaster
    /// MethodLastName الخاص بـ InventoryQrCodeMethodMaster
    /// </summary>
    public string MethodLastName { get; private set; }

    /// <summary>
    /// MethodFirstName of the InventoryQrCodeMethodMaster
    /// MethodFirstName الخاص بـ InventoryQrCodeMethodMaster
    /// </summary>
    public string MethodFirstName { get; private set; }

    /// <summary>
    /// MethodNumberColumn of the InventoryQrCodeMethodMaster
    /// MethodNumberColumn الخاص بـ InventoryQrCodeMethodMaster
    /// </summary>
    public decimal? MethodNumberColumn { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
