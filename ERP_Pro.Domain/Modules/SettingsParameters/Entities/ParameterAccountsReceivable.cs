using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;
namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// ParameterAccountsReceivable Entity
/// </summary>
public class ParameterAccountsReceivable : Entity<ParameterAccountsReceivableId>
{

    private ParameterAccountsReceivable() { }

    public ParameterAccountsReceivable(ParameterAccountsReceivableId id, decimal? parameterNumber)
    {
        Id = id;
        ParameterNumber = parameterNumber;
    }

    /// <summary>
    /// The unique identifier for the ParameterAccountsReceivable
    /// المعرف الفريد لـ ParameterAccountsReceivable
    /// </summary>
    public ParameterAccountsReceivableId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterAccountsReceivable
    /// ParameterNumber الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// DocGenAr of the ParameterAccountsReceivable
    /// DocGenAr الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? DocGenAr { get; private set; }

    /// <summary>
    /// AllowDocumentDeleteNumber of the ParameterAccountsReceivable
    /// AllowDocumentDeleteNumber الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AllowDocumentDeleteNumber { get; private set; }

    /// <summary>
    /// DateGenAr of the ParameterAccountsReceivable
    /// DateGenAr الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? DateGenAr { get; private set; }

    /// <summary>
    /// DateSettingAr of the ParameterAccountsReceivable
    /// DateSettingAr الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? DateSettingAr { get; private set; }

    /// <summary>
    /// CustLength of the ParameterAccountsReceivable
    /// CustLength الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CustLength { get; private set; }

    /// <summary>
    /// CustDType of the ParameterAccountsReceivable
    /// CustDType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CustDType { get; private set; }

    /// <summary>
    /// AccountsReceivableAccountLinkType of the ParameterAccountsReceivable
    /// AccountsReceivableAccountLinkType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AccountsReceivableAccountLinkType { get; private set; }

    /// <summary>
    /// ArUseFreeQuantity of the ParameterAccountsReceivable
    /// ArUseFreeQuantity الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArUseFreeQuantity { get; private set; }

    /// <summary>
    /// AccountsReceivableCostType of the ParameterAccountsReceivable
    /// AccountsReceivableCostType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AccountsReceivableCostType { get; private set; }

    /// <summary>
    /// AccountsReceivableProjectType of the ParameterAccountsReceivable
    /// AccountsReceivableProjectType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AccountsReceivableProjectType { get; private set; }

    /// <summary>
    /// AccountsReceivableActivityType of the ParameterAccountsReceivable
    /// AccountsReceivableActivityType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AccountsReceivableActivityType { get; private set; }

    /// <summary>
    /// ArWarehouseCodeType of the ParameterAccountsReceivable
    /// ArWarehouseCodeType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArWarehouseCodeType { get; private set; }

    /// <summary>
    /// InvoicingSerials of the ParameterAccountsReceivable
    /// InvoicingSerials الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? InvoicingSerials { get; private set; }

    /// <summary>
    /// InvoicingSerialsSerial of the ParameterAccountsReceivable
    /// InvoicingSerialsSerial الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? InvoicingSerialsSerial { get; private set; }

    /// <summary>
    /// ArQuotationSerial of the ParameterAccountsReceivable
    /// ArQuotationSerial الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArQuotationSerial { get; private set; }

    /// <summary>
    /// ArSalesOrderSerial of the ParameterAccountsReceivable
    /// ArSalesOrderSerial الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArSalesOrderSerial { get; private set; }

    /// <summary>
    /// ShowDiscountPercentItemsAccountsReceivable of the ParameterAccountsReceivable
    /// ShowDiscountPercentItemsAccountsReceivable الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowDiscountPercentItemsAccountsReceivable { get; private set; }

    /// <summary>
    /// MustReturnSameWarehouseCode of the ParameterAccountsReceivable
    /// MustReturnSameWarehouseCode الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? MustReturnSameWarehouseCode { get; private set; }

    /// <summary>
    /// AccountsReceivableLinkInvoice of the ParameterAccountsReceivable
    /// AccountsReceivableLinkInvoice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AccountsReceivableLinkInvoice { get; private set; }

    /// <summary>
    /// NumberOfDecimalAccountsReceivable of the ParameterAccountsReceivable
    /// NumberOfDecimalAccountsReceivable الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? NumberOfDecimalAccountsReceivable { get; private set; }

    /// <summary>
    /// SalesDuplicateItem of the ParameterAccountsReceivable
    /// SalesDuplicateItem الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesDuplicateItem { get; private set; }

    /// <summary>
    /// UseReturnWithoutBillNumber of the ParameterAccountsReceivable
    /// UseReturnWithoutBillNumber الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseReturnWithoutBillNumber { get; private set; }

