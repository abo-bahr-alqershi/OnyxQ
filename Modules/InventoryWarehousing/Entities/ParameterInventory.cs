using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ParameterInventory Entity
/// </summary>
public class ParameterInventory : Entity<ParameterInventoryId>
{
    private ParameterInventory() { }

    /// <summary>
    /// The unique identifier for the ParameterInventory
    /// المعرف الفريد لـ ParameterInventory
    /// </summary>
    public ParameterInventoryId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterInventory
    /// ParameterNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// DocGenInv of the ParameterInventory
    /// DocGenInv الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DocGenInv { get; private set; }

    /// <summary>
    /// AllowDocumentDeleteNumber of the ParameterInventory
    /// AllowDocumentDeleteNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AllowDocumentDeleteNumber { get; private set; }

    /// <summary>
    /// DateGenInv of the ParameterInventory
    /// DateGenInv الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DateGenInv { get; private set; }

    /// <summary>
    /// DateSettingInv of the ParameterInventory
    /// DateSettingInv الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DateSettingInv { get; private set; }

    /// <summary>
    /// LinkWithGeneralLedger of the ParameterInventory
    /// LinkWithGeneralLedger الخاص بـ ParameterInventory
    /// </summary>
    public decimal? LinkWithGeneralLedger { get; private set; }

    /// <summary>
    /// ItemCodeLength of the ParameterInventory
    /// ItemCodeLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ItemCodeLength { get; private set; }

    /// <summary>
    /// ItemCodeDiscountType of the ParameterInventory
    /// ItemCodeDiscountType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ItemCodeDiscountType { get; private set; }

    /// <summary>
    /// UseAlternateCode of the ParameterInventory
    /// UseAlternateCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseAlternateCode { get; private set; }

    /// <summary>
    /// UseExpireDate of the ParameterInventory
    /// UseExpireDate الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseExpireDate { get; private set; }

    /// <summary>
    /// UseBatchNumber of the ParameterInventory
    /// UseBatchNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseBatchNumber { get; private set; }

    /// <summary>
    /// UseMultiWarehouseCode of the ParameterInventory
    /// UseMultiWarehouseCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseMultiWarehouseCode { get; private set; }

    /// <summary>
    /// IncomingWarehouseType of the ParameterInventory
    /// IncomingWarehouseType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? IncomingWarehouseType { get; private set; }

    /// <summary>
    /// OutgoingWarehouseType of the ParameterInventory
    /// OutgoingWarehouseType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? OutgoingWarehouseType { get; private set; }

    /// <summary>
    /// IncomingCostType of the ParameterInventory
    /// IncomingCostType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? IncomingCostType { get; private set; }

    /// <summary>
    /// OutgoingCostType of the ParameterInventory
    /// OutgoingCostType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? OutgoingCostType { get; private set; }

    /// <summary>
    /// StockAdjustCostType of the ParameterInventory
    /// StockAdjustCostType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? StockAdjustCostType { get; private set; }

    /// <summary>
    /// TransactionCustomerType of the ParameterInventory
    /// TransactionCustomerType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? TransactionCustomerType { get; private set; }

    /// <summary>
    /// OutgoingProjectType of the ParameterInventory
    /// OutgoingProjectType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? OutgoingProjectType { get; private set; }

    /// <summary>
    /// IncomeProjectType of the ParameterInventory
    /// IncomeProjectType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? IncomeProjectType { get; private set; }

    /// <summary>
    /// StockProjectType of the ParameterInventory
    /// StockProjectType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? StockProjectType { get; private set; }

    /// <summary>
    /// TransactionProjectType of the ParameterInventory
    /// TransactionProjectType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? TransactionProjectType { get; private set; }

    /// <summary>
    /// OutgoingActivityType of the ParameterInventory
    /// OutgoingActivityType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? OutgoingActivityType { get; private set; }

    /// <summary>
    /// IncomeActivityType of the ParameterInventory
    /// IncomeActivityType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? IncomeActivityType { get; private set; }

    /// <summary>
    /// StockActivityType of the ParameterInventory
    /// StockActivityType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? StockActivityType { get; private set; }

    /// <summary>
    /// TransactionActivityType of the ParameterInventory
    /// TransactionActivityType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? TransactionActivityType { get; private set; }

    /// <summary>
    /// UseCosting of the ParameterInventory
    /// UseCosting الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseCosting { get; private set; }

    /// <summary>
    /// CostingType of the ParameterInventory
    /// CostingType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? CostingType { get; private set; }

    /// <summary>
    /// WeightedAverageType of the ParameterInventory
    /// WeightedAverageType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightedAverageType { get; private set; }

    /// <summary>
    /// ItemPostingFlag of the ParameterInventory
    /// ItemPostingFlag الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ItemPostingFlag { get; private set; }

