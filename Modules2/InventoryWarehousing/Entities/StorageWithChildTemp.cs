using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// StorageWithChildTemp Entity
/// </summary>
public class StorageWithChildTemp : Entity<StorageWithChildTempId>
{
    private StorageWithChildTemp() { }

    /// <summary>
    /// The unique identifier for the StorageWithChildTemp
    /// المعرف الفريد لـ StorageWithChildTemp
    /// </summary>
    public StorageWithChildTempId Id { get; private set; }

    /// <summary>
    /// ItemCode of the StorageWithChildTemp
    /// ItemCode الخاص بـ StorageWithChildTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the StorageWithChildTemp
    /// ItemUnit الخاص بـ StorageWithChildTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the StorageWithChildTemp
    /// PSize الخاص بـ StorageWithChildTemp
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the StorageWithChildTemp
    /// WarehouseCode الخاص بـ StorageWithChildTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// AvailableQuantity of the StorageWithChildTemp
    /// AvailableQuantity الخاص بـ StorageWithChildTemp
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// ExpireDate of the StorageWithChildTemp
    /// ExpireDate الخاص بـ StorageWithChildTemp
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the StorageWithChildTemp
    /// BatchNumber الخاص بـ StorageWithChildTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StorageWithChildTemp
    /// CompanyNumberShort الخاص بـ StorageWithChildTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StorageWithChildTemp
    /// BranchNumber الخاص بـ StorageWithChildTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StorageWithChildTemp
    /// BranchYear الخاص بـ StorageWithChildTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StorageWithChildTemp
    /// BranchUser الخاص بـ StorageWithChildTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}