    /// <summary>
    /// FillSalesOrderWithoutPrice of the ParameterAccountsReceivable
    /// FillSalesOrderWithoutPrice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? FillSalesOrderWithoutPrice { get; private set; }

    /// <summary>
    /// UseConcreteSystem of the ParameterAccountsReceivable
    /// UseConcreteSystem الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseConcreteSystem { get; private set; }

    /// <summary>
    /// UseShippingListArabic of the ParameterAccountsReceivable
    /// UseShippingListArabic الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseShippingListArabic { get; private set; }

    /// <summary>
    /// PaidScreenType of the ParameterAccountsReceivable
    /// PaidScreenType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PaidScreenType { get; private set; }

    /// <summary>
    /// ServiceItemType of the ParameterAccountsReceivable
    /// ServiceItemType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ServiceItemType { get; private set; }

    /// <summary>
    /// UseOutgoingBills of the ParameterAccountsReceivable
    /// UseOutgoingBills الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseOutgoingBills { get; private set; }

    /// <summary>
    /// SalesPostFreeQuantity of the ParameterAccountsReceivable
    /// SalesPostFreeQuantity الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesPostFreeQuantity { get; private set; }

    /// <summary>
    /// SalesPostDiscount of the ParameterAccountsReceivable
    /// SalesPostDiscount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesPostDiscount { get; private set; }

    /// <summary>
    /// PostOutgoingBillsType of the ParameterAccountsReceivable
    /// PostOutgoingBillsType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PostOutgoingBillsType { get; private set; }

    /// <summary>
    /// CustPriceFixed of the ParameterAccountsReceivable
    /// CustPriceFixed الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CustPriceFixed { get; private set; }

    /// <summary>
    /// SalesInvoiceHideDiscountPercent of the ParameterAccountsReceivable
    /// SalesInvoiceHideDiscountPercent الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceHideDiscountPercent { get; private set; }

    /// <summary>
    /// SalesInvoiceHideFreePercent of the ParameterAccountsReceivable
    /// SalesInvoiceHideFreePercent الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceHideFreePercent { get; private set; }

    /// <summary>
    /// SalesDiscountWarehouseCode of the ParameterAccountsReceivable
    /// SalesDiscountWarehouseCode الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesDiscountWarehouseCode { get; private set; }

    /// <summary>
    /// SalesDiscountPeriodic of the ParameterAccountsReceivable
    /// SalesDiscountPeriodic الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesDiscountPeriodic { get; private set; }

    /// <summary>
    /// SalesDiscountType of the ParameterAccountsReceivable
    /// SalesDiscountType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesDiscountType { get; private set; }

    /// <summary>
    /// SalesFreeQuantityType of the ParameterAccountsReceivable
    /// SalesFreeQuantityType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesFreeQuantityType { get; private set; }

    /// <summary>
    /// SalesFreeQuantityWarehouseCode of the ParameterAccountsReceivable
    /// SalesFreeQuantityWarehouseCode الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesFreeQuantityWarehouseCode { get; private set; }

    /// <summary>
    /// SalesFreeQuantityPeriodic of the ParameterAccountsReceivable
    /// SalesFreeQuantityPeriodic الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesFreeQuantityPeriodic { get; private set; }

    /// <summary>
    /// ShowItemDescriptionAccountsReceivable of the ParameterAccountsReceivable
    /// ShowItemDescriptionAccountsReceivable الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowItemDescriptionAccountsReceivable { get; private set; }

    /// <summary>
    /// ShowItemDescription of the ParameterAccountsReceivable
    /// ShowItemDescription الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowItemDescription { get; private set; }

    /// <summary>
    /// PostReportCommission of the ParameterAccountsReceivable
    /// PostReportCommission الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PostReportCommission { get; private set; }

    /// <summary>
    /// CreditLimitType of the ParameterAccountsReceivable
    /// CreditLimitType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CreditLimitType { get; private set; }

    /// <summary>
    /// ItemDiscountType of the ParameterAccountsReceivable
    /// ItemDiscountType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ItemDiscountType { get; private set; }

    /// <summary>
    /// UseStandBy of the ParameterAccountsReceivable
    /// UseStandBy الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseStandBy { get; private set; }

    /// <summary>
    /// UseWorkOrder of the ParameterAccountsReceivable
    /// UseWorkOrder الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseWorkOrder { get; private set; }

    /// <summary>
    /// UseReceiveCheck of the ParameterAccountsReceivable
    /// UseReceiveCheck الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseReceiveCheck { get; private set; }

    /// <summary>
    /// ArWorkOrderSerial of the ParameterAccountsReceivable
    /// ArWorkOrderSerial الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArWorkOrderSerial { get; private set; }

    /// <summary>
    /// SalesInvoiceRepCodeMandatoryShort of the ParameterAccountsReceivable
    /// SalesInvoiceRepCodeMandatoryShort الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceRepCodeMandatoryShort { get; private set; }