    /// <summary>
    /// UseNegativeInventory of the ParameterInventory
    /// UseNegativeInventory الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseNegativeInventory { get; private set; }

    /// <summary>
    /// ShowItemDescriptionShort of the ParameterInventory
    /// ShowItemDescriptionShort الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowItemDescriptionShort { get; private set; }

    /// <summary>
    /// ShowItemDescription of the ParameterInventory
    /// ShowItemDescription الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowItemDescription { get; private set; }

    /// <summary>
    /// NumberOfDecimalInvoice of the ParameterInventory
    /// NumberOfDecimalInvoice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? NumberOfDecimalInvoice { get; private set; }

    /// <summary>
    /// UpdateBalanceFlag of the ParameterInventory
    /// UpdateBalanceFlag الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UpdateBalanceFlag { get; private set; }

    /// <summary>
    /// UseSerialNumber of the ParameterInventory
    /// UseSerialNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// UseConsignmentItem of the ParameterInventory
    /// UseConsignmentItem الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseConsignmentItem { get; private set; }

    /// <summary>
    /// UseCompoundItems of the ParameterInventory
    /// UseCompoundItems الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseCompoundItems { get; private set; }

    /// <summary>
    /// IncomingSerial of the ParameterInventory
    /// IncomingSerial الخاص بـ ParameterInventory
    /// </summary>
    public decimal? IncomingSerial { get; private set; }

    /// <summary>
    /// OutgoingSerial of the ParameterInventory
    /// OutgoingSerial الخاص بـ ParameterInventory
    /// </summary>
    public decimal? OutgoingSerial { get; private set; }

    /// <summary>
    /// TransferSerial of the ParameterInventory
    /// TransferSerial الخاص بـ ParameterInventory
    /// </summary>
    public decimal? TransferSerial { get; private set; }

    /// <summary>
    /// ShowItemSize of the ParameterInventory
    /// ShowItemSize الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowItemSize { get; private set; }

    /// <summary>
    /// HideOutgoingAccount of the ParameterInventory
    /// HideOutgoingAccount الخاص بـ ParameterInventory
    /// </summary>
    public decimal? HideOutgoingAccount { get; private set; }

    /// <summary>
    /// RequestSerial of the ParameterInventory
    /// RequestSerial الخاص بـ ParameterInventory
    /// </summary>
    public decimal? RequestSerial { get; private set; }

    /// <summary>
    /// UseDuplicateItemManualInvoice of the ParameterInventory
    /// UseDuplicateItemManualInvoice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseDuplicateItemManualInvoice { get; private set; }

    /// <summary>
    /// UseStandardItemCost of the ParameterInventory
    /// UseStandardItemCost الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseStandardItemCost { get; private set; }

    /// <summary>
    /// UseRequestModifyPrice of the ParameterInventory
    /// UseRequestModifyPrice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseRequestModifyPrice { get; private set; }

    /// <summary>
    /// UseDeleteInvoice of the ParameterInventory
    /// UseDeleteInvoice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseDeleteInvoice { get; private set; }

    /// <summary>
    /// UseModifyInvoice of the ParameterInventory
    /// UseModifyInvoice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseModifyInvoice { get; private set; }

    /// <summary>
    /// PriceType of the ParameterInventory
    /// PriceType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? PriceType { get; private set; }

    /// <summary>
    /// RoiType of the ParameterInventory
    /// RoiType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? RoiType { get; private set; }

    /// <summary>
    /// UseMinimumUnitPrice of the ParameterInventory
    /// UseMinimumUnitPrice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseMinimumUnitPrice { get; private set; }

    /// <summary>
    /// GenerateItemCode of the ParameterInventory
    /// GenerateItemCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? GenerateItemCode { get; private set; }

    /// <summary>
    /// ConnectionGroups of the ParameterInventory
    /// ConnectionGroups الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionGroups { get; private set; }

    /// <summary>
    /// ConnectionDetailGroupByGroups of the ParameterInventory
    /// ConnectionDetailGroupByGroups الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionDetailGroupByGroups { get; private set; }

    /// <summary>
    /// ConnectionAssistantGroupByGroups of the ParameterInventory
    /// ConnectionAssistantGroupByGroups الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionAssistantGroupByGroups { get; private set; }

    /// <summary>
    /// InsertItemManual of the ParameterInventory
    /// InsertItemManual الخاص بـ ParameterInventory
    /// </summary>
    public decimal? InsertItemManual { get; private set; }

    /// <summary>
    /// StockCostFraction of the ParameterInventory
    /// StockCostFraction الخاص بـ ParameterInventory
    /// </summary>
    public decimal? StockCostFraction { get; private set; }

