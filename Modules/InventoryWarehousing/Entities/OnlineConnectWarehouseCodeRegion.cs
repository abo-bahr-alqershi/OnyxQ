using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// OnlineConnectWarehouseCodeRegion Entity
/// </summary>
public class OnlineConnectWarehouseCodeRegion : Entity<OnlineConnectWarehouseCodeRegionId>
{
    private OnlineConnectWarehouseCodeRegion() { }

    /// <summary>
    /// The unique identifier for the OnlineConnectWarehouseCodeRegion
    /// المعرف الفريد لـ OnlineConnectWarehouseCodeRegion
    /// </summary>
    public OnlineConnectWarehouseCodeRegionId Id { get; private set; }

    /// <summary>
    /// WarehouseCode of the OnlineConnectWarehouseCodeRegion
    /// WarehouseCode الخاص بـ OnlineConnectWarehouseCodeRegion
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CountryNumber of the OnlineConnectWarehouseCodeRegion
    /// CountryNumber الخاص بـ OnlineConnectWarehouseCodeRegion
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the OnlineConnectWarehouseCodeRegion
    /// ProvinceNumber الخاص بـ OnlineConnectWarehouseCodeRegion
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the OnlineConnectWarehouseCodeRegion
    /// CityNumber الخاص بـ OnlineConnectWarehouseCodeRegion
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the OnlineConnectWarehouseCodeRegion
    /// RegionCode الخاص بـ OnlineConnectWarehouseCodeRegion
    /// </summary>
    public decimal? RegionCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Province
    /// </summary>
    public Province Province { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// ManyToOne relationship to City
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Country
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
