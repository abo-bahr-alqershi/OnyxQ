using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableQuotationCompareFilterDetail Entity
/// </summary>
public class AccountsPayableQuotationCompareFilterDetail : Entity<AccountsPayableQuotationCompareFilterDetailId>
{
    private AccountsPayableQuotationCompareFilterDetail() { }

    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareFilterDetail
    /// المعرف الفريد لـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public AccountsPayableQuotationCompareFilterDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsPayableQuotationCompareFilterDetail
    /// DocNo الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AccountsPayableQuotationCompareFilterDetail
    /// DocSer الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsPayableQuotationCompareFilterDetail
    /// ItemCode الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsPayableQuotationCompareFilterDetail
    /// ItemUnit الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AccountsPayableQuotationCompareFilterDetail
    /// PSize الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the AccountsPayableQuotationCompareFilterDetail
    /// ItemQuantity الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the AccountsPayableQuotationCompareFilterDetail
    /// PQuantity الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the AccountsPayableQuotationCompareFilterDetail
    /// FreeQuantity الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the AccountsPayableQuotationCompareFilterDetail
    /// ItemPriceShort الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DisAmt of the AccountsPayableQuotationCompareFilterDetail
    /// DisAmt الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the AccountsPayableQuotationCompareFilterDetail
    /// DisAmtMst الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisPer of the AccountsPayableQuotationCompareFilterDetail
    /// DisPer الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the AccountsPayableQuotationCompareFilterDetail
    /// DisAmtDtl الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// OtherAmount of the AccountsPayableQuotationCompareFilterDetail
    /// OtherAmount الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmount of the AccountsPayableQuotationCompareFilterDetail
    /// VatAmount الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the AccountsPayableQuotationCompareFilterDetail
    /// VatPercent الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VendorCode of the AccountsPayableQuotationCompareFilterDetail
    /// VendorCode الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the AccountsPayableQuotationCompareFilterDetail
    /// VendorName الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// ConfirmFlagShort of the AccountsPayableQuotationCompareFilterDetail
    /// ConfirmFlagShort الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? ConfirmFlagShort { get; private set; }

    /// <summary>
    /// ConfirmDescriptionShort of the AccountsPayableQuotationCompareFilterDetail
    /// ConfirmDescriptionShort الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string ConfirmDescriptionShort { get; private set; }

    /// <summary>
    /// 1000 of the AccountsPayableQuotationCompareFilterDetail
    /// 1000 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string 1000 { get; private set; }

    /// <summary>
    /// ItemDescription of the AccountsPayableQuotationCompareFilterDetail
    /// ItemDescription الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the AccountsPayableQuotationCompareFilterDetail
    /// Barcode الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// 30 of the AccountsPayableQuotationCompareFilterDetail
    /// 30 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableQuotationCompareFilterDetail
    /// RecordNumber الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableQuotationCompareFilterDetail
    /// CostCenterCode الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsPayableQuotationCompareFilterDetail
    /// ProjectNumber الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsPayableQuotationCompareFilterDetail
    /// ActivityNumber الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// FieldDetail1 of the AccountsPayableQuotationCompareFilterDetail
    /// FieldDetail1 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the AccountsPayableQuotationCompareFilterDetail
    /// FieldDetail2 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the AccountsPayableQuotationCompareFilterDetail
    /// FieldDetail3 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the AccountsPayableQuotationCompareFilterDetail
    /// FieldDetail4 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the AccountsPayableQuotationCompareFilterDetail
    /// FieldDetail5 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// DocTypRef of the AccountsPayableQuotationCompareFilterDetail
    /// DocTypRef الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the AccountsPayableQuotationCompareFilterDetail
    /// DocNoRef الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AccountsPayableQuotationCompareFilterDetail
    /// DocSerRef الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string DocSerRef { get; private set; }

    /// <summary>
    /// 256 of the AccountsPayableQuotationCompareFilterDetail
    /// 256 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string 256 { get; private set; }

    /// <summary>
    /// DocNoRefQtn of the AccountsPayableQuotationCompareFilterDetail
    /// DocNoRefQtn الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? DocNoRefQtn { get; private set; }

    /// <summary>
    /// DocSrlRefQtn of the AccountsPayableQuotationCompareFilterDetail
    /// DocSrlRefQtn الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string DocSrlRefQtn { get; private set; }

    /// <summary>
    /// 256 of the AccountsPayableQuotationCompareFilterDetail
    /// 256 الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string 256 { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsPayableQuotationCompareFilterDetail
    /// InactiveFlag الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AccountsPayableQuotationCompareFilterDetail
    /// InactivatedByUserId الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AccountsPayableQuotationCompareFilterDetail
    /// InactiveDate الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AccountsPayableQuotationCompareFilterDetail
    /// InactiveReason الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableQuotationCompareFilterDetail
    /// CompanyNumberShort الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableQuotationCompareFilterDetail
    /// BranchNumber الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableQuotationCompareFilterDetail
    /// BranchYear الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableQuotationCompareFilterDetail
    /// BranchUser الخاص بـ AccountsPayableQuotationCompareFilterDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public AccountsPayableQuotationCompareFilterMaster AccountsPayableQuotationCompareFilterMaster { get; private set; }
    #endregion
}
}
