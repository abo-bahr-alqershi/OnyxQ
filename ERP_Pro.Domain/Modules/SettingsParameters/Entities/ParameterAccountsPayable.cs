using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// ParameterAccountsPayable Entity
/// </summary>
public class ParameterAccountsPayable : Entity<ParameterAccountsPayableId>
{

    private ParameterAccountsPayable() { }

    public ParameterAccountsPayable(ParameterAccountsPayableId id, decimal? parameterNumber)
    {
        Id = id;
        ParameterNumber = parameterNumber;
    }

    /// <summary>
    /// The unique identifier for the ParameterAccountsPayable
    /// المعرف الفريد لـ ParameterAccountsPayable
    /// </summary>
    public ParameterAccountsPayableId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterAccountsPayable
    /// ParameterNumber الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// DocGenAp of the ParameterAccountsPayable
    /// DocGenAp الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? DocGenAp { get; private set; }

    /// <summary>
    /// AllowDocumentDeleteNumber of the ParameterAccountsPayable
    /// AllowDocumentDeleteNumber الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AllowDocumentDeleteNumber { get; private set; }

    /// <summary>
    /// DateGenAp of the ParameterAccountsPayable
    /// DateGenAp الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? DateGenAp { get; private set; }

    /// <summary>
    /// DateSettingAp of the ParameterAccountsPayable
    /// DateSettingAp الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? DateSettingAp { get; private set; }

    /// <summary>
    /// VendorLength of the ParameterAccountsPayable
    /// VendorLength الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? VendorLength { get; private set; }

    /// <summary>
    /// VendorDiscountType of the ParameterAccountsPayable
    /// VendorDiscountType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? VendorDiscountType { get; private set; }

    /// <summary>
    /// AccountsPayableAccountLinkType of the ParameterAccountsPayable
    /// AccountsPayableAccountLinkType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableAccountLinkType { get; private set; }

    /// <summary>
    /// AccountsPayableUseFreeQuantity of the ParameterAccountsPayable
    /// AccountsPayableUseFreeQuantity الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableUseFreeQuantity { get; private set; }

    /// <summary>
    /// ShowDiscountPercentItemsAccountsPayable of the ParameterAccountsPayable
    /// ShowDiscountPercentItemsAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowDiscountPercentItemsAccountsPayable { get; private set; }

    /// <summary>
    /// ItemDiscountType of the ParameterAccountsPayable
    /// ItemDiscountType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ItemDiscountType { get; private set; }

    /// <summary>
    /// DiscCount of the ParameterAccountsPayable
    /// DiscCount الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? DiscCount { get; private set; }

    /// <summary>
    /// AccountsPayableCostType of the ParameterAccountsPayable
    /// AccountsPayableCostType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableCostType { get; private set; }

    /// <summary>
    /// AccountsPayableProjectType of the ParameterAccountsPayable
    /// AccountsPayableProjectType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableProjectType { get; private set; }

    /// <summary>
    /// AccountsPayableActivityType of the ParameterAccountsPayable
    /// AccountsPayableActivityType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableActivityType { get; private set; }

    /// <summary>
    /// AccountsPayableWarehouseCodeType of the ParameterAccountsPayable
    /// AccountsPayableWarehouseCodeType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableWarehouseCodeType { get; private set; }

    /// <summary>
    /// AccountsPayableLinkInvoice of the ParameterAccountsPayable
    /// AccountsPayableLinkInvoice الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableLinkInvoice { get; private set; }

    /// <summary>
    /// NumberOfDecimalAccountsPayable of the ParameterAccountsPayable
    /// NumberOfDecimalAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? NumberOfDecimalAccountsPayable { get; private set; }

    /// <summary>
    /// LetterCreditType of the ParameterAccountsPayable
    /// LetterCreditType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? LetterCreditType { get; private set; }

    /// <summary>
    /// LetterCreditStatus of the ParameterAccountsPayable
    /// LetterCreditStatus الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? LetterCreditStatus { get; private set; }

    /// <summary>
    /// PurchaseDiscountType of the ParameterAccountsPayable
    /// PurchaseDiscountType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? PurchaseDiscountType { get; private set; }

    /// <summary>
    /// PurchaseFreeQuantityCosting of the ParameterAccountsPayable
    /// PurchaseFreeQuantityCosting الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? PurchaseFreeQuantityCosting { get; private set; }

