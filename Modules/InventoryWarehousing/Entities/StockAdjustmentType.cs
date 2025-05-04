using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// StockAdjustmentType Entity
/// </summary>
public class StockAdjustmentType : Entity<StockAdjustmentTypeId>
{
    private StockAdjustmentType() { }

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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: StockAdjustmentType to PrivilegeStockAdjustmentTypes
    /// </summary>
    public IReadOnlyCollection<PrivilegeStockAdjustmentTypes> PrivilegeStockAdjustmentTypeses { get; private set; }
    /// <summary>
    /// One-to-many relationship: StockAdjustmentType to StockAdjustment
    /// </summary>
    public IReadOnlyCollection<StockAdjustment> StockAdjustments { get; private set; }
    /// <summary>
    /// One-to-many relationship: StockAdjustmentType to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
