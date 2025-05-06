using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorQuotationDetail Entity
/// </summary>
public class VendorQuotationDetail : Entity<VendorQuotationDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<VendorQuotationMaster> _vendorQuotationMaster = new List<VendorQuotationMaster>();

    private VendorQuotationDetail() { }

    public VendorQuotationDetail(VendorQuotationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the VendorQuotationDetail
    /// المعرف الفريد لـ VendorQuotationDetail
    /// </summary>
    public VendorQuotationDetailId Id { get; private set; }

    /// <summary>
    /// QuotationNumber of the VendorQuotationDetail
    /// QuotationNumber الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? QuotationNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the VendorQuotationDetail
    /// ItemQuantity الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the VendorQuotationDetail
    /// PSize الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the VendorQuotationDetail
    /// PQuantity الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the VendorQuotationDetail
    /// ItemPriceShort الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// RecordNumber of the VendorQuotationDetail
    /// RecordNumber الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PriceNumber of the VendorQuotationDetail
    /// PriceNumber الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? PriceNumber { get; private set; }

    /// <summary>
    /// PriceSerial of the VendorQuotationDetail
    /// PriceSerial الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? PriceSerial { get; private set; }

    /// <summary>
    /// ItemDescription of the VendorQuotationDetail
    /// ItemDescription الخاص بـ VendorQuotationDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// DisAmtMst of the VendorQuotationDetail
    /// DisAmtMst الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmtDtl of the VendorQuotationDetail
    /// DisAmtDtl الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAmt of the VendorQuotationDetail
    /// DisAmt الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisPer of the VendorQuotationDetail
    /// DisPer الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// VatPercent of the VendorQuotationDetail
    /// VatPercent الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the VendorQuotationDetail
    /// VatAmount الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// FieldDetail1 of the VendorQuotationDetail
    /// FieldDetail1 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the VendorQuotationDetail
    /// FieldDetail2 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the VendorQuotationDetail
    /// FieldDetail3 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the VendorQuotationDetail
    /// FieldDetail4 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the VendorQuotationDetail
    /// FieldDetail5 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// OtherAmount of the VendorQuotationDetail
    /// OtherAmount الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// ItemPriceVat of the VendorQuotationDetail
    /// ItemPriceVat الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the VendorQuotationDetail
    /// CompanyNumberShort الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the VendorQuotationDetail
    /// BranchNumber الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the VendorQuotationDetail
    /// BranchYear الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the VendorQuotationDetail
    /// BranchUser الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CostCenterCode of the VendorQuotationDetail
    /// CostCenterCode الخاص بـ VendorQuotationDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the VendorQuotationDetail
    /// ProjectNumber الخاص بـ VendorQuotationDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the VendorQuotationDetail
    /// ActivityNumber الخاص بـ VendorQuotationDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the VendorQuotationDetail
    /// FreeQuantity الخاص بـ VendorQuotationDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// FieldDetail6 of the VendorQuotationDetail
    /// FieldDetail6 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the VendorQuotationDetail
    /// FieldDetail7 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the VendorQuotationDetail
    /// FieldDetail8 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the VendorQuotationDetail
    /// FieldDetail9 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the VendorQuotationDetail
    /// FieldDetail10 الخاص بـ VendorQuotationDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<VendorQuotationMaster> VendorQuotationMaster => _vendorQuotationMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