    /// <summary>
    /// SalesInvoiceRepCodeMandatory of the ParameterAccountsReceivable
    /// SalesInvoiceRepCodeMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceRepCodeMandatory { get; private set; }

    /// <summary>
    /// SalesInvoiceCollectorMandatory of the ParameterAccountsReceivable
    /// SalesInvoiceCollectorMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceCollectorMandatory { get; private set; }

    /// <summary>
    /// SalesInvoiceDriverMandatory of the ParameterAccountsReceivable
    /// SalesInvoiceDriverMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceDriverMandatory { get; private set; }

    /// <summary>
    /// SalesInvoiceAdditionalFieldsMandatory of the ParameterAccountsReceivable
    /// SalesInvoiceAdditionalFieldsMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceAdditionalFieldsMandatory { get; private set; }

    /// <summary>
    /// UseBillNumberReturnSalePaymentYear of the ParameterAccountsReceivable
    /// UseBillNumberReturnSalePaymentYear الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseBillNumberReturnSalePaymentYear { get; private set; }

    /// <summary>
    /// PaidInstallmentManual of the ParameterAccountsReceivable
    /// PaidInstallmentManual الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PaidInstallmentManual { get; private set; }

    /// <summary>
    /// UseDeleteAccountsReceivable of the ParameterAccountsReceivable
    /// UseDeleteAccountsReceivable الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseDeleteAccountsReceivable { get; private set; }

    /// <summary>
    /// UseModifyAccountsReceivable of the ParameterAccountsReceivable
    /// UseModifyAccountsReceivable الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseModifyAccountsReceivable { get; private set; }

    /// <summary>
    /// RequestReferenceNumberAccountsReceivable of the ParameterAccountsReceivable
    /// RequestReferenceNumberAccountsReceivable الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? RequestReferenceNumberAccountsReceivable { get; private set; }

    /// <summary>
    /// RequestDescriptionAccountsReceivable of the ParameterAccountsReceivable
    /// RequestDescriptionAccountsReceivable الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? RequestDescriptionAccountsReceivable { get; private set; }

    /// <summary>
    /// UseBillNumberConnection of the ParameterAccountsReceivable
    /// UseBillNumberConnection الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseBillNumberConnection { get; private set; }

    /// <summary>
    /// LightPostType of the ParameterAccountsReceivable
    /// LightPostType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? LightPostType { get; private set; }

    /// <summary>
    /// ShowItemBarcodeAccountsReceivable of the ParameterAccountsReceivable
    /// ShowItemBarcodeAccountsReceivable الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowItemBarcodeAccountsReceivable { get; private set; }

    /// <summary>
    /// CheckAllowItemDiscount of the ParameterAccountsReceivable
    /// CheckAllowItemDiscount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CheckAllowItemDiscount { get; private set; }

    /// <summary>
    /// CheckLimitSalesOrder of the ParameterAccountsReceivable
    /// CheckLimitSalesOrder الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CheckLimitSalesOrder { get; private set; }

    /// <summary>
    /// CheckSalesOrderQuantity of the ParameterAccountsReceivable
    /// CheckSalesOrderQuantity الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CheckSalesOrderQuantity { get; private set; }

    /// <summary>
    /// AddPurchaseOrderQuantity of the ParameterAccountsReceivable
    /// AddPurchaseOrderQuantity الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AddPurchaseOrderQuantity { get; private set; }

    /// <summary>
    /// UseSaleInvoiceAsPos of the ParameterAccountsReceivable
    /// UseSaleInvoiceAsPos الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseSaleInvoiceAsPos { get; private set; }

    /// <summary>
    /// ShowSizeItemInBills of the ParameterAccountsReceivable
    /// ShowSizeItemInBills الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowSizeItemInBills { get; private set; }

    /// <summary>
    /// ShowWeightItemInBills of the ParameterAccountsReceivable
    /// ShowWeightItemInBills الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowWeightItemInBills { get; private set; }

    /// <summary>
    /// ShowSumQuantityInSales of the ParameterAccountsReceivable
    /// ShowSumQuantityInSales الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowSumQuantityInSales { get; private set; }

    /// <summary>
    /// UseLightWithoutStore of the ParameterAccountsReceivable
    /// UseLightWithoutStore الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseLightWithoutStore { get; private set; }

    /// <summary>
    /// UseMandatoryMasterSerialPaymentYear of the ParameterAccountsReceivable
    /// UseMandatoryMasterSerialPaymentYear الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseMandatoryMasterSerialPaymentYear { get; private set; }

    /// <summary>
    /// DiscCount of the ParameterAccountsReceivable
    /// DiscCount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? DiscCount { get; private set; }

