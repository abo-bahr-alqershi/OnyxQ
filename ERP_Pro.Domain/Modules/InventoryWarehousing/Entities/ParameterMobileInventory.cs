using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ParameterMobileInventory Entity
/// </summary>
public class ParameterMobileInventory : Entity<ParameterMobileInventoryId>
{

    private ParameterMobileInventory() { }

    public ParameterMobileInventory(ParameterMobileInventoryId id, decimal? parameterNumber)
    {
        Id = id;
        ParameterNumber = parameterNumber;
    }

    /// <summary>
    /// The unique identifier for the ParameterMobileInventory
    /// المعرف الفريد لـ ParameterMobileInventory
    /// </summary>
    public ParameterMobileInventoryId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterMobileInventory
    /// ParameterNumber الخاص بـ ParameterMobileInventory
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// UseBarcodeSetting of the ParameterMobileInventory
    /// UseBarcodeSetting الخاص بـ ParameterMobileInventory
    /// </summary>
    public decimal? UseBarcodeSetting { get; private set; }

    /// <summary>
    /// UsePriceMobileInvoice of the ParameterMobileInventory
    /// UsePriceMobileInvoice الخاص بـ ParameterMobileInventory
    /// </summary>
    public decimal? UsePriceMobileInvoice { get; private set; }

    /// <summary>
    /// PriceLevelNumber of the ParameterMobileInventory
    /// PriceLevelNumber الخاص بـ ParameterMobileInventory
    /// </summary>
    public decimal? PriceLevelNumber { get; private set; }

    /// <summary>
    /// ShowAvailableQuantity of the ParameterMobileInventory
    /// ShowAvailableQuantity الخاص بـ ParameterMobileInventory
    /// </summary>
    public decimal? ShowAvailableQuantity { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

