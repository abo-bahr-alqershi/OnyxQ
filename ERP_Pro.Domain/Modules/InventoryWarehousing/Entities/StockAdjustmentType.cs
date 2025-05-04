using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// StockAdjustmentType Entity
/// </summary>
public class StockAdjustmentType : Entity<StockAdjustmentTypeId>
{

    private StockAdjustmentType() { }

    public StockAdjustmentType(StockAdjustmentTypeId id, decimal? stockType)
    {
        Id = id;
        StockType = stockType;
    }

    /// <summary>
    /// The unique identifier for the StockAdjustmentType
    /// المعرف الفريد لـ StockAdjustmentType
    /// </summary>
    public StockAdjustmentTypeId Id { get; private set; }

    /// <summary>
    /// StockType of the StockAdjustmentType
    /// StockType الخاص بـ StockAdjustmentType
    /// </summary>
    public decimal? StockType { get; private set; }

    /// <summary>
    /// StockName of the StockAdjustmentType
    /// StockName الخاص بـ StockAdjustmentType
    /// </summary>
    public string StockName { get; private set; }

    /// <summary>
    /// StockNameEnglish of the StockAdjustmentType
    /// StockNameEnglish الخاص بـ StockAdjustmentType
    /// </summary>
    public string StockNameEnglish { get; private set; }

    /// <summary>
    /// StockSerial of the StockAdjustmentType
    /// StockSerial الخاص بـ StockAdjustmentType
    /// </summary>
    public decimal? StockSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