    /// <summary>
    /// ShowGroupName of the ParameterAccountsPayable
    /// ShowGroupName الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowGroupName { get; private set; }

    /// <summary>
    /// UseLocationGoodsReceiptNote of the ParameterAccountsPayable
    /// UseLocationGoodsReceiptNote الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseLocationGoodsReceiptNote { get; private set; }

    /// <summary>
    /// UseDeleteAccountsPayable of the ParameterAccountsPayable
    /// UseDeleteAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseDeleteAccountsPayable { get; private set; }

    /// <summary>
    /// UseModifyAccountsPayable of the ParameterAccountsPayable
    /// UseModifyAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseModifyAccountsPayable { get; private set; }

    /// <summary>
    /// AccountsPayablePurchaseRequestSerial of the ParameterAccountsPayable
    /// AccountsPayablePurchaseRequestSerial الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayablePurchaseRequestSerial { get; private set; }

    /// <summary>
    /// AccountsPayablePurchaseOrderSerial of the ParameterAccountsPayable
    /// AccountsPayablePurchaseOrderSerial الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayablePurchaseOrderSerial { get; private set; }

    /// <summary>
    /// GoodsReceiptSerialNumber of the ParameterAccountsPayable
    /// GoodsReceiptSerialNumber الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? GoodsReceiptSerialNumber { get; private set; }

    /// <summary>
    /// AccountsPayablePurchaseInvoiceSerial of the ParameterAccountsPayable
    /// AccountsPayablePurchaseInvoiceSerial الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayablePurchaseInvoiceSerial { get; private set; }

    /// <summary>
    /// AccountsPayablePriceSerial of the ParameterAccountsPayable
    /// AccountsPayablePriceSerial الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayablePriceSerial { get; private set; }

    /// <summary>
    /// UseBillOfExchange of the ParameterAccountsPayable
    /// UseBillOfExchange الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseBillOfExchange { get; private set; }

    /// <summary>
    /// ConnectionPurchaseRequestPurchaseOrderPurchaseInvoice of the ParameterAccountsPayable
    /// ConnectionPurchaseRequestPurchaseOrderPurchaseInvoice الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ConnectionPurchaseRequestPurchaseOrderPurchaseInvoice { get; private set; }

    /// <summary>
    /// ShowItemDescriptionAccountsPayable of the ParameterAccountsPayable
    /// ShowItemDescriptionAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowItemDescriptionAccountsPayable { get; private set; }

    /// <summary>
    /// ShowItemDescription of the ParameterAccountsPayable
    /// ShowItemDescription الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowItemDescription { get; private set; }

    /// <summary>
    /// RequestReferenceNumberAccountsPayable of the ParameterAccountsPayable
    /// RequestReferenceNumberAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? RequestReferenceNumberAccountsPayable { get; private set; }

    /// <summary>
    /// RequestDescriptionAccountsPayable of the ParameterAccountsPayable
    /// RequestDescriptionAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? RequestDescriptionAccountsPayable { get; private set; }

    /// <summary>
    /// ShowWarehouseCodeInPurchaseRequest of the ParameterAccountsPayable
    /// ShowWarehouseCodeInPurchaseRequest الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowWarehouseCodeInPurchaseRequest { get; private set; }

    /// <summary>
    /// UserApprovedInPurchaseRequest of the ParameterAccountsPayable
    /// UserApprovedInPurchaseRequest الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UserApprovedInPurchaseRequest { get; private set; }

    /// <summary>
    /// InsertVendorItem of the ParameterAccountsPayable
    /// InsertVendorItem الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? InsertVendorItem { get; private set; }

    /// <summary>
    /// FillLcInJournalVoucher of the ParameterAccountsPayable
    /// FillLcInJournalVoucher الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? FillLcInJournalVoucher { get; private set; }

    /// <summary>
    /// PaidInstallmentManual of the ParameterAccountsPayable
    /// PaidInstallmentManual الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? PaidInstallmentManual { get; private set; }

    /// <summary>
    /// UsePinoReturnPricePaymentYear of the ParameterAccountsPayable
    /// UsePinoReturnPricePaymentYear الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UsePinoReturnPricePaymentYear { get; private set; }