    /// <summary>
    /// UseTransferExpense of the ParameterInventory
    /// UseTransferExpense الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseTransferExpense { get; private set; }

    /// <summary>
    /// AllowModifyReceivedQuantity of the ParameterInventory
    /// AllowModifyReceivedQuantity الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AllowModifyReceivedQuantity { get; private set; }

    /// <summary>
    /// AllowModifyReceivedWarehouseCode of the ParameterInventory
    /// AllowModifyReceivedWarehouseCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AllowModifyReceivedWarehouseCode { get; private set; }

    /// <summary>
    /// UseItemAttachment of the ParameterInventory
    /// UseItemAttachment الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseItemAttachment { get; private set; }

    /// <summary>
    /// ConnectionRequestWarehouseTransfer of the ParameterInventory
    /// ConnectionRequestWarehouseTransfer الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionRequestWarehouseTransfer { get; private set; }

    /// <summary>
    /// ConnectionRequestOutgoing of the ParameterInventory
    /// ConnectionRequestOutgoing الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionRequestOutgoing { get; private set; }

    /// <summary>
    /// ConnectionGroupIncoming of the ParameterInventory
    /// ConnectionGroupIncoming الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionGroupIncoming { get; private set; }

    /// <summary>
    /// MinLimitCostPercent of the ParameterInventory
    /// MinLimitCostPercent الخاص بـ ParameterInventory
    /// </summary>
    public decimal? MinLimitCostPercent { get; private set; }

    /// <summary>
    /// MaxLimitCostPercent of the ParameterInventory
    /// MaxLimitCostPercent الخاص بـ ParameterInventory
    /// </summary>
    public decimal? MaxLimitCostPercent { get; private set; }

    /// <summary>
    /// MinLimitPricePercent of the ParameterInventory
    /// MinLimitPricePercent الخاص بـ ParameterInventory
    /// </summary>
    public decimal? MinLimitPricePercent { get; private set; }

    /// <summary>
    /// MaxLimitPricePercent of the ParameterInventory
    /// MaxLimitPricePercent الخاص بـ ParameterInventory
    /// </summary>
    public decimal? MaxLimitPricePercent { get; private set; }

    /// <summary>
    /// PriceCostType of the ParameterInventory
    /// PriceCostType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? PriceCostType { get; private set; }

    /// <summary>
    /// RequestReferenceNumberInventory of the ParameterInventory
    /// RequestReferenceNumberInventory الخاص بـ ParameterInventory
    /// </summary>
    public decimal? RequestReferenceNumberInventory { get; private set; }

    /// <summary>
    /// RequestDescriptionInventory of the ParameterInventory
    /// RequestDescriptionInventory الخاص بـ ParameterInventory
    /// </summary>
    public decimal? RequestDescriptionInventory { get; private set; }

    /// <summary>
    /// GenerateBarcode of the ParameterInventory
    /// GenerateBarcode الخاص بـ ParameterInventory
    /// </summary>
    public string GenerateBarcode { get; private set; }

    /// <summary>
    /// ConnectionItemByAttachmentAuto of the ParameterInventory
    /// ConnectionItemByAttachmentAuto الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionItemByAttachmentAuto { get; private set; }

    /// <summary>
    /// ConnectionItemActivityByUserPrivilege of the ParameterInventory
    /// ConnectionItemActivityByUserPrivilege الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionItemActivityByUserPrivilege { get; private set; }

    /// <summary>
    /// DealingUnderSelling of the ParameterInventory
    /// DealingUnderSelling الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DealingUnderSelling { get; private set; }

    /// <summary>
    /// AllowUpdateTransferAccountCode of the ParameterInventory
    /// AllowUpdateTransferAccountCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AllowUpdateTransferAccountCode { get; private set; }

    /// <summary>
    /// AllowExceedTransactionQuantity of the ParameterInventory
    /// AllowExceedTransactionQuantity الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AllowExceedTransactionQuantity { get; private set; }

    /// <summary>
    /// UseMultiWarehouseTransfer of the ParameterInventory
    /// UseMultiWarehouseTransfer الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseMultiWarehouseTransfer { get; private set; }

    /// <summary>
    /// UseGoodOnConsignment of the ParameterInventory
    /// UseGoodOnConsignment الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseGoodOnConsignment { get; private set; }

    /// <summary>
    /// AllowDeleteReceivedItem of the ParameterInventory
    /// AllowDeleteReceivedItem الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AllowDeleteReceivedItem { get; private set; }

    /// <summary>
    /// ManualInvoiceSerial of the ParameterInventory
    /// ManualInvoiceSerial الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ManualInvoiceSerial { get; private set; }

