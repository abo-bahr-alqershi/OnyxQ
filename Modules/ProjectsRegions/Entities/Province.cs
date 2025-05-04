using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Province Entity
/// </summary>
public class Province : Entity<ProvinceId>
{
    private Province() { }

    /// <summary>
    /// The unique identifier for the Province
    /// المعرف الفريد لـ Province
    /// </summary>
    public ProvinceId Id { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Province
    /// ProvinceNumber الخاص بـ Province
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// ProvinceNameArabic of the Province
    /// ProvinceNameArabic الخاص بـ Province
    /// </summary>
    public string ProvinceNameArabic { get; private set; }

    /// <summary>
    /// ProvinceNameEnglish of the Province
    /// ProvinceNameEnglish الخاص بـ Province
    /// </summary>
    public string ProvinceNameEnglish { get; private set; }

    /// <summary>
    /// CountryNumber of the Province
    /// CountryNumber الخاص بـ Province
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceShort of the Province
    /// ProvinceShort الخاص بـ Province
    /// </summary>
    public string ProvinceShort { get; private set; }

    /// <summary>
    /// ZoneNumber of the Province
    /// ZoneNumber الخاص بـ Province
    /// </summary>
    public decimal? ZoneNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Province to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    /// <summary>
    /// One-to-many relationship: Province to SalesmanCollectionConditionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCollectionConditionDetail> SalesmanCollectionConditionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Province to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Province to OnlineConnectWarehouseCodeRegion
    /// </summary>
    public IReadOnlyCollection<OnlineConnectWarehouseCodeRegion> OnlineConnectWarehouseCodeRegions { get; private set; }
    /// <summary>
    /// One-to-many relationship: Province to City
    /// </summary>
    public IReadOnlyCollection<City> Cities { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Country
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Zone
    /// </summary>
    public Zone Zone { get; private set; }
    #endregion
}
}
