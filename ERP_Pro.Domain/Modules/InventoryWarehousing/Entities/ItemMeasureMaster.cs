using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemMeasureMaster Entity
/// </summary>
public class ItemMeasureMaster : AggregateRoot<ItemMeasureMasterId>
{

    private ItemMeasureMaster() { }

    public ItemMeasureMaster(ItemMeasureMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the ItemMeasureMaster
    /// المعرف الفريد لـ ItemMeasureMaster
    /// </summary>
    public ItemMeasureMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the ItemMeasureMaster
    /// DocNo الخاص بـ ItemMeasureMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ItemMeasureMaster
    /// DocSer الخاص بـ ItemMeasureMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the ItemMeasureMaster
    /// DocDate الخاص بـ ItemMeasureMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// UpdateCustomer of the ItemMeasureMaster
    /// UpdateCustomer الخاص بـ ItemMeasureMaster
    /// </summary>
    public decimal? UpdateCustomer { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