    /// <summary>
    /// UseWeightSystem of the ParameterInventory
    /// UseWeightSystem الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseWeightSystem { get; private set; }

    /// <summary>
    /// DfltWtArgmnt of the ParameterInventory
    /// DfltWtArgmnt الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DfltWtArgmnt { get; private set; }

    /// <summary>
    /// InvoiceSystemType of the ParameterInventory
    /// InvoiceSystemType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? InvoiceSystemType { get; private set; }

    /// <summary>
    /// InvoiceSystemCloseType of the ParameterInventory
    /// InvoiceSystemCloseType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? InvoiceSystemCloseType { get; private set; }

    /// <summary>
    /// InvoiceCloseCostType of the ParameterInventory
    /// InvoiceCloseCostType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? InvoiceCloseCostType { get; private set; }

    /// <summary>
    /// UsePriceWarehouseTransferReceiveCost of the ParameterInventory
    /// UsePriceWarehouseTransferReceiveCost الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UsePriceWarehouseTransferReceiveCost { get; private set; }

    /// <summary>
    /// ConnectionWarehouseCostCenterMandatory of the ParameterInventory
    /// ConnectionWarehouseCostCenterMandatory الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionWarehouseCostCenterMandatory { get; private set; }

    /// <summary>
    /// ShowParentItemOnly of the ParameterInventory
    /// ShowParentItemOnly الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowParentItemOnly { get; private set; }

    /// <summary>
    /// ApprovedBarcodeSameBatchNumber of the ParameterInventory
    /// ApprovedBarcodeSameBatchNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ApprovedBarcodeSameBatchNumber { get; private set; }

    /// <summary>
    /// ApprovedBarcodeSameSerialNumber of the ParameterInventory
    /// ApprovedBarcodeSameSerialNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ApprovedBarcodeSameSerialNumber { get; private set; }

    /// <summary>
    /// NotInstallItemHasPrice of the ParameterInventory
    /// NotInstallItemHasPrice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? NotInstallItemHasPrice { get; private set; }

    /// <summary>
    /// ConnectionActivityByWarehouseCodeCostCenterCode of the ParameterInventory
    /// ConnectionActivityByWarehouseCodeCostCenterCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionActivityByWarehouseCodeCostCenterCode { get; private set; }

    /// <summary>
    /// PrintItemBarcodeNotPrice of the ParameterInventory
    /// PrintItemBarcodeNotPrice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? PrintItemBarcodeNotPrice { get; private set; }

    /// <summary>
    /// BatchNumberCollectorNumber of the ParameterInventory
    /// BatchNumberCollectorNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BatchNumberCollectorNumber { get; private set; }

    /// <summary>
    /// BatchNameCollector1 of the ParameterInventory
    /// BatchNameCollector1 الخاص بـ ParameterInventory
    /// </summary>
    public string BatchNameCollector1 { get; private set; }

    /// <summary>
    /// BatchNameCollector2 of the ParameterInventory
    /// BatchNameCollector2 الخاص بـ ParameterInventory
    /// </summary>
    public string BatchNameCollector2 { get; private set; }

    /// <summary>
    /// BatchNameCollector3 of the ParameterInventory
    /// BatchNameCollector3 الخاص بـ ParameterInventory
    /// </summary>
    public string BatchNameCollector3 { get; private set; }

    /// <summary>
    /// BatchNameCollector4 of the ParameterInventory
    /// BatchNameCollector4 الخاص بـ ParameterInventory
    /// </summary>
    public string BatchNameCollector4 { get; private set; }

    /// <summary>
    /// BatchNameCollector5 of the ParameterInventory
    /// BatchNameCollector5 الخاص بـ ParameterInventory
    /// </summary>
    public string BatchNameCollector5 { get; private set; }

    /// <summary>
    /// ShowBatchColumn1InScreen of the ParameterInventory
    /// ShowBatchColumn1InScreen الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowBatchColumn1InScreen { get; private set; }

    /// <summary>
    /// ShowBatchColumn2InScreen of the ParameterInventory
    /// ShowBatchColumn2InScreen الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowBatchColumn2InScreen { get; private set; }

    /// <summary>
    /// ShowBatchColumn3InScreen of the ParameterInventory
    /// ShowBatchColumn3InScreen الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowBatchColumn3InScreen { get; private set; }

    /// <summary>
    /// ShowBatchColumn4InScreen of the ParameterInventory
    /// ShowBatchColumn4InScreen الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowBatchColumn4InScreen { get; private set; }

    /// <summary>
    /// ShowBatchColumn5InScreen of the ParameterInventory
    /// ShowBatchColumn5InScreen الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowBatchColumn5InScreen { get; private set; }

    /// <summary>
    /// ActiveSerialNumber of the ParameterInventory
    /// ActiveSerialNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ActiveSerialNumber { get; private set; }

