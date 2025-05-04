using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Country Entity
/// </summary>
public class Country : Entity<CountryId>
{
    private Country() { }

    /// <summary>
    /// The unique identifier for the Country
    /// المعرف الفريد لـ Country
    /// </summary>
    public CountryId Id { get; private set; }

    /// <summary>
    /// CountryNumber of the Country
    /// CountryNumber الخاص بـ Country
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CountryNameArabic of the Country
    /// CountryNameArabic الخاص بـ Country
    /// </summary>
    public string CountryNameArabic { get; private set; }

    /// <summary>
    /// CountryNameEnglish of the Country
    /// CountryNameEnglish الخاص بـ Country
    /// </summary>
    public string CountryNameEnglish { get; private set; }

    /// <summary>
    /// CountryShortName of the Country
    /// CountryShortName الخاص بـ Country
    /// </summary>
    public string CountryShortName { get; private set; }

    /// <summary>
    /// CountryContinent of the Country
    /// CountryContinent الخاص بـ Country
    /// </summary>
    public string CountryContinent { get; private set; }

    /// <summary>
    /// CurNo of the Country
    /// CurNo الخاص بـ Country
    /// </summary>
    public decimal? CurNo { get; private set; }

    /// <summary>
    /// CurCode of the Country
    /// CurCode الخاص بـ Country
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CountryAntion of the Country
    /// CountryAntion الخاص بـ Country
    /// </summary>
    public string CountryAntion { get; private set; }

    /// <summary>
    /// CountryEntion of the Country
    /// CountryEntion الخاص بـ Country
    /// </summary>
    public string CountryEntion { get; private set; }

    /// <summary>
    /// NationShortName of the Country
    /// NationShortName الخاص بـ Country
    /// </summary>
    public string NationShortName { get; private set; }

    /// <summary>
    /// ZoneNumber of the Country
    /// ZoneNumber الخاص بـ Country
    /// </summary>
    public decimal? ZoneNumber { get; private set; }

    /// <summary>
    /// NotAllowDealWithFlag of the Country
    /// NotAllowDealWithFlag الخاص بـ Country
    /// </summary>
    public decimal? NotAllowDealWithFlag { get; private set; }

    /// <summary>
    /// PhoneKey of the Country
    /// PhoneKey الخاص بـ Country
    /// </summary>
    public string PhoneKey { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Country to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to VoucherDetails
    /// </summary>
    public IReadOnlyCollection<VoucherDetails> VoucherDetailses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to CustomerRequest
    /// </summary>
    public IReadOnlyCollection<CustomerRequest> CustomerRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to SalesmanCollectionConditionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCollectionConditionDetail> SalesmanCollectionConditionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to OnlineConnectWarehouseCodeRegion
    /// </summary>
    public IReadOnlyCollection<OnlineConnectWarehouseCodeRegion> OnlineConnectWarehouseCodeRegions { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to City
    /// </summary>
    public IReadOnlyCollection<City> Cities { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Zone
    /// </summary>
    public Zone Zone { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to Promoter
    /// </summary>
    public IReadOnlyCollection<Promoter> Promoters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Country to Province
    /// </summary>
    public IReadOnlyCollection<Province> Provinces { get; private set; }
    #endregion
}
}
