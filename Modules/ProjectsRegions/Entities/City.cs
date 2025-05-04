using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// City Entity
/// </summary>
public class City : Entity<CityId>
{
    private City() { }

    /// <summary>
    /// The unique identifier for the City
    /// المعرف الفريد لـ City
    /// </summary>
    public CityId Id { get; private set; }

    /// <summary>
    /// CityNumber of the City
    /// CityNumber الخاص بـ City
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// CityNameArabic of the City
    /// CityNameArabic الخاص بـ City
    /// </summary>
    public string CityNameArabic { get; private set; }

    /// <summary>
    /// CityNameEnglish of the City
    /// CityNameEnglish الخاص بـ City
    /// </summary>
    public string CityNameEnglish { get; private set; }

    /// <summary>
    /// ProvinceNumber of the City
    /// ProvinceNumber الخاص بـ City
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CountryNumber of the City
    /// CountryNumber الخاص بـ City
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityShortName of the City
    /// CityShortName الخاص بـ City
    /// </summary>
    public string CityShortName { get; private set; }

    /// <summary>
    /// ZoneNumber of the City
    /// ZoneNumber الخاص بـ City
    /// </summary>
    public decimal? ZoneNumber { get; private set; }

    /// <summary>
    /// CitySerial of the City
    /// CitySerial الخاص بـ City
    /// </summary>
    public decimal? CitySerial { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: City to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to VoucherDetails
    /// </summary>
    public IReadOnlyCollection<VoucherDetails> VoucherDetailses { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to CustomerRequest
    /// </summary>
    public IReadOnlyCollection<CustomerRequest> CustomerRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to SalesmanCollectionConditionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCollectionConditionDetail> SalesmanCollectionConditionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to OnlineConnectWarehouseCodeRegion
    /// </summary>
    public IReadOnlyCollection<OnlineConnectWarehouseCodeRegion> OnlineConnectWarehouseCodeRegions { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Province
    /// </summary>
    public Province Province { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Country
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Zone
    /// </summary>
    public Zone Zone { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to Region
    /// </summary>
    public IReadOnlyCollection<Region> Regions { get; private set; }
    /// <summary>
    /// One-to-many relationship: City to Promoter
    /// </summary>
    public IReadOnlyCollection<Promoter> Promoters { get; private set; }
    #endregion
}
}
