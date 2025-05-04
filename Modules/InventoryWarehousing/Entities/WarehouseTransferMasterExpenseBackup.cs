using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// WarehouseTransferMasterExpenseBackup Entity
/// </summary>
public class WarehouseTransferMasterExpenseBackup : Entity<WarehouseTransferMasterExpenseBackupId>
{
    private WarehouseTransferMasterExpenseBackup() { }

    /// <summary>
    /// The unique identifier for the WarehouseTransferMasterExpenseBackup
    /// المعرف الفريد لـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public WarehouseTransferMasterExpenseBackupId Id { get; private set; }

    /// <summary>
    /// TransactionInOutType of the WarehouseTransferMasterExpenseBackup
    /// TransactionInOutType الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TransactionInOutType { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the WarehouseTransferMasterExpenseBackup
    /// TransactionTypeFull الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

    /// <summary>
    /// TransactionNumberShort of the WarehouseTransferMasterExpenseBackup
    /// TransactionNumberShort الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TransactionNumberShort { get; private set; }

    /// <summary>
    /// TransactionSerial of the WarehouseTransferMasterExpenseBackup
    /// TransactionSerial الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    /// <summary>
    /// TransactionDate of the WarehouseTransferMasterExpenseBackup
    /// TransactionDate الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public DateTime? TransactionDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the WarehouseTransferMasterExpenseBackup
    /// ReferenceNumber الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the WarehouseTransferMasterExpenseBackup
    /// WarehouseCode الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the WarehouseTransferMasterExpenseBackup
    /// TWarehouseCode الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the WarehouseTransferMasterExpenseBackup
    /// FWarehouseCode الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the WarehouseTransferMasterExpenseBackup
    /// CostCenterCode الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the WarehouseTransferMasterExpenseBackup
    /// ProjectNumber الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the WarehouseTransferMasterExpenseBackup
    /// ActivityNumber الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// TransactionDescription of the WarehouseTransferMasterExpenseBackup
    /// TransactionDescription الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string TransactionDescription { get; private set; }

    /// <summary>
    /// StockRate of the WarehouseTransferMasterExpenseBackup
    /// StockRate الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// TransactionPostFlag of the WarehouseTransferMasterExpenseBackup
    /// TransactionPostFlag الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TransactionPostFlag { get; private set; }

    /// <summary>
    /// TransactionAmount of the WarehouseTransferMasterExpenseBackup
    /// TransactionAmount الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TransactionAmount { get; private set; }

    /// <summary>
    /// TransactionReason of the WarehouseTransferMasterExpenseBackup
    /// TransactionReason الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string TransactionReason { get; private set; }

    /// <summary>
    /// LoadNumber of the WarehouseTransferMasterExpenseBackup
    /// LoadNumber الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? LoadNumber { get; private set; }

    /// <summary>
    /// AttachmentCount of the WarehouseTransferMasterExpenseBackup
    /// AttachmentCount الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the WarehouseTransferMasterExpenseBackup
    /// ProcessedFlagFull الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// StockProcessedFlag of the WarehouseTransferMasterExpenseBackup
    /// StockProcessedFlag الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? StockProcessedFlag { get; private set; }

    /// <summary>
    /// ProcessedSalesInvoice of the WarehouseTransferMasterExpenseBackup
    /// ProcessedSalesInvoice الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ProcessedSalesInvoice { get; private set; }

    /// <summary>
    /// HungFlag of the WarehouseTransferMasterExpenseBackup
    /// HungFlag الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// TTransactionType of the WarehouseTransferMasterExpenseBackup
    /// TTransactionType الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TTransactionType { get; private set; }

    /// <summary>
    /// TransactionAccountCode of the WarehouseTransferMasterExpenseBackup
    /// TransactionAccountCode الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string TransactionAccountCode { get; private set; }

    /// <summary>
    /// ExpenseAccountCode1 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode1 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode1 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode2 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode2 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode2 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode3 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode3 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode3 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode4 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode4 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode4 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode5 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode5 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode5 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode6 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode6 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode6 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode7 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode7 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode7 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode8 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode8 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode8 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode9 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode9 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode9 { get; private set; }

    /// <summary>
    /// ExpenseAccountCode10 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAccountCode10 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseAccountCode10 { get; private set; }

    /// <summary>
    /// ExpenseAmount of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// ExpenseAmount1 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount1 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount1 { get; private set; }

    /// <summary>
    /// ExpenseAmount2 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount2 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount2 { get; private set; }

    /// <summary>
    /// ExpenseAmount3 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount3 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount3 { get; private set; }

    /// <summary>
    /// ExpenseAmount4 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount4 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount4 { get; private set; }