    /// <summary>
    /// Disc1NotEffectVndTrns of the ParameterAccountsPayable
    /// Disc1NotEffectVndTrns الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? Disc1NotEffectVndTrns { get; private set; }

    /// <summary>
    /// Disc2NotEffectVndTrns of the ParameterAccountsPayable
    /// Disc2NotEffectVndTrns الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? Disc2NotEffectVndTrns { get; private set; }

    /// <summary>
    /// Disc3NotEffectVndTrns of the ParameterAccountsPayable
    /// Disc3NotEffectVndTrns الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? Disc3NotEffectVndTrns { get; private set; }

    /// <summary>
    /// AccountsPayableDiscountType of the ParameterAccountsPayable
    /// AccountsPayableDiscountType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableDiscountType { get; private set; }

    /// <summary>
    /// VendorSerial of the ParameterAccountsPayable
    /// VendorSerial الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? VendorSerial { get; private set; }

    /// <summary>
    /// ShowSumQuantity of the ParameterAccountsPayable
    /// ShowSumQuantity الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowSumQuantity { get; private set; }

    /// <summary>
    /// AllowDuplicateItem of the ParameterAccountsPayable
    /// AllowDuplicateItem الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AllowDuplicateItem { get; private set; }

    /// <summary>
    /// PurchaseManualMandatory of the ParameterAccountsPayable
    /// PurchaseManualMandatory الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? PurchaseManualMandatory { get; private set; }

    /// <summary>
    /// UseServiceBill of the ParameterAccountsPayable
    /// UseServiceBill الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseServiceBill { get; private set; }

    /// <summary>
    /// NotifyItemPurchaseRequestNotProcessed of the ParameterAccountsPayable
    /// NotifyItemPurchaseRequestNotProcessed الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? NotifyItemPurchaseRequestNotProcessed { get; private set; }

    /// <summary>
    /// NotifyItemPurchaseOrderNotProcessed of the ParameterAccountsPayable
    /// NotifyItemPurchaseOrderNotProcessed الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? NotifyItemPurchaseOrderNotProcessed { get; private set; }

    /// <summary>
    /// UseAccountsPayableCheckQuantity of the ParameterAccountsPayable
    /// UseAccountsPayableCheckQuantity الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseAccountsPayableCheckQuantity { get; private set; }

    /// <summary>
    /// UseKimbAccountsPayable of the ParameterAccountsPayable
    /// UseKimbAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseKimbAccountsPayable { get; private set; }

    /// <summary>
    /// EffctKimbVndr of the ParameterAccountsPayable
    /// EffctKimbVndr الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? EffctKimbVndr { get; private set; }

    /// <summary>
    /// CalculateVatAmountTypeAccountsPayable of the ParameterAccountsPayable
    /// CalculateVatAmountTypeAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? CalculateVatAmountTypeAccountsPayable { get; private set; }

    /// <summary>
    /// ConnectionItemWithMoreVendor of the ParameterAccountsPayable
    /// ConnectionItemWithMoreVendor الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ConnectionItemWithMoreVendor { get; private set; }

    /// <summary>
    /// AddItemPriceFromBill of the ParameterAccountsPayable
    /// AddItemPriceFromBill الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AddItemPriceFromBill { get; private set; }

    /// <summary>
    /// AccountsPayableUseServiceItem of the ParameterAccountsPayable
    /// AccountsPayableUseServiceItem الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableUseServiceItem { get; private set; }

    /// <summary>
    /// PurchaseOrderCheckMaxLimitCost of the ParameterAccountsPayable
    /// PurchaseOrderCheckMaxLimitCost الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? PurchaseOrderCheckMaxLimitCost { get; private set; }

    /// <summary>
    /// ShowTotalAmount of the ParameterAccountsPayable
    /// ShowTotalAmount الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowTotalAmount { get; private set; }

    /// <summary>
    /// ConnectionContractPurchaseOrderType of the ParameterAccountsPayable
    /// ConnectionContractPurchaseOrderType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ConnectionContractPurchaseOrderType { get; private set; }

    /// <summary>
    /// CheckItemConnectedByVendor of the ParameterAccountsPayable
    /// CheckItemConnectedByVendor الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? CheckItemConnectedByVendor { get; private set; }

