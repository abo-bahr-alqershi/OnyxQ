using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionSetupDetail Entity
/// </summary>
public class SalesmanCommissionSetupDetail : Entity<SalesmanCommissionSetupDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<SalesmanCommissionSetupMaster> _salesmanCommissionSetupMaster = new List<SalesmanCommissionSetupMaster>();
    private readonly List<CustomerClass> _customerClass = new List<CustomerClass>();
    private readonly List<CustomerGroup> _customerGroup = new List<CustomerGroup>();
    private readonly List<GroupDetail> _groupDetail = new List<GroupDetail>();
    private readonly List<ItemType> _itemType = new List<ItemType>();
    private readonly List<Measurement> _measurement = new List<Measurement>();

    private SalesmanCommissionSetupDetail() { }

    public SalesmanCommissionSetupDetail(SalesmanCommissionSetupDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionSetupDetail
    /// المعرف الفريد لـ SalesmanCommissionSetupDetail
    /// </summary>
    public SalesmanCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// SalesmanType of the SalesmanCommissionSetupDetail
    /// SalesmanType الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? SalesmanType { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanCommissionSetupDetail
    /// RepCode الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// BillDocumentType of the SalesmanCommissionSetupDetail
    /// BillDocumentType الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// GroupNumber of the SalesmanCommissionSetupDetail
    /// GroupNumber الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// FValue of the SalesmanCommissionSetupDetail
    /// FValue الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the SalesmanCommissionSetupDetail
    /// TValue الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the SalesmanCommissionSetupDetail
    /// CommissionAmountTypeShort الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanCommissionSetupDetail
    /// CommissionAmount الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SliceDescription of the SalesmanCommissionSetupDetail
    /// SliceDescription الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public string SliceDescription { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the SalesmanCommissionSetupDetail
    /// CommissionSliceNumber الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    /// <summary>
    /// RegionCode of the SalesmanCommissionSetupDetail
    /// RegionCode الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public string RegionCode { get; private set; }

    /// <summary>
    /// CompanyQuantity of the SalesmanCommissionSetupDetail
    /// CompanyQuantity الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CompanyQuantity { get; private set; }

    /// <summary>
    /// PSize of the SalesmanCommissionSetupDetail
    /// PSize الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// CountryNumber of the SalesmanCommissionSetupDetail
    /// CountryNumber الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the SalesmanCommissionSetupDetail
    /// ProvinceNumber الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the SalesmanCommissionSetupDetail
    /// CityNumber الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// LevelNumber of the SalesmanCommissionSetupDetail
    /// LevelNumber الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<SalesmanCommissionSetupMaster> SalesmanCommissionSetupMaster => _salesmanCommissionSetupMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerClass> CustomerClass => _customerClass;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerGroup> CustomerGroup => _customerGroup;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<GroupDetail> GroupDetail => _groupDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemType> ItemType => _itemType;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Measurement> Measurement => _measurement;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

