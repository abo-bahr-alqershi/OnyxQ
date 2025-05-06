using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BranchWarehouseTransferMaster Entity
/// </summary>
public class BranchWarehouseTransferMaster : Entity<BranchWarehouseTransferMasterId>
{

    private BranchWarehouseTransferMaster() { }

    public BranchWarehouseTransferMaster(BranchWarehouseTransferMasterId id, decimal? transactionSerial)
    {
        Id = id;
        TransactionSerial = transactionSerial;
    }

    /// <summary>
    /// The unique identifier for the BranchWarehouseTransferMaster
    /// المعرف الفريد لـ BranchWarehouseTransferMaster
    /// </summary>
    public BranchWarehouseTransferMasterId Id { get; private set; }

    /// <summary>
    /// TransactionInOutType of the BranchWarehouseTransferMaster
    /// TransactionInOutType الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TransactionInOutType { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the BranchWarehouseTransferMaster
    /// TransactionTypeFull الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

    /// <summary>
    /// TransactionNumberShort of the BranchWarehouseTransferMaster
    /// TransactionNumberShort الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TransactionNumberShort { get; private set; }

    /// <summary>
    /// TransactionSerial of the BranchWarehouseTransferMaster
    /// TransactionSerial الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    /// <summary>
    /// TransactionDate of the BranchWarehouseTransferMaster
    /// TransactionDate الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public DateTime? TransactionDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchWarehouseTransferMaster
    /// ReferenceNumber الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchWarehouseTransferMaster
    /// WarehouseCode الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the BranchWarehouseTransferMaster
    /// TWarehouseCode الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the BranchWarehouseTransferMaster
    /// FWarehouseCode الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchWarehouseTransferMaster
    /// CostCenterCode الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// TransactionAccountCode of the BranchWarehouseTransferMaster
    /// TransactionAccountCode الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string TransactionAccountCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchWarehouseTransferMaster
    /// ProjectNumber الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// TransactionDescription of the BranchWarehouseTransferMaster
    /// TransactionDescription الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string TransactionDescription { get; private set; }

    /// <summary>
    /// StockRate of the BranchWarehouseTransferMaster
    /// StockRate الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// TransactionPostFlag of the BranchWarehouseTransferMaster
    /// TransactionPostFlag الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TransactionPostFlag { get; private set; }

    /// <summary>
    /// TransactionAmount of the BranchWarehouseTransferMaster
    /// TransactionAmount الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TransactionAmount { get; private set; }

    /// <summary>
    /// TransactionReason of the BranchWarehouseTransferMaster
    /// TransactionReason الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string TransactionReason { get; private set; }

    /// <summary>
    /// LoadNumber of the BranchWarehouseTransferMaster
    /// LoadNumber الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? LoadNumber { get; private set; }

    /// <summary>
    /// AttachmentCount of the BranchWarehouseTransferMaster
    /// AttachmentCount الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the BranchWarehouseTransferMaster
    /// ProcessedFlagFull الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// StockProcessedFlag of the BranchWarehouseTransferMaster
    /// StockProcessedFlag الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? StockProcessedFlag { get; private set; }

    /// <summary>
    /// ProcessedSalesInvoice of the BranchWarehouseTransferMaster
    /// ProcessedSalesInvoice الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? ProcessedSalesInvoice { get; private set; }

    /// <summary>
    /// HungFlag of the BranchWarehouseTransferMaster
    /// HungFlag الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// TTransactionType of the BranchWarehouseTransferMaster
    /// TTransactionType الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TTransactionType { get; private set; }

    /// <summary>
    /// ExpenseAmount of the BranchWarehouseTransferMaster
    /// ExpenseAmount الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// CCode of the BranchWarehouseTransferMaster
    /// CCode الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchWarehouseTransferMaster
    /// DocBrnNo الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// AuditReference of the BranchWarehouseTransferMaster
    /// AuditReference الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BranchWarehouseTransferMaster
    /// AuditReferenceDescription الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BranchWarehouseTransferMaster
    /// AuditReferenceUserId الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BranchWarehouseTransferMaster
    /// AuditReferenceDate الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchWarehouseTransferMaster
    /// ExternalPostFlag الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// FTransactionNumber of the BranchWarehouseTransferMaster
    /// FTransactionNumber الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? FTransactionNumber { get; private set; }

    /// <summary>
    /// FTransactionSerial of the BranchWarehouseTransferMaster
    /// FTransactionSerial الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? FTransactionSerial { get; private set; }

    /// <summary>
    /// BillOfExchangeNumber of the BranchWarehouseTransferMaster
    /// BillOfExchangeNumber الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string BillOfExchangeNumber { get; private set; }

    /// <summary>
    /// TransactionCostType of the BranchWarehouseTransferMaster
    /// TransactionCostType الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? TransactionCostType { get; private set; }

    /// <summary>
    /// DiffACode of the BranchWarehouseTransferMaster
    /// DiffACode الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string DiffACode { get; private set; }

    /// <summary>
    /// DiffACy of the BranchWarehouseTransferMaster
    /// DiffACy الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string DiffACy { get; private set; }

    /// <summary>
    /// DiffAmt of the BranchWarehouseTransferMaster
    /// DiffAmt الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? DiffAmt { get; private set; }

    /// <summary>
    /// ReturnTransaction of the BranchWarehouseTransferMaster
    /// ReturnTransaction الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? ReturnTransaction { get; private set; }

    /// <summary>
    /// Field1 of the BranchWarehouseTransferMaster
    /// Field1 الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchWarehouseTransferMaster
    /// Field2 الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchWarehouseTransferMaster
    /// Field3 الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// DriverNo of the BranchWarehouseTransferMaster
    /// DriverNo الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// PostUserId of the BranchWarehouseTransferMaster
    /// PostUserId الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BranchWarehouseTransferMaster
    /// PostDate الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BranchWarehouseTransferMaster
    /// UnpostUserId الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BranchWarehouseTransferMaster
    /// UnpostDate الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchWarehouseTransferMaster
    /// CompanyNumberShort الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchWarehouseTransferMaster
    /// BranchNumber الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchWarehouseTransferMaster
    /// BranchYear الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchWarehouseTransferMaster
    /// BranchUser الخاص بـ BranchWarehouseTransferMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

