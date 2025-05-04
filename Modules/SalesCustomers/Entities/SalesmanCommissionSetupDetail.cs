using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionSetupDetail Entity
/// </summary>
public class SalesmanCommissionSetupDetail : Entity<SalesmanCommissionSetupDetailId>
{
    private SalesmanCommissionSetupDetail() { }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionSetupDetail
    /// المعرف الفريد لـ SalesmanCommissionSetupDetail
    /// </summary>
    public SalesmanCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the SalesmanCommissionSetupDetail
    /// CommissionTypeShort الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

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
    /// CClass of the SalesmanCommissionSetupDetail
    /// CClass الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CGroupCode of the SalesmanCommissionSetupDetail
    /// CGroupCode الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// BillDocumentType of the SalesmanCommissionSetupDetail
    /// BillDocumentType الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// ItemCode of the SalesmanCommissionSetupDetail
    /// ItemCode الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesmanCommissionSetupDetail
    /// ItemUnit الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// GuarantorCode of the SalesmanCommissionSetupDetail
    /// GuarantorCode الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the SalesmanCommissionSetupDetail
    /// ItemType الخاص بـ SalesmanCommissionSetupDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

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
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to SalesmanCommissionSetupMaster
    /// </summary>
    public SalesmanCommissionSetupMaster SalesmanCommissionSetupMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerClass
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerGroup
    /// </summary>
    public CustomerGroup CustomerGroup { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemType
    /// </summary>
    public ItemType ItemType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Measurement
    /// </summary>
    public Measurement Measurement { get; private set; }
    #endregion
}
}