    /// <summary>
    /// GenerateAutoItemBarcode of the ParameterInventory
    /// GenerateAutoItemBarcode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? GenerateAutoItemBarcode { get; private set; }

    /// <summary>
    /// UsePercentCostKitItem of the ParameterInventory
    /// UsePercentCostKitItem الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UsePercentCostKitItem { get; private set; }

    /// <summary>
    /// InstallPosKitItemInStockAdjustment of the ParameterInventory
    /// InstallPosKitItemInStockAdjustment الخاص بـ ParameterInventory
    /// </summary>
    public decimal? InstallPosKitItemInStockAdjustment { get; private set; }

    /// <summary>
    /// SizeColumn1 of the ParameterInventory
    /// SizeColumn1 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? SizeColumn1 { get; private set; }

    /// <summary>
    /// SizeColumn2 of the ParameterInventory
    /// SizeColumn2 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? SizeColumn2 { get; private set; }

    /// <summary>
    /// SizeColumn3 of the ParameterInventory
    /// SizeColumn3 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? SizeColumn3 { get; private set; }

    /// <summary>
    /// SizeColumn4 of the ParameterInventory
    /// SizeColumn4 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? SizeColumn4 { get; private set; }

    /// <summary>
    /// SizeColumn5 of the ParameterInventory
    /// SizeColumn5 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? SizeColumn5 { get; private set; }

    /// <summary>
    /// ItemNumberColumn1 of the ParameterInventory
    /// ItemNumberColumn1 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ItemNumberColumn1 { get; private set; }

    /// <summary>
    /// ItemNumberColumn2 of the ParameterInventory
    /// ItemNumberColumn2 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ItemNumberColumn2 { get; private set; }

    /// <summary>
    /// ItemNumberColumn3 of the ParameterInventory
    /// ItemNumberColumn3 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ItemNumberColumn3 { get; private set; }

    /// <summary>
    /// ItemNumberColumn4 of the ParameterInventory
    /// ItemNumberColumn4 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ItemNumberColumn4 { get; private set; }

    /// <summary>
    /// ItemNumberColumn5 of the ParameterInventory
    /// ItemNumberColumn5 الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ItemNumberColumn5 { get; private set; }

    /// <summary>
    /// DupItemTrRec of the ParameterInventory
    /// DupItemTrRec الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DupItemTrRec { get; private set; }

    /// <summary>
    /// BarcodeFirst of the ParameterInventory
    /// BarcodeFirst الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFirst { get; private set; }

    /// <summary>
    /// BarcodeSecond of the ParameterInventory
    /// BarcodeSecond الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeSecond { get; private set; }

    /// <summary>
    /// BarcodeThird of the ParameterInventory
    /// BarcodeThird الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeThird { get; private set; }

    /// <summary>
    /// BarcodeFourth of the ParameterInventory
    /// BarcodeFourth الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFourth { get; private set; }

    /// <summary>
    /// BarcodeFifth of the ParameterInventory
    /// BarcodeFifth الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFifth { get; private set; }

    /// <summary>
    /// BarcodeSixth of the ParameterInventory
    /// BarcodeSixth الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeSixth { get; private set; }

    /// <summary>
    /// BarcodeFirstLength of the ParameterInventory
    /// BarcodeFirstLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFirstLength { get; private set; }

    /// <summary>
    /// BarcodeSecondLength of the ParameterInventory
    /// BarcodeSecondLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeSecondLength { get; private set; }

    /// <summary>
    /// BarcodeThirdLength of the ParameterInventory
    /// BarcodeThirdLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeThirdLength { get; private set; }

    /// <summary>
    /// BarcodeFourthLength of the ParameterInventory
    /// BarcodeFourthLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFourthLength { get; private set; }

    /// <summary>
    /// BarcodeFifthLength of the ParameterInventory
    /// BarcodeFifthLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFifthLength { get; private set; }

    /// <summary>
    /// BarcodeSixthLength of the ParameterInventory
    /// BarcodeSixthLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeSixthLength { get; private set; }

    /// <summary>
    /// BarcodeFirstDirection of the ParameterInventory
    /// BarcodeFirstDirection الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFirstDirection { get; private set; }

    /// <summary>
    /// BarcodeSecondDirection of the ParameterInventory
    /// BarcodeSecondDirection الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeSecondDirection { get; private set; }

    /// <summary>
    /// BarcodeThirdDirection of the ParameterInventory
    /// BarcodeThirdDirection الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeThirdDirection { get; private set; }

    /// <summary>
    /// BarcodeFourthDirection of the ParameterInventory
    /// BarcodeFourthDirection الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFourthDirection { get; private set; }