    /// <summary>
    /// AddForceIntoDiscountInvoice of the ParameterAccountsReceivable
    /// AddForceIntoDiscountInvoice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AddForceIntoDiscountInvoice { get; private set; }

    /// <summary>
    /// CalculateVatAmountType of the ParameterAccountsReceivable
    /// CalculateVatAmountType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CalculateVatAmountType { get; private set; }

    /// <summary>
    /// AllowGroupCreditCardAmount of the ParameterAccountsReceivable
    /// AllowGroupCreditCardAmount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AllowGroupCreditCardAmount { get; private set; }

    /// <summary>
    /// ReturnFreeQuantityPercent of the ParameterAccountsReceivable
    /// ReturnFreeQuantityPercent الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ReturnFreeQuantityPercent { get; private set; }

    /// <summary>
    /// PostAdditionalDiscountItemType of the ParameterAccountsReceivable
    /// PostAdditionalDiscountItemType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PostAdditionalDiscountItemType { get; private set; }

    /// <summary>
    /// LightShowQuantityAllWarehouseCode of the ParameterAccountsReceivable
    /// LightShowQuantityAllWarehouseCode الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? LightShowQuantityAllWarehouseCode { get; private set; }

    /// <summary>
    /// SalesReturnReasonMandatory of the ParameterAccountsReceivable
    /// SalesReturnReasonMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesReturnReasonMandatory { get; private set; }

    /// <summary>
    /// SalesInvoiceDueDateMandatory of the ParameterAccountsReceivable
    /// SalesInvoiceDueDateMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceDueDateMandatory { get; private set; }

    /// <summary>
    /// SalesInvoiceCheckAvailableQuantitySalesOrder of the ParameterAccountsReceivable
    /// SalesInvoiceCheckAvailableQuantitySalesOrder الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceCheckAvailableQuantitySalesOrder { get; private set; }

    /// <summary>
    /// CstSeqType of the ParameterAccountsReceivable
    /// CstSeqType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CstSeqType { get; private set; }

    /// <summary>
    /// AllowSalesOrderWithoutStore of the ParameterAccountsReceivable
    /// AllowSalesOrderWithoutStore الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AllowSalesOrderWithoutStore { get; private set; }

    /// <summary>
    /// MaxReserveSalesOrderItemDay of the ParameterAccountsReceivable
    /// MaxReserveSalesOrderItemDay الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? MaxReserveSalesOrderItemDay { get; private set; }

    /// <summary>
    /// SalesOrderExpireDateMandatory of the ParameterAccountsReceivable
    /// SalesOrderExpireDateMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesOrderExpireDateMandatory { get; private set; }

    /// <summary>
    /// MaxProductExpireDateSalesOrderDay of the ParameterAccountsReceivable
    /// MaxProductExpireDateSalesOrderDay الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? MaxProductExpireDateSalesOrderDay { get; private set; }

    /// <summary>
    /// CheckLimitQuotationPremiumSalesInvoice of the ParameterAccountsReceivable
    /// CheckLimitQuotationPremiumSalesInvoice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CheckLimitQuotationPremiumSalesInvoice { get; private set; }

    /// <summary>
    /// CheckStockQuotationPremiumSalesInvoice of the ParameterAccountsReceivable
    /// CheckStockQuotationPremiumSalesInvoice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CheckStockQuotationPremiumSalesInvoice { get; private set; }

    /// <summary>
    /// CheckLimitPriceMinusDiscountSalesInvoice of the ParameterAccountsReceivable
    /// CheckLimitPriceMinusDiscountSalesInvoice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CheckLimitPriceMinusDiscountSalesInvoice { get; private set; }

    /// <summary>
    /// LightPostSalesAvailableQuantity of the ParameterAccountsReceivable
    /// LightPostSalesAvailableQuantity الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? LightPostSalesAvailableQuantity { get; private set; }

    /// <summary>
    /// CancelReservedSalesOrderTransferBranchLight of the ParameterAccountsReceivable
    /// CancelReservedSalesOrderTransferBranchLight الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CancelReservedSalesOrderTransferBranchLight { get; private set; }

    /// <summary>
    /// ServiceWarehouseCodeType of the ParameterAccountsReceivable
    /// ServiceWarehouseCodeType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ServiceWarehouseCodeType { get; private set; }

    /// <summary>
    /// ShowPaidScreen of the ParameterAccountsReceivable
    /// ShowPaidScreen الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowPaidScreen { get; private set; }

    /// <summary>
    /// ConnectionSalesOrderInclude of the ParameterAccountsReceivable
    /// ConnectionSalesOrderInclude الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ConnectionSalesOrderInclude { get; private set; }

    /// <summary>
    /// UseScaleProduct of the ParameterAccountsReceivable
    /// UseScaleProduct الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseScaleProduct { get; private set; }

