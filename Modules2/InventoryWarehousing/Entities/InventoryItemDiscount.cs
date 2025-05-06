using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryItemDiscount Entity
/// </summary>
public class InventoryItemDiscount : Entity<InventoryItemDiscountId>
{

    private InventoryItemDiscount() { }

    public InventoryItemDiscount(InventoryItemDiscountId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the InventoryItemDiscount
    /// المعرف الفريد لـ InventoryItemDiscount
    /// </summary>
    public InventoryItemDiscountId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryItemDiscount
    /// RecordNumber الخاص بـ InventoryItemDiscount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemCode of the InventoryItemDiscount
    /// ItemCode الخاص بـ InventoryItemDiscount
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// DscLNm of the InventoryItemDiscount
    /// DscLNm الخاص بـ InventoryItemDiscount
    /// </summary>
    public string DscLNm { get; private set; }

    /// <summary>
    /// DscFNm of the InventoryItemDiscount
    /// DscFNm الخاص بـ InventoryItemDiscount
    /// </summary>
    public string DscFNm { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