    /// <summary>
    /// BarcodeFifthDirection of the ParameterInventory
    /// BarcodeFifthDirection الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeFifthDirection { get; private set; }

    /// <summary>
    /// BarcodeSixthDirection of the ParameterInventory
    /// BarcodeSixthDirection الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeSixthDirection { get; private set; }

    /// <summary>
    /// ApproveDefaultPriceForAllLevel of the ParameterInventory
    /// ApproveDefaultPriceForAllLevel الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ApproveDefaultPriceForAllLevel { get; private set; }

    /// <summary>
    /// ManualInvoiceByOne of the ParameterInventory
    /// ManualInvoiceByOne الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ManualInvoiceByOne { get; private set; }

    /// <summary>
    /// CalculateLostDay of the ParameterInventory
    /// CalculateLostDay الخاص بـ ParameterInventory
    /// </summary>
    public decimal? CalculateLostDay { get; private set; }

    /// <summary>
    /// IncludeGroupCodeInItemCode of the ParameterInventory
    /// IncludeGroupCodeInItemCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? IncludeGroupCodeInItemCode { get; private set; }

    /// <summary>
    /// UseIncomeItemExpireDate of the ParameterInventory
    /// UseIncomeItemExpireDate الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseIncomeItemExpireDate { get; private set; }

    /// <summary>
    /// ShowNoteExceedQuantityInWarehouseTransfer of the ParameterInventory
    /// ShowNoteExceedQuantityInWarehouseTransfer الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowNoteExceedQuantityInWarehouseTransfer { get; private set; }

    /// <summary>
    /// DupItmInIncoming of the ParameterInventory
    /// DupItmInIncoming الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DupItmInIncoming { get; private set; }

    /// <summary>
    /// DupItmInOutgoing of the ParameterInventory
    /// DupItmInOutgoing الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DupItmInOutgoing { get; private set; }

    /// <summary>
    /// UseAutoReceiveWarehouseTransferByWarehouseCode of the ParameterInventory
    /// UseAutoReceiveWarehouseTransferByWarehouseCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseAutoReceiveWarehouseTransferByWarehouseCode { get; private set; }

    /// <summary>
    /// CheckWarehouseCodeRequiredInWarehouseTransfer of the ParameterInventory
    /// CheckWarehouseCodeRequiredInWarehouseTransfer الخاص بـ ParameterInventory
    /// </summary>
    public decimal? CheckWarehouseCodeRequiredInWarehouseTransfer { get; private set; }

    /// <summary>
    /// BarcodeDataType of the ParameterInventory
    /// BarcodeDataType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? BarcodeDataType { get; private set; }

    /// <summary>
    /// InputUnitFactorWeight of the ParameterInventory
    /// InputUnitFactorWeight الخاص بـ ParameterInventory
    /// </summary>
    public decimal? InputUnitFactorWeight { get; private set; }

    /// <summary>
    /// UseSequenceItemAuto of the ParameterInventory
    /// UseSequenceItemAuto الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseSequenceItemAuto { get; private set; }

    /// <summary>
    /// ShowItemBarcodeInventory of the ParameterInventory
    /// ShowItemBarcodeInventory الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowItemBarcodeInventory { get; private set; }

    /// <summary>
    /// UseOneBarcodeForItem of the ParameterInventory
    /// UseOneBarcodeForItem الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseOneBarcodeForItem { get; private set; }

    /// <summary>
    /// ConnectionSubGroups of the ParameterInventory
    /// ConnectionSubGroups الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionSubGroups { get; private set; }

    /// <summary>
    /// ApprovalItemNumberBatchNumberInBarcode of the ParameterInventory
    /// ApprovalItemNumberBatchNumberInBarcode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ApprovalItemNumberBatchNumberInBarcode { get; private set; }

    /// <summary>
    /// GenerateBarcodeMinUnit of the ParameterInventory
    /// GenerateBarcodeMinUnit الخاص بـ ParameterInventory
    /// </summary>
    public decimal? GenerateBarcodeMinUnit { get; private set; }

    /// <summary>
    /// UseInvoiceReevaluate of the ParameterInventory
    /// UseInvoiceReevaluate الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseInvoiceReevaluate { get; private set; }

    /// <summary>
    /// ShowWeightUnitArgumentInTransaction of the ParameterInventory
    /// ShowWeightUnitArgumentInTransaction الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowWeightUnitArgumentInTransaction { get; private set; }

    /// <summary>
    /// DealWithItemUsed of the ParameterInventory
    /// DealWithItemUsed الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DealWithItemUsed { get; private set; }

    /// <summary>
    /// MethodVatCalculationItemUsed of the ParameterInventory
    /// MethodVatCalculationItemUsed الخاص بـ ParameterInventory
    /// </summary>
    public decimal? MethodVatCalculationItemUsed { get; private set; }