    /// <summary>
    /// ShowSalesmanCommissionSalesInvoice of the ParameterAccountsReceivable
    /// ShowSalesmanCommissionSalesInvoice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowSalesmanCommissionSalesInvoice { get; private set; }

    /// <summary>
    /// MaxProductReserveSalesOrderDay of the ParameterAccountsReceivable
    /// MaxProductReserveSalesOrderDay الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? MaxProductReserveSalesOrderDay { get; private set; }

    /// <summary>
    /// ArReceiptDocumentSerial of the ParameterAccountsReceivable
    /// ArReceiptDocumentSerial الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArReceiptDocumentSerial { get; private set; }

    /// <summary>
    /// ArUsePaidReceipt of the ParameterAccountsReceivable
    /// ArUsePaidReceipt الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArUsePaidReceipt { get; private set; }

    /// <summary>
    /// AllowModifyWarehouseCodeSoSi of the ParameterAccountsReceivable
    /// AllowModifyWarehouseCodeSoSi الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AllowModifyWarehouseCodeSoSi { get; private set; }

    /// <summary>
    /// AllowModifyPayTypeSoSi of the ParameterAccountsReceivable
    /// AllowModifyPayTypeSoSi الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AllowModifyPayTypeSoSi { get; private set; }

    /// <summary>
    /// CalculateSalesInvoiceDiscountWithoutItemDiscount of the ParameterAccountsReceivable
    /// CalculateSalesInvoiceDiscountWithoutItemDiscount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CalculateSalesInvoiceDiscountWithoutItemDiscount { get; private set; }

    /// <summary>
    /// UseSalesmanSlicesCommissionAutoSalesInvoice of the ParameterAccountsReceivable
    /// UseSalesmanSlicesCommissionAutoSalesInvoice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseSalesmanSlicesCommissionAutoSalesInvoice { get; private set; }

    /// <summary>
    /// ConnectionSalesmanItemActivity of the ParameterAccountsReceivable
    /// ConnectionSalesmanItemActivity الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ConnectionSalesmanItemActivity { get; private set; }

    /// <summary>
    /// ConnectionSalesmanWarehouseCashCostCenter of the ParameterAccountsReceivable
    /// ConnectionSalesmanWarehouseCashCostCenter الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ConnectionSalesmanWarehouseCashCostCenter { get; private set; }

    /// <summary>
    /// ConnectionCustomerMultiSalesman of the ParameterAccountsReceivable
    /// ConnectionCustomerMultiSalesman الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ConnectionCustomerMultiSalesman { get; private set; }

    /// <summary>
    /// ShowItemAvailableQuantityOnly of the ParameterAccountsReceivable
    /// ShowItemAvailableQuantityOnly الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowItemAvailableQuantityOnly { get; private set; }

    /// <summary>
    /// ShowAdditionalFieldInDetail of the ParameterAccountsReceivable
    /// ShowAdditionalFieldInDetail الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowAdditionalFieldInDetail { get; private set; }

    /// <summary>
    /// CopyPriceFromPreviousBill of the ParameterAccountsReceivable
    /// CopyPriceFromPreviousBill الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CopyPriceFromPreviousBill { get; private set; }

    /// <summary>
    /// MaxProductExpireDateSalesQuotationDay of the ParameterAccountsReceivable
    /// MaxProductExpireDateSalesQuotationDay الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? MaxProductExpireDateSalesQuotationDay { get; private set; }

    /// <summary>
    /// QuotationExpireDateMandatory of the ParameterAccountsReceivable
    /// QuotationExpireDateMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? QuotationExpireDateMandatory { get; private set; }

    /// <summary>
    /// UseChargeInstantTelecom of the ParameterAccountsReceivable
    /// UseChargeInstantTelecom الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseChargeInstantTelecom { get; private set; }

    /// <summary>
    /// SalesInvoicePayCashCustomerMandatory of the ParameterAccountsReceivable
    /// SalesInvoicePayCashCustomerMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoicePayCashCustomerMandatory { get; private set; }

    /// <summary>
    /// ConnectionCustomerMultiCollector of the ParameterAccountsReceivable
    /// ConnectionCustomerMultiCollector الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ConnectionCustomerMultiCollector { get; private set; }

    /// <summary>
    /// MandatoryConnectionCustomerCollector of the ParameterAccountsReceivable
    /// MandatoryConnectionCustomerCollector الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? MandatoryConnectionCustomerCollector { get; private set; }

    /// <summary>
    /// ConvertSalesInvoiceIncludeDepositAuto of the ParameterAccountsReceivable
    /// ConvertSalesInvoiceIncludeDepositAuto الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ConvertSalesInvoiceIncludeDepositAuto { get; private set; }

