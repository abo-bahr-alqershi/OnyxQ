using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeStockAdjustmentTypes Entity
/// </summary>
public class PrivilegeStockAdjustmentTypes : Entity<PrivilegeStockAdjustmentTypesId>
{
    private PrivilegeStockAdjustmentTypes() { }

    /// <summary>
    /// The unique identifier for the PrivilegeStockAdjustmentTypes
    /// المعرف الفريد لـ PrivilegeStockAdjustmentTypes
    /// </summary>
    public PrivilegeStockAdjustmentTypesId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegeStockAdjustmentTypes
    /// UserId الخاص بـ PrivilegeStockAdjustmentTypes
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// StockType of the PrivilegeStockAdjustmentTypes
    /// StockType الخاص بـ PrivilegeStockAdjustmentTypes
    /// </summary>
    public decimal? StockType { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeStockAdjustmentTypes
    /// AdditionalFlag الخاص بـ PrivilegeStockAdjustmentTypes
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeStockAdjustmentTypes
    /// ViewFlag الخاص بـ PrivilegeStockAdjustmentTypes
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to StockAdjustmentType
    /// </summary>
    public StockAdjustmentType StockAdjustmentType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