    /// <summary>
    /// ExpenseAmount5 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount5 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount5 { get; private set; }

    /// <summary>
    /// ExpenseAmount6 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount6 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount6 { get; private set; }

    /// <summary>
    /// ExpenseAmount7 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount7 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount7 { get; private set; }

    /// <summary>
    /// ExpenseAmount8 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount8 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount8 { get; private set; }

    /// <summary>
    /// ExpenseAmount9 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount9 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount9 { get; private set; }

    /// <summary>
    /// ExpenseAmount10 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseAmount10 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExpenseAmount10 { get; private set; }

    /// <summary>
    /// ExpenseDescription1 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription1 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription1 { get; private set; }

    /// <summary>
    /// ExpenseDescription2 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription2 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription2 { get; private set; }

    /// <summary>
    /// ExpenseDescription3 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription3 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription3 { get; private set; }

    /// <summary>
    /// ExpenseDescription4 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription4 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription4 { get; private set; }

    /// <summary>
    /// ExpenseDescription5 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription5 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription5 { get; private set; }

    /// <summary>
    /// ExpenseDescription6 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription6 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription6 { get; private set; }

    /// <summary>
    /// ExpenseDescription7 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription7 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription7 { get; private set; }

    /// <summary>
    /// ExpenseDescription8 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription8 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription8 { get; private set; }

    /// <summary>
    /// ExpenseDescription9 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription9 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription9 { get; private set; }

    /// <summary>
    /// ExpenseDescription10 of the WarehouseTransferMasterExpenseBackup
    /// ExpenseDescription10 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string ExpenseDescription10 { get; private set; }

    /// <summary>
    /// CCode of the WarehouseTransferMasterExpenseBackup
    /// CCode الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// DocBrnNo of the WarehouseTransferMasterExpenseBackup
    /// DocBrnNo الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// AuditReference of the WarehouseTransferMasterExpenseBackup
    /// AuditReference الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the WarehouseTransferMasterExpenseBackup
    /// AuditReferenceDescription الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the WarehouseTransferMasterExpenseBackup
    /// AuditReferenceUserId الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the WarehouseTransferMasterExpenseBackup
    /// AuditReferenceDate الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the WarehouseTransferMasterExpenseBackup
    /// ExternalPostFlag الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// FTransactionNumber of the WarehouseTransferMasterExpenseBackup
    /// FTransactionNumber الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? FTransactionNumber { get; private set; }

    /// <summary>
    /// FTransactionSerial of the WarehouseTransferMasterExpenseBackup
    /// FTransactionSerial الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? FTransactionSerial { get; private set; }

    /// <summary>
    /// BillOfExchangeNumber of the WarehouseTransferMasterExpenseBackup
    /// BillOfExchangeNumber الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string BillOfExchangeNumber { get; private set; }

    /// <summary>
    /// TransactionCostType of the WarehouseTransferMasterExpenseBackup
    /// TransactionCostType الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? TransactionCostType { get; private set; }

    /// <summary>
    /// DiffACode of the WarehouseTransferMasterExpenseBackup
    /// DiffACode الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string DiffACode { get; private set; }

    /// <summary>
    /// DiffACy of the WarehouseTransferMasterExpenseBackup
    /// DiffACy الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string DiffACy { get; private set; }

    /// <summary>
    /// DiffAmt of the WarehouseTransferMasterExpenseBackup
    /// DiffAmt الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? DiffAmt { get; private set; }

    /// <summary>
    /// ReturnTransaction of the WarehouseTransferMasterExpenseBackup
    /// ReturnTransaction الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? ReturnTransaction { get; private set; }

    /// <summary>
    /// Field1 of the WarehouseTransferMasterExpenseBackup
    /// Field1 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the WarehouseTransferMasterExpenseBackup
    /// Field2 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the WarehouseTransferMasterExpenseBackup
    /// Field3 الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// DriverNo of the WarehouseTransferMasterExpenseBackup
    /// DriverNo الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// PostUserId of the WarehouseTransferMasterExpenseBackup
    /// PostUserId الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the WarehouseTransferMasterExpenseBackup
    /// PostDate الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the WarehouseTransferMasterExpenseBackup
    /// UnpostUserId الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the WarehouseTransferMasterExpenseBackup
    /// UnpostDate الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WarehouseTransferMasterExpenseBackup
    /// CompanyNumberShort الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WarehouseTransferMasterExpenseBackup
    /// BranchNumber الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WarehouseTransferMasterExpenseBackup
    /// BranchYear الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WarehouseTransferMasterExpenseBackup
    /// BranchUser الخاص بـ WarehouseTransferMasterExpenseBackup
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
