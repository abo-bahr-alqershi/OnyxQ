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
    private readonly List<SalesmanType> _salesmanType = new List<SalesmanType>();
    private readonly List<SalesmanCollectionConditionMaster> _salesmanCollectionConditionMaster = new List<SalesmanCollectionConditionMaster>();
    private readonly List<Province> _province = new List<Province>();
    private readonly List<Region> _region = new List<Region>();
    private readonly List<Salesman> _salesman = new List<Salesman>();
    private readonly List<City> _city = new List<City>();
    private readonly List<Country> _country = new List<Country>();
    private readonly List<CustomerClass> _customerClass = new List<CustomerClass>();
    private readonly List<CustomerGroup> _customerGroup = new List<CustomerGroup>();

    private SalesmanCollectionConditionDetail() { }

    public SalesmanCollectionConditionDetail(SalesmanCollectionConditionDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCollectionConditionDetail
    /// المعرف الفريد لـ SalesmanCollectionConditionDetail
    /// </summary>
    public SalesmanCollectionConditionDetailId Id { get; private set; }

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
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<SalesmanType> SalesmanType => _salesmanType;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<SalesmanCollectionConditionMaster> SalesmanCollectionConditionMaster => _salesmanCollectionConditionMaster;
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
    public ICollection<Salesman> Salesman => _salesman;
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
    public ICollection<CustomerClass> CustomerClass => _customerClass;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerGroup> CustomerGroup => _customerGroup;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
