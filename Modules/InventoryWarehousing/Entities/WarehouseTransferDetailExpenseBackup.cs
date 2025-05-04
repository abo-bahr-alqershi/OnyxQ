using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// WarehouseTransferDetailExpenseBackup Entity
/// </summary>
public class WarehouseTransferDetailExpenseBackup : Entity<WarehouseTransferDetailExpenseBackupId>
{
    private WarehouseTransferDetailExpenseBackup() { }

    /// <summary>
    /// The unique identifier for the WarehouseTransferDetailExpenseBackup
    /// المعرف الفريد لـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public WarehouseTransferDetailExpenseBackupId Id { get; private set; }

    /// <summary>
    /// TransactionInOutType of the WarehouseTransferDetailExpenseBackup
    /// TransactionInOutType الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? TransactionInOutType { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the WarehouseTransferDetailExpenseBackup
    /// TransactionTypeFull الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

    /// <summary>
    /// TransactionNumberShort of the WarehouseTransferDetailExpenseBackup
    /// TransactionNumberShort الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? TransactionNumberShort { get; private set; }

    /// <summary>
    /// TransactionSerial of the WarehouseTransferDetailExpenseBackup
    /// TransactionSerial الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    /// <summary>
    /// ItemCode of the WarehouseTransferDetailExpenseBackup
    /// ItemCode الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the WarehouseTransferDetailExpenseBackup
    /// ItemQuantity الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the WarehouseTransferDetailExpenseBackup
    /// ItemUnit الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the WarehouseTransferDetailExpenseBackup
    /// PSize الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the WarehouseTransferDetailExpenseBackup
    /// PQuantity الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the WarehouseTransferDetailExpenseBackup
    /// WarehouseCode الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the WarehouseTransferDetailExpenseBackup
    /// TWarehouseCode الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the WarehouseTransferDetailExpenseBackup
    /// FWarehouseCode الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TransactionQuantity of the WarehouseTransferDetailExpenseBackup
    /// TransactionQuantity الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? TransactionQuantity { get; private set; }

    /// <summary>
    /// CostCenterCode of the WarehouseTransferDetailExpenseBackup
    /// CostCenterCode الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the WarehouseTransferDetailExpenseBackup
    /// ProjectNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the WarehouseTransferDetailExpenseBackup
    /// ActivityNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// StockCost of the WarehouseTransferDetailExpenseBackup
    /// StockCost الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// ExpireDate of the WarehouseTransferDetailExpenseBackup
    /// ExpireDate الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the WarehouseTransferDetailExpenseBackup
    /// BatchNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// UseSerialNumber of the WarehouseTransferDetailExpenseBackup
    /// UseSerialNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// ExpenseAmount of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// ExpenseAmount1 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount1 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount1 { get; private set; }

    /// <summary>
    /// ExpenseAmount2 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount2 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount2 { get; private set; }

    /// <summary>
    /// ExpenseAmount3 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount3 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount3 { get; private set; }

    /// <summary>
    /// ExpenseAmount4 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount4 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount4 { get; private set; }

    /// <summary>
    /// ExpenseAmount5 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount5 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount5 { get; private set; }

    /// <summary>
    /// ExpenseAmount6 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount6 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount6 { get; private set; }

    /// <summary>
    /// ExpenseAmount7 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount7 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount7 { get; private set; }

    /// <summary>
    /// ExpenseAmount8 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount8 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount8 { get; private set; }

    /// <summary>
    /// ExpenseAmount9 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount9 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount9 { get; private set; }

    /// <summary>
    /// ExpenseAmount10 of the WarehouseTransferDetailExpenseBackup
    /// ExpenseAmount10 الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount10 { get; private set; }

    /// <summary>
    /// RecordNumber of the WarehouseTransferDetailExpenseBackup
    /// RecordNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the WarehouseTransferDetailExpenseBackup
    /// DocSequence الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequenceTr of the WarehouseTransferDetailExpenseBackup
    /// DocSequenceTr الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? DocSequenceTr { get; private set; }

    /// <summary>
    /// BillOfExchangeNumber of the WarehouseTransferDetailExpenseBackup
    /// BillOfExchangeNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string BillOfExchangeNumber { get; private set; }

    /// <summary>
    /// FTransactionNumber of the WarehouseTransferDetailExpenseBackup
    /// FTransactionNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? FTransactionNumber { get; private set; }

    /// <summary>
    /// FTransactionSerial of the WarehouseTransferDetailExpenseBackup
    /// FTransactionSerial الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? FTransactionSerial { get; private set; }

    /// <summary>
    /// UseAttachment of the WarehouseTransferDetailExpenseBackup
    /// UseAttachment الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the WarehouseTransferDetailExpenseBackup
    /// ReceiveAttachment الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemPriceShort of the WarehouseTransferDetailExpenseBackup
    /// ItemPriceShort الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ItemDescription of the WarehouseTransferDetailExpenseBackup
    /// ItemDescription الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the WarehouseTransferDetailExpenseBackup
    /// Barcode الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// DocTypeRef of the WarehouseTransferDetailExpenseBackup
    /// DocTypeRef الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the WarehouseTransferDetailExpenseBackup
    /// DocJvTypeRef الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the WarehouseTransferDetailExpenseBackup
    /// DocNoRef الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the WarehouseTransferDetailExpenseBackup
    /// DocSerRef الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// VendorCode of the WarehouseTransferDetailExpenseBackup
    /// VendorCode الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the WarehouseTransferDetailExpenseBackup
    /// ExternalPostFlag الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// FAvailableQuantity of the WarehouseTransferDetailExpenseBackup
    /// FAvailableQuantity الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? FAvailableQuantity { get; private set; }

    /// <summary>
    /// TAvailableQuantity of the WarehouseTransferDetailExpenseBackup
    /// TAvailableQuantity الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? TAvailableQuantity { get; private set; }

    /// <summary>
    /// ItemLength of the WarehouseTransferDetailExpenseBackup
    /// ItemLength الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the WarehouseTransferDetailExpenseBackup
    /// ItemWidth الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the WarehouseTransferDetailExpenseBackup
    /// ItemHeightShort الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the WarehouseTransferDetailExpenseBackup
    /// ItemNumberShort الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the WarehouseTransferDetailExpenseBackup
    /// PostCode الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the WarehouseTransferDetailExpenseBackup
    /// ArgumentNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// WeightedQuantity of the WarehouseTransferDetailExpenseBackup
    /// WeightedQuantity الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the WarehouseTransferDetailExpenseBackup
    /// WeightedUnit الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WarehouseTransferDetailExpenseBackup
    /// CompanyNumberShort الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WarehouseTransferDetailExpenseBackup
    /// BranchNumber الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WarehouseTransferDetailExpenseBackup
    /// BranchYear الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WarehouseTransferDetailExpenseBackup
    /// BranchUser الخاص بـ WarehouseTransferDetailExpenseBackup
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
