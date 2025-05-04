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

    public OnlineConnectWarehouseCode(OnlineConnectWarehouseCodeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the OnlineConnectWarehouseCode
    /// المعرف الفريد لـ OnlineConnectWarehouseCode
    /// </summary>
    public OnlineConnectWarehouseCodeId Id { get; private set; }

    /// <summary>
    /// RegionCode of the OnlineConnectWarehouseCode
    /// RegionCode الخاص بـ OnlineConnectWarehouseCode
    /// </summary>
    public decimal? RegionCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
