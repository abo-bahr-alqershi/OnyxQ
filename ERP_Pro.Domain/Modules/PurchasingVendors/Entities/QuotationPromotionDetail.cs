using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// QuotationPromotionDetail Entity
/// </summary>
public class QuotationPromotionDetail : Entity<QuotationPromotionDetailId>
{

    private QuotationPromotionDetail() { }

    public QuotationPromotionDetail(QuotationPromotionDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the QuotationPromotionDetail
    /// المعرف الفريد لـ QuotationPromotionDetail
    /// </summary>
    public QuotationPromotionDetailId Id { get; private set; }

    /// <summary>
    /// QuotationNumberFull of the QuotationPromotionDetail
    /// QuotationNumberFull الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? QuotationNumberFull { get; private set; }

    /// <summary>
    /// PSize of the QuotationPromotionDetail
    /// PSize الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemPriceShort of the QuotationPromotionDetail
    /// ItemPriceShort الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// RecordNumber of the QuotationPromotionDetail
    /// RecordNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Barcode of the QuotationPromotionDetail
    /// Barcode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// FQuantity of the QuotationPromotionDetail
    /// FQuantity الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? FQuantity { get; private set; }

    /// <summary>
    /// TQuantity of the QuotationPromotionDetail
    /// TQuantity الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? TQuantity { get; private set; }

    /// <summary>
    /// FAmount of the QuotationPromotionDetail
    /// FAmount الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? FAmount { get; private set; }

    /// <summary>
    /// TAmount of the QuotationPromotionDetail
    /// TAmount الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? TAmount { get; private set; }

    /// <summary>
    /// DiscType of the QuotationPromotionDetail
    /// DiscType الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? DiscType { get; private set; }

    /// <summary>
    /// DiscAmtPer of the QuotationPromotionDetail
    /// DiscAmtPer الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? DiscAmtPer { get; private set; }

    /// <summary>
    /// QuotationItemCode of the QuotationPromotionDetail
    /// QuotationItemCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string QuotationItemCode { get; private set; }

    /// <summary>
    /// FreeQuantity of the QuotationPromotionDetail
    /// FreeQuantity الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// QuotationQuantity of the QuotationPromotionDetail
    /// QuotationQuantity الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? QuotationQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the QuotationPromotionDetail
    /// WarehouseCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the QuotationPromotionDetail
    /// WarehouseGroupCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// CountryNumber of the QuotationPromotionDetail
    /// CountryNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the QuotationPromotionDetail
    /// ProvinceNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the QuotationPromotionDetail
    /// CityNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the QuotationPromotionDetail
    /// RegionCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CardAmount of the QuotationPromotionDetail
    /// CardAmount الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? CardAmount { get; private set; }

    /// <summary>
    /// CompanyQuantity of the QuotationPromotionDetail
    /// CompanyQuantity الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? CompanyQuantity { get; private set; }

    /// <summary>
    /// QuotationItemUnit of the QuotationPromotionDetail
    /// QuotationItemUnit الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string QuotationItemUnit { get; private set; }

    /// <summary>
    /// ExpireDate of the QuotationPromotionDetail
    /// ExpireDate الخاص بـ QuotationPromotionDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the QuotationPromotionDetail
    /// BatchNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// CCode of the QuotationPromotionDetail
    /// CCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CGroupCode of the QuotationPromotionDetail
    /// CGroupCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the QuotationPromotionDetail
    /// CClass الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CDegree of the QuotationPromotionDetail
    /// CDegree الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? CDegree { get; private set; }

    /// <summary>
    /// GuarantorCode of the QuotationPromotionDetail
    /// GuarantorCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ManagerCode of the QuotationPromotionDetail
    /// ManagerCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the QuotationPromotionDetail
    /// SubGroupCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the QuotationPromotionDetail
    /// AssistantNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the QuotationPromotionDetail
    /// DetailNo الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string DetailNo { get; private set; }

    /// <summary>
    /// GroupNumber of the QuotationPromotionDetail
    /// GroupNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// ItemType of the QuotationPromotionDetail
    /// ItemType الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// GroupClassCode of the QuotationPromotionDetail
    /// GroupClassCode الخاص بـ QuotationPromotionDetail
    /// </summary>
    public string GroupClassCode { get; private set; }

    /// <summary>
    /// PromoterGroupNumber of the QuotationPromotionDetail
    /// PromoterGroupNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? PromoterGroupNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the QuotationPromotionDetail
    /// CompanyNumberShort الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the QuotationPromotionDetail
    /// BranchNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the QuotationPromotionDetail
    /// BranchYear الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the QuotationPromotionDetail
    /// BranchUser الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BankNumber of the QuotationPromotionDetail
    /// BankNumber الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// MaxQuotationQuantityDocument of the QuotationPromotionDetail
    /// MaxQuotationQuantityDocument الخاص بـ QuotationPromotionDetail
    /// </summary>
    public decimal? MaxQuotationQuantityDocument { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public QuotationPromotionMaster QuotationPromotionMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