    /// <summary>
    /// UseApprovedSalesManagerSalesOrder of the ParameterAccountsReceivable
    /// UseApprovedSalesManagerSalesOrder الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseApprovedSalesManagerSalesOrder { get; private set; }

    /// <summary>
    /// UseInsuranceSystem of the ParameterAccountsReceivable
    /// UseInsuranceSystem الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseInsuranceSystem { get; private set; }

    /// <summary>
    /// MandatoryRequestInAdditionalDiscount of the ParameterAccountsReceivable
    /// MandatoryRequestInAdditionalDiscount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? MandatoryRequestInAdditionalDiscount { get; private set; }

    /// <summary>
    /// AccountsReceivableAdditionalDiscountSerial of the ParameterAccountsReceivable
    /// AccountsReceivableAdditionalDiscountSerial الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AccountsReceivableAdditionalDiscountSerial { get; private set; }

    /// <summary>
    /// ArRequestAdditionalDiscountSerial of the ParameterAccountsReceivable
    /// ArRequestAdditionalDiscountSerial الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArRequestAdditionalDiscountSerial { get; private set; }

    /// <summary>
    /// ConnectionOutgoingBillInvoiceReceipt of the ParameterAccountsReceivable
    /// ConnectionOutgoingBillInvoiceReceipt الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ConnectionOutgoingBillInvoiceReceipt { get; private set; }

    /// <summary>
    /// SalesInvoiceCustomerTelephoneMandatory of the ParameterAccountsReceivable
    /// SalesInvoiceCustomerTelephoneMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceCustomerTelephoneMandatory { get; private set; }

    /// <summary>
    /// AccountsReceivableEmployeeType of the ParameterAccountsReceivable
    /// AccountsReceivableEmployeeType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AccountsReceivableEmployeeType { get; private set; }

    /// <summary>
    /// PostSalesmanCommissionVoucherReceipt of the ParameterAccountsReceivable
    /// PostSalesmanCommissionVoucherReceipt الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PostSalesmanCommissionVoucherReceipt { get; private set; }

    /// <summary>
    /// UseMeasureDescriptionItem of the ParameterAccountsReceivable
    /// UseMeasureDescriptionItem الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseMeasureDescriptionItem { get; private set; }

    /// <summary>
    /// ArUseReturnBillRequestType of the ParameterAccountsReceivable
    /// ArUseReturnBillRequestType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArUseReturnBillRequestType { get; private set; }

    /// <summary>
    /// UseSubCustomer of the ParameterAccountsReceivable
    /// UseSubCustomer الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseSubCustomer { get; private set; }

    /// <summary>
    /// SalesInvoiceCustomerNameMandatory of the ParameterAccountsReceivable
    /// SalesInvoiceCustomerNameMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceCustomerNameMandatory { get; private set; }

    /// <summary>
    /// ShowItemCommissionPercent of the ParameterAccountsReceivable
    /// ShowItemCommissionPercent الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowItemCommissionPercent { get; private set; }

    /// <summary>
    /// ShowAllItemUnitTransaction of the ParameterAccountsReceivable
    /// ShowAllItemUnitTransaction الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowAllItemUnitTransaction { get; private set; }

    /// <summary>
    /// UseSalesOrderPreparationQuantity of the ParameterAccountsReceivable
    /// UseSalesOrderPreparationQuantity الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseSalesOrderPreparationQuantity { get; private set; }

    /// <summary>
    /// CalculateMeasurePrice of the ParameterAccountsReceivable
    /// CalculateMeasurePrice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CalculateMeasurePrice { get; private set; }

    /// <summary>
    /// UseCustomerCreditLimitLocal of the ParameterAccountsReceivable
    /// UseCustomerCreditLimitLocal الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseCustomerCreditLimitLocal { get; private set; }

    /// <summary>
    /// AdditionalDiscountItemQuantityPremiumDiscount of the ParameterAccountsReceivable
    /// AdditionalDiscountItemQuantityPremiumDiscount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AdditionalDiscountItemQuantityPremiumDiscount { get; private set; }

    /// <summary>
    /// BillLimitPrintSimpleForm of the ParameterAccountsReceivable
    /// BillLimitPrintSimpleForm الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? BillLimitPrintSimpleForm { get; private set; }

    /// <summary>
    /// UseDiscountCardSale of the ParameterAccountsReceivable
    /// UseDiscountCardSale الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseDiscountCardSale { get; private set; }

    /// <summary>
    /// UsePointSystemSale of the ParameterAccountsReceivable
    /// UsePointSystemSale الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UsePointSystemSale { get; private set; }

    /// <summary>
    /// LengthCashCustomerCode of the ParameterAccountsReceivable
    /// LengthCashCustomerCode الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? LengthCashCustomerCode { get; private set; }