    /// <summary>
    /// ConnectItemByBatch of the ParameterInventory
    /// ConnectItemByBatch الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectItemByBatch { get; private set; }

    /// <summary>
    /// PrintPriceWithTax of the ParameterInventory
    /// PrintPriceWithTax الخاص بـ ParameterInventory
    /// </summary>
    public decimal? PrintPriceWithTax { get; private set; }

    /// <summary>
    /// ApprovedKitItemPriceAssemble of the ParameterInventory
    /// ApprovedKitItemPriceAssemble الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ApprovedKitItemPriceAssemble { get; private set; }

    /// <summary>
    /// HideIncomingAccount of the ParameterInventory
    /// HideIncomingAccount الخاص بـ ParameterInventory
    /// </summary>
    public decimal? HideIncomingAccount { get; private set; }

    /// <summary>
    /// ApprovedBatchNumberItemCodeSequence of the ParameterInventory
    /// ApprovedBatchNumberItemCodeSequence الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ApprovedBatchNumberItemCodeSequence { get; private set; }

    /// <summary>
    /// AssembleDocumentSerial of the ParameterInventory
    /// AssembleDocumentSerial الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AssembleDocumentSerial { get; private set; }

    /// <summary>
    /// StockAdjustmentSerial of the ParameterInventory
    /// StockAdjustmentSerial الخاص بـ ParameterInventory
    /// </summary>
    public decimal? StockAdjustmentSerial { get; private set; }

    /// <summary>
    /// UseQrCodeSerialNumber of the ParameterInventory
    /// UseQrCodeSerialNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseQrCodeSerialNumber { get; private set; }

    /// <summary>
    /// UseItemPriceByExpireDate of the ParameterInventory
    /// UseItemPriceByExpireDate الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseItemPriceByExpireDate { get; private set; }

    /// <summary>
    /// UseItemPriceByBatchNumber of the ParameterInventory
    /// UseItemPriceByBatchNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseItemPriceByBatchNumber { get; private set; }

    /// <summary>
    /// WeightPrefix of the ParameterInventory
    /// WeightPrefix الخاص بـ ParameterInventory
    /// </summary>
    public string WeightPrefix { get; private set; }

    /// <summary>
    /// WeightBarcodeLength of the ParameterInventory
    /// WeightBarcodeLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightBarcodeLength { get; private set; }

    /// <summary>
    /// WeightItemLength of the ParameterInventory
    /// WeightItemLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightItemLength { get; private set; }

    /// <summary>
    /// WeightValue of the ParameterInventory
    /// WeightValue الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightValue { get; private set; }

    /// <summary>
    /// WeightFlag of the ParameterInventory
    /// WeightFlag الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightFlag { get; private set; }

    /// <summary>
    /// WeightIncludeItemUnit of the ParameterInventory
    /// WeightIncludeItemUnit الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightIncludeItemUnit { get; private set; }

    /// <summary>
    /// RemoveWeightDigit of the ParameterInventory
    /// RemoveWeightDigit الخاص بـ ParameterInventory
    /// </summary>
    public decimal? RemoveWeightDigit { get; private set; }

    /// <summary>
    /// UseChecksum of the ParameterInventory
    /// UseChecksum الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseChecksum { get; private set; }

    /// <summary>
    /// QrPrefixLength of the ParameterInventory
    /// QrPrefixLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? QrPrefixLength { get; private set; }

    /// <summary>
    /// QrGtinLengthArgument of the ParameterInventory
    /// QrGtinLengthArgument الخاص بـ ParameterInventory
    /// </summary>
    public decimal? QrGtinLengthArgument { get; private set; }

    /// <summary>
    /// NumberOfBarcodeDigitsInQrCode of the ParameterInventory
    /// NumberOfBarcodeDigitsInQrCode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? NumberOfBarcodeDigitsInQrCode { get; private set; }

    /// <summary>
    /// QrGtinLength of the ParameterInventory
    /// QrGtinLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? QrGtinLength { get; private set; }

    /// <summary>
    /// UseSerialNumberForSalesOnly of the ParameterInventory
    /// UseSerialNumberForSalesOnly الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseSerialNumberForSalesOnly { get; private set; }

    /// <summary>
    /// QrCodeMethodType of the ParameterInventory
    /// QrCodeMethodType الخاص بـ ParameterInventory
    /// </summary>
    public decimal? QrCodeMethodType { get; private set; }

    /// <summary>
    /// NumberOfManualQuantity of the ParameterInventory
    /// NumberOfManualQuantity الخاص بـ ParameterInventory
    /// </summary>
    public decimal? NumberOfManualQuantity { get; private set; }

