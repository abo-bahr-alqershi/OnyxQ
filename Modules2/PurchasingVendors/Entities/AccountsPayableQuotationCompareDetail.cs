using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableQuotationCompareDetail Entity
/// </summary>
public class AccountsPayableQuotationCompareDetail : Entity<AccountsPayableQuotationCompareDetailId>
{

    private AccountsPayableQuotationCompareDetail() { }

    public AccountsPayableQuotationCompareDetail(AccountsPayableQuotationCompareDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareDetail
    /// المعرف الفريد لـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public AccountsPayableQuotationCompareDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsPayableQuotationCompareDetail
    /// DocNo الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsPayableQuotationCompareDetail
    /// ItemCode الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsPayableQuotationCompareDetail
    /// ItemUnit الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AccountsPayableQuotationCompareDetail
    /// PSize الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the AccountsPayableQuotationCompareDetail
    /// ItemQuantity الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the AccountsPayableQuotationCompareDetail
    /// PQuantity الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the AccountsPayableQuotationCompareDetail
    /// FreeQuantity الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the AccountsPayableQuotationCompareDetail
    /// ItemPriceShort الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// VendorCode of the AccountsPayableQuotationCompareDetail
    /// VendorCode الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the AccountsPayableQuotationCompareDetail
    /// VendorName الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// ConfirmFlagShort of the AccountsPayableQuotationCompareDetail
    /// ConfirmFlagShort الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? ConfirmFlagShort { get; private set; }

    /// <summary>
    /// ConfirmDescriptionShort of the AccountsPayableQuotationCompareDetail
    /// ConfirmDescriptionShort الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string ConfirmDescriptionShort { get; private set; }

    /// <summary>
    /// ItemDescription of the AccountsPayableQuotationCompareDetail
    /// ItemDescription الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the AccountsPayableQuotationCompareDetail
    /// Barcode الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableQuotationCompareDetail
    /// RecordNumber الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableQuotationCompareDetail
    /// CostCenterCode الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsPayableQuotationCompareDetail
    /// ProjectNumber الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsPayableQuotationCompareDetail
    /// ActivityNumber الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// FieldDetail1 of the AccountsPayableQuotationCompareDetail
    /// FieldDetail1 الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the AccountsPayableQuotationCompareDetail
    /// FieldDetail2 الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the AccountsPayableQuotationCompareDetail
    /// FieldDetail3 الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the AccountsPayableQuotationCompareDetail
    /// FieldDetail4 الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the AccountsPayableQuotationCompareDetail
    /// FieldDetail5 الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// DisAmt of the AccountsPayableQuotationCompareDetail
    /// DisAmt الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the AccountsPayableQuotationCompareDetail
    /// DisAmtMst الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisPer of the AccountsPayableQuotationCompareDetail
    /// DisPer الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the AccountsPayableQuotationCompareDetail
    /// DisAmtDtl الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// OtherAmount of the AccountsPayableQuotationCompareDetail
    /// OtherAmount الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmount of the AccountsPayableQuotationCompareDetail
    /// VatAmount الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the AccountsPayableQuotationCompareDetail
    /// VatPercent الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// DocTypRef of the AccountsPayableQuotationCompareDetail
    /// DocTypRef الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the AccountsPayableQuotationCompareDetail
    /// DocNoRef الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AccountsPayableQuotationCompareDetail
    /// DocSerRef الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the AccountsPayableQuotationCompareDetail
    /// DocSequenceRef الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableQuotationCompareDetail
    /// CompanyNumberShort الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableQuotationCompareDetail
    /// BranchNumber الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableQuotationCompareDetail
    /// BranchYear الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableQuotationCompareDetail
    /// BranchUser الخاص بـ AccountsPayableQuotationCompareDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsPayableQuotationCompareMaster AccountsPayableQuotationCompareMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