    /// <summary>
    /// LengthCashCustomerMobileNumber of the ParameterAccountsReceivable
    /// LengthCashCustomerMobileNumber الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? LengthCashCustomerMobileNumber { get; private set; }

    /// <summary>
    /// PointCalculationType of the ParameterAccountsReceivable
    /// PointCalculationType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PointCalculationType { get; private set; }

    /// <summary>
    /// PointApprovedByDay of the ParameterAccountsReceivable
    /// PointApprovedByDay الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PointApprovedByDay { get; private set; }

    /// <summary>
    /// PointAgeExpiredType of the ParameterAccountsReceivable
    /// PointAgeExpiredType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PointAgeExpiredType { get; private set; }

    /// <summary>
    /// PointAgeExpiredPeriod of the ParameterAccountsReceivable
    /// PointAgeExpiredPeriod الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PointAgeExpiredPeriod { get; private set; }

    /// <summary>
    /// CustNoteJoinPoint of the ParameterAccountsReceivable
    /// CustNoteJoinPoint الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public string CustNoteJoinPoint { get; private set; }

    /// <summary>
    /// CustNoteNotJoinPoint of the ParameterAccountsReceivable
    /// CustNoteNotJoinPoint الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public string CustNoteNotJoinPoint { get; private set; }

    /// <summary>
    /// SendMessageType of the ParameterAccountsReceivable
    /// SendMessageType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SendMessageType { get; private set; }

    /// <summary>
    /// SendMessageCustomerType of the ParameterAccountsReceivable
    /// SendMessageCustomerType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SendMessageCustomerType { get; private set; }

    /// <summary>
    /// MessageTextCustomerBill of the ParameterAccountsReceivable
    /// MessageTextCustomerBill الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public string MessageTextCustomerBill { get; private set; }

    /// <summary>
    /// MessageTextCustomerReturnBill of the ParameterAccountsReceivable
    /// MessageTextCustomerReturnBill الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public string MessageTextCustomerReturnBill { get; private set; }

    /// <summary>
    /// MessageTextCustomerPoint of the ParameterAccountsReceivable
    /// MessageTextCustomerPoint الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public string MessageTextCustomerPoint { get; private set; }

    /// <summary>
    /// MessageTextCustomerWelcome of the ParameterAccountsReceivable
    /// MessageTextCustomerWelcome الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public string MessageTextCustomerWelcome { get; private set; }

    /// <summary>
    /// UseAssociationAccount of the ParameterAccountsReceivable
    /// UseAssociationAccount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseAssociationAccount { get; private set; }

    /// <summary>
    /// UseSalesOrderReservedTime of the ParameterAccountsReceivable
    /// UseSalesOrderReservedTime الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseSalesOrderReservedTime { get; private set; }

    /// <summary>
    /// DscntAftrVatFrcCtgry of the ParameterAccountsReceivable
    /// DscntAftrVatFrcCtgry الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? DscntAftrVatFrcCtgry { get; private set; }

    /// <summary>
    /// LinkWithScaleSalesOrder of the ParameterAccountsReceivable
    /// LinkWithScaleSalesOrder الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? LinkWithScaleSalesOrder { get; private set; }

    /// <summary>
    /// PeriodDifferenceActualWeightQuantitySalesOrder of the ParameterAccountsReceivable
    /// PeriodDifferenceActualWeightQuantitySalesOrder الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? PeriodDifferenceActualWeightQuantitySalesOrder { get; private set; }

    /// <summary>
    /// ReturnPeriod of the ParameterAccountsReceivable
    /// ReturnPeriod الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ReturnPeriod { get; private set; }

    /// <summary>
    /// AllowDuplicateReferenceNumber of the ParameterAccountsReceivable
    /// AllowDuplicateReferenceNumber الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AllowDuplicateReferenceNumber { get; private set; }

    /// <summary>
    /// UseOutgoingBillDirect of the ParameterAccountsReceivable
    /// UseOutgoingBillDirect الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseOutgoingBillDirect { get; private set; }

    /// <summary>
    /// ShowNetPriceTransaction of the ParameterAccountsReceivable
    /// ShowNetPriceTransaction الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowNetPriceTransaction { get; private set; }

    /// <summary>
    /// UseConditionContract of the ParameterAccountsReceivable
    /// UseConditionContract الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseConditionContract { get; private set; }

    /// <summary>
    /// UseInterfaceSalesRevenue of the ParameterAccountsReceivable
    /// UseInterfaceSalesRevenue الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseInterfaceSalesRevenue { get; private set; }

    /// <summary>
    /// UseSearchItemNameArabic of the ParameterAccountsReceivable
    /// UseSearchItemNameArabic الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseSearchItemNameArabic { get; private set; }

    /// <summary>
    /// ArQuotationWarehouseCodeType of the ParameterAccountsReceivable
    /// ArQuotationWarehouseCodeType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ArQuotationWarehouseCodeType { get; private set; }

