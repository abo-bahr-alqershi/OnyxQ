using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// OnlineConnectWarehouseCode Entity
/// </summary>
public class OnlineConnectWarehouseCode : Entity<OnlineConnectWarehouseCodeId>
{
    private OnlineConnectWarehouseCode() { }

    /// <summary>
    /// The unique identifier for the OnlineConnectWarehouseCode
    /// المعرف الفريد لـ OnlineConnectWarehouseCode
    /// </summary>
    public OnlineConnectWarehouseCodeId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the OnlineConnectWarehouseCode
    /// BranchNumber الخاص بـ OnlineConnectWarehouseCode
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// RegionCode of the OnlineConnectWarehouseCode
    /// RegionCode الخاص بـ OnlineConnectWarehouseCode
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the OnlineConnectWarehouseCode
    /// WarehouseCode الخاص بـ OnlineConnectWarehouseCode
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Branch
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