    /// <summary>
    /// UseBatchNumberAutoSequence of the ParameterInventory
    /// UseBatchNumberAutoSequence الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseBatchNumberAutoSequence { get; private set; }

    /// <summary>
    /// NotAllowDeleteDocumentConnectedSerialNumber of the ParameterInventory
    /// NotAllowDeleteDocumentConnectedSerialNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? NotAllowDeleteDocumentConnectedSerialNumber { get; private set; }

    /// <summary>
    /// AllowEnterPartialQuantitySerialNumber of the ParameterInventory
    /// AllowEnterPartialQuantitySerialNumber الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AllowEnterPartialQuantitySerialNumber { get; private set; }

    /// <summary>
    /// UseKitItemWarehouseCodeTypeOut of the ParameterInventory
    /// UseKitItemWarehouseCodeTypeOut الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseKitItemWarehouseCodeTypeOut { get; private set; }

    /// <summary>
    /// UseKitItemClassification of the ParameterInventory
    /// UseKitItemClassification الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseKitItemClassification { get; private set; }

    /// <summary>
    /// UsePreparationQuantityByBarcode of the ParameterInventory
    /// UsePreparationQuantityByBarcode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UsePreparationQuantityByBarcode { get; private set; }

    /// <summary>
    /// MandatoryEnterPartialItemCodeSearch of the ParameterInventory
    /// MandatoryEnterPartialItemCodeSearch الخاص بـ ParameterInventory
    /// </summary>
    public decimal? MandatoryEnterPartialItemCodeSearch { get; private set; }

    /// <summary>
    /// WeightValueService of the ParameterInventory
    /// WeightValueService الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightValueService { get; private set; }

    /// <summary>
    /// PriceIncludeVatServiceItem of the ParameterInventory
    /// PriceIncludeVatServiceItem الخاص بـ ParameterInventory
    /// </summary>
    public decimal? PriceIncludeVatServiceItem { get; private set; }

    /// <summary>
    /// UsePreparationQuantity of the ParameterInventory
    /// UsePreparationQuantity الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UsePreparationQuantity { get; private set; }

    /// <summary>
    /// UseSalesOrderMandatoryInOutgoing of the ParameterInventory
    /// UseSalesOrderMandatoryInOutgoing الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseSalesOrderMandatoryInOutgoing { get; private set; }

    /// <summary>
    /// ShowGroupQuantityLimitAlert of the ParameterInventory
    /// ShowGroupQuantityLimitAlert الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ShowGroupQuantityLimitAlert { get; private set; }

    /// <summary>
    /// AllowDuplicateItemUnitSize of the ParameterInventory
    /// AllowDuplicateItemUnitSize الخاص بـ ParameterInventory
    /// </summary>
    public decimal? AllowDuplicateItemUnitSize { get; private set; }

    /// <summary>
    /// ConnectionCostCenterItemActivity of the ParameterInventory
    /// ConnectionCostCenterItemActivity الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionCostCenterItemActivity { get; private set; }

    /// <summary>
    /// ConnectionActivityAccountItemActivity of the ParameterInventory
    /// ConnectionActivityAccountItemActivity الخاص بـ ParameterInventory
    /// </summary>
    public decimal? ConnectionActivityAccountItemActivity { get; private set; }

    /// <summary>
    /// CheckIncomingCostPerOperation of the ParameterInventory
    /// CheckIncomingCostPerOperation الخاص بـ ParameterInventory
    /// </summary>
    public decimal? CheckIncomingCostPerOperation { get; private set; }

    /// <summary>
    /// DupItmInOpenStock of the ParameterInventory
    /// DupItmInOpenStock الخاص بـ ParameterInventory
    /// </summary>
    public decimal? DupItmInOpenStock { get; private set; }

    /// <summary>
    /// UseItemBinMovement of the ParameterInventory
    /// UseItemBinMovement الخاص بـ ParameterInventory
    /// </summary>
    public decimal? UseItemBinMovement { get; private set; }

    /// <summary>
    /// WeightCalculateQuantityByIncludePrice of the ParameterInventory
    /// WeightCalculateQuantityByIncludePrice الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightCalculateQuantityByIncludePrice { get; private set; }

    /// <summary>
    /// WeightPriceForceLength of the ParameterInventory
    /// WeightPriceForceLength الخاص بـ ParameterInventory
    /// </summary>
    public decimal? WeightPriceForceLength { get; private set; }

    /// <summary>
    /// NotAllowPrintItemWithoutBarcode of the ParameterInventory
    /// NotAllowPrintItemWithoutBarcode الخاص بـ ParameterInventory
    /// </summary>
    public decimal? NotAllowPrintItemWithoutBarcode { get; private set; }
}
}
