using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Region Entity
/// </summary>
public class Region : Entity<RegionId>
{
    private Region() { }

    /// <summary>
    /// The unique identifier for the Region
    /// المعرف الفريد لـ Region
    /// </summary>
    public RegionId Id { get; private set; }

    /// <summary>
    /// RegionCode of the Region
    /// RegionCode الخاص بـ Region
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RegionNameArabic of the Region
    /// RegionNameArabic الخاص بـ Region
    /// </summary>
    public string RegionNameArabic { get; private set; }

    /// <summary>
    /// RegionNameEnglish of the Region
    /// RegionNameEnglish الخاص بـ Region
    /// </summary>
    public string RegionNameEnglish { get; private set; }

    /// <summary>
    /// CountryNumber of the Region
    /// CountryNumber الخاص بـ Region
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Region
    /// ProvinceNumber الخاص بـ Region
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the Region
    /// CityNumber الخاص بـ Region
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionShort of the Region
    /// RegionShort الخاص بـ Region
    /// </summary>
    public string RegionShort { get; private set; }

    /// <summary>
    /// ZoneNumber of the Region
    /// ZoneNumber الخاص بـ Region
    /// </summary>
    public decimal? ZoneNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Region to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to CustomerRequest
    /// </summary>
    public IReadOnlyCollection<CustomerRequest> CustomerRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to SalesOrder
    /// </summary>
    public IReadOnlyCollection<SalesOrder> SalesOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to Collector
    /// </summary>
    public IReadOnlyCollection<Collector> Collectors { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to CustomerCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CustomerCommissionSetupDetail> CustomerCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to SalesPlanDetail
    /// </summary>
    public IReadOnlyCollection<SalesPlanDetail> SalesPlanDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to SalesmanCollectionConditionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCollectionConditionDetail> SalesmanCollectionConditionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to PromotionRegion
    /// </summary>
    public IReadOnlyCollection<PromotionRegion> PromotionRegions { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to BillMaster
    /// </summary>
    public IReadOnlyCollection<BillMaster> BillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to BranchBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchBillMaster> BranchBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to CollectorCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CollectorCommissionSetupDetail> CollectorCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to ReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<ReturnBillMaster> ReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to BranchReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillMaster> BranchReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to ReturnBillMasterRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillMasterRequest> ReturnBillMasterRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to RegionSalesman
    /// </summary>
    public IReadOnlyCollection<RegionSalesman> RegionSalesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to OutgoingBillMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingBillMaster> OutgoingBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to OnlineConnectWarehouseCodeRegion
    /// </summary>
    public IReadOnlyCollection<OnlineConnectWarehouseCodeRegion> OnlineConnectWarehouseCodeRegions { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to Driver
    /// </summary>
    public IReadOnlyCollection<Driver> Drivers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to RouteDetail
    /// </summary>
    public IReadOnlyCollection<RouteDetail> RouteDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to City
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Zone
    /// </summary>
    public Zone Zone { get; private set; }
    /// <summary>
    /// One-to-many relationship: Region to Promoter
    /// </summary>
    public IReadOnlyCollection<Promoter> Promoters { get; private set; }
    #endregion
}
}
