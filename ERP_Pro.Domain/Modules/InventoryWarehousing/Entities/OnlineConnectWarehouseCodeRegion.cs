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
    private readonly List<Province> _province = new List<Province>();
    private readonly List<Region> _region = new List<Region>();
    private readonly List<City> _city = new List<City>();
    private readonly List<Country> _country = new List<Country>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private OnlineConnectWarehouseCodeRegion() { }

    public OnlineConnectWarehouseCodeRegion(OnlineConnectWarehouseCodeRegionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the OnlineConnectWarehouseCodeRegion
    /// المعرف الفريد لـ OnlineConnectWarehouseCodeRegion
    /// </summary>
    public OnlineConnectWarehouseCodeRegionId Id { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Province> Province => _province;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Region> Region => _region;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<City> City => _city;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Country> Country => _country;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