    /// <summary>
    /// UseAccountsPayableOtherCharge of the ParameterAccountsPayable
    /// UseAccountsPayableOtherCharge الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseAccountsPayableOtherCharge { get; private set; }

    /// <summary>
    /// ShowItemBarcodeAccountsPayable of the ParameterAccountsPayable
    /// ShowItemBarcodeAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowItemBarcodeAccountsPayable { get; private set; }

    /// <summary>
    /// BillDueDateLastMonth of the ParameterAccountsPayable
    /// BillDueDateLastMonth الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? BillDueDateLastMonth { get; private set; }

    /// <summary>
    /// ShowAdditionalFieldDetailCount of the ParameterAccountsPayable
    /// ShowAdditionalFieldDetailCount الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowAdditionalFieldDetailCount { get; private set; }

    /// <summary>
    /// ShowCostInPurchaseRequestOrder of the ParameterAccountsPayable
    /// ShowCostInPurchaseRequestOrder الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowCostInPurchaseRequestOrder { get; private set; }

    /// <summary>
    /// UseReturnBillRequest of the ParameterAccountsPayable
    /// UseReturnBillRequest الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseReturnBillRequest { get; private set; }

    /// <summary>
    /// UseLocationGoodsReceiptNoteMoreOne of the ParameterAccountsPayable
    /// UseLocationGoodsReceiptNoteMoreOne الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseLocationGoodsReceiptNoteMoreOne { get; private set; }

    /// <summary>
    /// RequestVendorBillNumber of the ParameterAccountsPayable
    /// RequestVendorBillNumber الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? RequestVendorBillNumber { get; private set; }

    /// <summary>
    /// UseAssignToUser of the ParameterAccountsPayable
    /// UseAssignToUser الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseAssignToUser { get; private set; }

    /// <summary>
    /// ShowFreeQuantityProfit of the ParameterAccountsPayable
    /// ShowFreeQuantityProfit الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowFreeQuantityProfit { get; private set; }

    /// <summary>
    /// CalculateDiscountWithoutItemDiscount of the ParameterAccountsPayable
    /// CalculateDiscountWithoutItemDiscount الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? CalculateDiscountWithoutItemDiscount { get; private set; }

    /// <summary>
    /// ShowTotalItemPriceByNet of the ParameterAccountsPayable
    /// ShowTotalItemPriceByNet الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowTotalItemPriceByNet { get; private set; }

    /// <summary>
    /// RequiredContainerNumber of the ParameterAccountsPayable
    /// RequiredContainerNumber الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? RequiredContainerNumber { get; private set; }

    /// <summary>
    /// NotCheckLetterCreditBalanceInBillCost of the ParameterAccountsPayable
    /// NotCheckLetterCreditBalanceInBillCost الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? NotCheckLetterCreditBalanceInBillCost { get; private set; }

    /// <summary>
    /// ConnectionPurchaseOrderPurchaseInvoiceType of the ParameterAccountsPayable
    /// ConnectionPurchaseOrderPurchaseInvoiceType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ConnectionPurchaseOrderPurchaseInvoiceType { get; private set; }

    /// <summary>
    /// UseVendorVatType of the ParameterAccountsPayable
    /// UseVendorVatType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseVendorVatType { get; private set; }

    /// <summary>
    /// PriceVendorItemUnitType of the ParameterAccountsPayable
    /// PriceVendorItemUnitType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? PriceVendorItemUnitType { get; private set; }

    /// <summary>
    /// AllowUpdateVendorInBill of the ParameterAccountsPayable
    /// AllowUpdateVendorInBill الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AllowUpdateVendorInBill { get; private set; }

    /// <summary>
    /// AutoUpdateVendorPrice of the ParameterAccountsPayable
    /// AutoUpdateVendorPrice الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AutoUpdateVendorPrice { get; private set; }

    /// <summary>
    /// UseReturnWithoutPurchaseInvoiceBillNumber of the ParameterAccountsPayable
    /// UseReturnWithoutPurchaseInvoiceBillNumber الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseReturnWithoutPurchaseInvoiceBillNumber { get; private set; }

    /// <summary>
    /// AccountsPayableItemChargeCalculationType of the ParameterAccountsPayable
    /// AccountsPayableItemChargeCalculationType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableItemChargeCalculationType { get; private set; }