    /// <summary>
    /// CalcTaxDiscount2 of the ParameterAccountsReceivable
    /// CalcTaxDiscount2 الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CalcTaxDiscount2 { get; private set; }

    /// <summary>
    /// CalcTaxDiscount3 of the ParameterAccountsReceivable
    /// CalcTaxDiscount3 الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CalcTaxDiscount3 { get; private set; }

    /// <summary>
    /// ShowLevelPriceInTransaction of the ParameterAccountsReceivable
    /// ShowLevelPriceInTransaction الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ShowLevelPriceInTransaction { get; private set; }

    /// <summary>
    /// UseBillsFollowup of the ParameterAccountsReceivable
    /// UseBillsFollowup الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseBillsFollowup { get; private set; }

    /// <summary>
    /// UseCustomerClaim of the ParameterAccountsReceivable
    /// UseCustomerClaim الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseCustomerClaim { get; private set; }

    /// <summary>
    /// UseCalculateTaxFreeQuantity of the ParameterAccountsReceivable
    /// UseCalculateTaxFreeQuantity الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseCalculateTaxFreeQuantity { get; private set; }

    /// <summary>
    /// ApprovedFreeQuantityDiscountReturnSI of the ParameterAccountsReceivable
    /// ApprovedFreeQuantityDiscountReturnSI الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ApprovedFreeQuantityDiscountReturnSI { get; private set; }

    /// <summary>
    /// UseAutoReserveItemTransactionInput of the ParameterAccountsReceivable
    /// UseAutoReserveItemTransactionInput الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseAutoReserveItemTransactionInput { get; private set; }

    /// <summary>
    /// UseRequestItemCustomer of the ParameterAccountsReceivable
    /// UseRequestItemCustomer الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseRequestItemCustomer { get; private set; }

    /// <summary>
    /// CheckCreditBankAmount of the ParameterAccountsReceivable
    /// CheckCreditBankAmount الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CheckCreditBankAmount { get; private set; }

    /// <summary>
    /// TimeCheckCreditBankSecond of the ParameterAccountsReceivable
    /// TimeCheckCreditBankSecond الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? TimeCheckCreditBankSecond { get; private set; }

    /// <summary>
    /// UseAdvancePayment of the ParameterAccountsReceivable
    /// UseAdvancePayment الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseAdvancePayment { get; private set; }

    /// <summary>
    /// CalcTaxAdvancePayment of the ParameterAccountsReceivable
    /// CalcTaxAdvancePayment الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CalcTaxAdvancePayment { get; private set; }

    /// <summary>
    /// CheckPriceCostLimitSalesOrderSalesInvoice of the ParameterAccountsReceivable
    /// CheckPriceCostLimitSalesOrderSalesInvoice الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CheckPriceCostLimitSalesOrderSalesInvoice { get; private set; }

    /// <summary>
    /// AllowUpdateReturnInsuranceSI of the ParameterAccountsReceivable
    /// AllowUpdateReturnInsuranceSI الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AllowUpdateReturnInsuranceSI { get; private set; }

    /// <summary>
    /// UseSpecialSalesman of the ParameterAccountsReceivable
    /// UseSpecialSalesman الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseSpecialSalesman { get; private set; }

    /// <summary>
    /// UseScaleMovement of the ParameterAccountsReceivable
    /// UseScaleMovement الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? UseScaleMovement { get; private set; }

    /// <summary>
    /// LightOutBillType of the ParameterAccountsReceivable
    /// LightOutBillType الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? LightOutBillType { get; private set; }

    /// <summary>
    /// ApprovedSoNoBatchNoAuto of the ParameterAccountsReceivable
    /// ApprovedSoNoBatchNoAuto الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? ApprovedSoNoBatchNoAuto { get; private set; }

    /// <summary>
    /// AllowEnterCustomerInLight of the ParameterAccountsReceivable
    /// AllowEnterCustomerInLight الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? AllowEnterCustomerInLight { get; private set; }

    /// <summary>
    /// GrantCostPrivilegeByBranch of the ParameterAccountsReceivable
    /// GrantCostPrivilegeByBranch الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? GrantCostPrivilegeByBranch { get; private set; }

    /// <summary>
    /// CalcDiscountAutoModifyItemTotal of the ParameterAccountsReceivable
    /// CalcDiscountAutoModifyItemTotal الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? CalcDiscountAutoModifyItemTotal { get; private set; }

    /// <summary>
    /// SalesInvoiceCashCustomerMandatory of the ParameterAccountsReceivable
    /// SalesInvoiceCashCustomerMandatory الخاص بـ ParameterAccountsReceivable
    /// </summary>
    public decimal? SalesInvoiceCashCustomerMandatory { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

