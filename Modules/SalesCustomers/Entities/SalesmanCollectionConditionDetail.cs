using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCollectionConditionDetail Entity
/// </summary>
public class SalesmanCollectionConditionDetail : Entity<SalesmanCollectionConditionDetailId>
{
    private SalesmanCollectionConditionDetail() { }

    /// <summary>
    /// The unique identifier for the SalesmanCollectionConditionDetail
    /// المعرف الفريد لـ SalesmanCollectionConditionDetail
    /// </summary>
    public SalesmanCollectionConditionDetailId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the SalesmanCollectionConditionDetail
    /// CommissionTypeShort الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// SalesmanType of the SalesmanCollectionConditionDetail
    /// SalesmanType الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? SalesmanType { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanCollectionConditionDetail
    /// RepCode الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CClass of the SalesmanCollectionConditionDetail
    /// CClass الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CGroupCode of the SalesmanCollectionConditionDetail
    /// CGroupCode الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CountryNumber of the SalesmanCollectionConditionDetail
    /// CountryNumber الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the SalesmanCollectionConditionDetail
    /// ProvinceNumber الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the SalesmanCollectionConditionDetail
    /// CityNumber الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the SalesmanCollectionConditionDetail
    /// RegionCode الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// FValue of the SalesmanCollectionConditionDetail
    /// FValue الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the SalesmanCollectionConditionDetail
    /// TValue الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the SalesmanCollectionConditionDetail
    /// CommissionAmountTypeShort الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanCollectionConditionDetail
    /// CommissionAmount الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SliceDescription of the SalesmanCollectionConditionDetail
    /// SliceDescription الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public string SliceDescription { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the SalesmanCollectionConditionDetail
    /// CommissionSliceNumber الخاص بـ SalesmanCollectionConditionDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to SalesmanType
    /// </summary>
    public SalesmanType SalesmanType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to SalesmanCollectionConditionMaster
    /// </summary>
    public SalesmanCollectionConditionMaster SalesmanCollectionConditionMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Province
    /// </summary>
    public Province Province { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// ManyToOne relationship to City
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Country
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerClass
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerGroup
    /// </summary>
    public CustomerGroup CustomerGroup { get; private set; }
    #endregion
}
}