    /// <summary>
    /// AccountsPayableItemChargeWarehouseCodeType of the ParameterAccountsPayable
    /// AccountsPayableItemChargeWarehouseCodeType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableItemChargeWarehouseCodeType { get; private set; }

    /// <summary>
    /// AccountsPayableItemChargeUsePeriod of the ParameterAccountsPayable
    /// AccountsPayableItemChargeUsePeriod الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableItemChargeUsePeriod { get; private set; }

    /// <summary>
    /// AllowedRePurchaseSerialNumber of the ParameterAccountsPayable
    /// AllowedRePurchaseSerialNumber الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AllowedRePurchaseSerialNumber { get; private set; }

    /// <summary>
    /// UseShippingList of the ParameterAccountsPayable
    /// UseShippingList الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseShippingList { get; private set; }

    /// <summary>
    /// AccountsPayableDiscountPeriod of the ParameterAccountsPayable
    /// AccountsPayableDiscountPeriod الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableDiscountPeriod { get; private set; }

    /// <summary>
    /// UpdateQuotationPremiumSales of the ParameterAccountsPayable
    /// UpdateQuotationPremiumSales الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UpdateQuotationPremiumSales { get; private set; }

    /// <summary>
    /// AccountsPayableItemChargeCalculationAmountType of the ParameterAccountsPayable
    /// AccountsPayableItemChargeCalculationAmountType الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AccountsPayableItemChargeCalculationAmountType { get; private set; }

    /// <summary>
    /// UsePostTaxDue of the ParameterAccountsPayable
    /// UsePostTaxDue الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UsePostTaxDue { get; private set; }

    /// <summary>
    /// UseVendorPriceList of the ParameterAccountsPayable
    /// UseVendorPriceList الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseVendorPriceList { get; private set; }

    /// <summary>
    /// ShowItemSizeShort of the ParameterAccountsPayable
    /// ShowItemSizeShort الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowItemSizeShort { get; private set; }

    /// <summary>
    /// ConnectionVendorPricePurchaseOrder of the ParameterAccountsPayable
    /// ConnectionVendorPricePurchaseOrder الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ConnectionVendorPricePurchaseOrder { get; private set; }

    /// <summary>
    /// AddForceInvoicePurchaseInvoice of the ParameterAccountsPayable
    /// AddForceInvoicePurchaseInvoice الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AddForceInvoicePurchaseInvoice { get; private set; }

    /// <summary>
    /// UseArabicSearchItemCode of the ParameterAccountsPayable
    /// UseArabicSearchItemCode الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseArabicSearchItemCode { get; private set; }

    /// <summary>
    /// UseSalePriceAsPurchasePrice of the ParameterAccountsPayable
    /// UseSalePriceAsPurchasePrice الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseSalePriceAsPurchasePrice { get; private set; }

    /// <summary>
    /// LevelNumberPrice of the ParameterAccountsPayable
    /// LevelNumberPrice الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? LevelNumberPrice { get; private set; }

    /// <summary>
    /// UseVendorClaim of the ParameterAccountsPayable
    /// UseVendorClaim الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseVendorClaim { get; private set; }

    /// <summary>
    /// ReturnPiFreeQuantityPercent of the ParameterAccountsPayable
    /// ReturnPiFreeQuantityPercent الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ReturnPiFreeQuantityPercent { get; private set; }

    /// <summary>
    /// UsePurchaseInvoiceCalculateTaxFreeQuantity of the ParameterAccountsPayable
    /// UsePurchaseInvoiceCalculateTaxFreeQuantity الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UsePurchaseInvoiceCalculateTaxFreeQuantity { get; private set; }

    /// <summary>
    /// AddItemPriceFromPurchaseOrder of the ParameterAccountsPayable
    /// AddItemPriceFromPurchaseOrder الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? AddItemPriceFromPurchaseOrder { get; private set; }

    /// <summary>
    /// UseDelivered of the ParameterAccountsPayable
    /// UseDelivered الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? UseDelivered { get; private set; }

    /// <summary>
    /// ShowItemCodeVendorAccountsPayable of the ParameterAccountsPayable
    /// ShowItemCodeVendorAccountsPayable الخاص بـ ParameterAccountsPayable
    /// </summary>
    public decimal? ShowItemCodeVendorAccountsPayable { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
