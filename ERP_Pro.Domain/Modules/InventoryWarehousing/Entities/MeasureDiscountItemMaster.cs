using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// MeasureDiscountItemMaster Entity
/// </summary>
public class MeasureDiscountItemMaster : AggregateRoot<MeasureDiscountItemMasterId>
{

    private MeasureDiscountItemMaster() { }

    public MeasureDiscountItemMaster(MeasureDiscountItemMasterId id, string itemCode, decimal? docSeq)
    {
        Id = id;
        ItemCode = itemCode;
        DocSeq = docSeq;
    }

    /// <summary>
    /// The unique identifier for the MeasureDiscountItemMaster
    /// المعرف الفريد لـ MeasureDiscountItemMaster
    /// </summary>
    public MeasureDiscountItemMasterId Id { get; private set; }

    /// <summary>
    /// ItemCode of the MeasureDiscountItemMaster
    /// ItemCode الخاص بـ MeasureDiscountItemMaster
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// MeasureNumber of the MeasureDiscountItemMaster
    /// MeasureNumber الخاص بـ MeasureDiscountItemMaster
    /// </summary>
    public decimal? MeasureNumber { get; private set; }

    /// <summary>
    /// MeasureLastName of the MeasureDiscountItemMaster
    /// MeasureLastName الخاص بـ MeasureDiscountItemMaster
    /// </summary>
    public string MeasureLastName { get; private set; }

    /// <summary>
    /// MeasureFirstNameFull of the MeasureDiscountItemMaster
    /// MeasureFirstNameFull الخاص بـ MeasureDiscountItemMaster
    /// </summary>
    public string MeasureFirstNameFull { get; private set; }

    /// <summary>
    /// DocSeq of the MeasureDiscountItemMaster
    /// DocSeq الخاص بـ MeasureDiscountItemMaster
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// MeasureDescription of the MeasureDiscountItemMaster
    /// MeasureDescription الخاص بـ MeasureDiscountItemMaster
    /// </summary>
    public string MeasureDescription { get; private set; }

    /// <summary>
    /// MeasureImage of the MeasureDiscountItemMaster
    /// MeasureImage الخاص بـ MeasureDiscountItemMaster
    /// </summary>
    public string MeasureImage { get; private set; }

    /// <summary>
    /// InactiveFlag of the MeasureDiscountItemMaster
    /// InactiveFlag الخاص بـ MeasureDiscountItemMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

