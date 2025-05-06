using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// WarehouseTransferMaster Entity
/// </summary>
public class WarehouseTransferMaster : Entity<WarehouseTransferMasterId>
{

    private WarehouseTransferMaster() { }

    public WarehouseTransferMaster(WarehouseTransferMasterId id, decimal? transactionSerial)
    {
        Id = id;
        TransactionSerial = transactionSerial;
    }

    /// <summary>
    /// The unique identifier for the WarehouseTransferMaster
    /// المعرف الفريد لـ WarehouseTransferMaster
    /// </summary>
    public WarehouseTransferMasterId Id { get; private set; }

    /// <summary>
    /// TransactionInOutType of the WarehouseTransferMaster
    /// TransactionInOutType الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? TransactionInOutType { get; private set; }

    /// <summary>
    /// TransactionNumberShort of the WarehouseTransferMaster
    /// TransactionNumberShort الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? TransactionNumberShort { get; private set; }

    /// <summary>
    /// TransactionSerial of the WarehouseTransferMaster
    /// TransactionSerial الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    /// <summary>
    /// TransactionDate of the WarehouseTransferMaster
    /// TransactionDate الخاص بـ WarehouseTransferMaster
    /// </summary>
    public DateTime? TransactionDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the WarehouseTransferMaster
    /// ReferenceNumber الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// TWarehouseCode of the WarehouseTransferMaster
    /// TWarehouseCode الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the WarehouseTransferMaster
    /// FWarehouseCode الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TransactionDescription of the WarehouseTransferMaster
    /// TransactionDescription الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string TransactionDescription { get; private set; }

    /// <summary>
    /// StockRate of the WarehouseTransferMaster
    /// StockRate الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// TransactionPostFlag of the WarehouseTransferMaster
    /// TransactionPostFlag الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? TransactionPostFlag { get; private set; }

    /// <summary>
    /// TransactionAmount of the WarehouseTransferMaster
    /// TransactionAmount الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? TransactionAmount { get; private set; }

    /// <summary>
    /// TransactionReason of the WarehouseTransferMaster
    /// TransactionReason الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string TransactionReason { get; private set; }

    /// <summary>
    /// LoadNumber of the WarehouseTransferMaster
    /// LoadNumber الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? LoadNumber { get; private set; }

    /// <summary>
    /// AttachmentCount of the WarehouseTransferMaster
    /// AttachmentCount الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the WarehouseTransferMaster
    /// ProcessedFlagFull الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// StockProcessedFlag of the WarehouseTransferMaster
    /// StockProcessedFlag الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? StockProcessedFlag { get; private set; }

    /// <summary>
    /// ProcessedSalesInvoice of the WarehouseTransferMaster
    /// ProcessedSalesInvoice الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? ProcessedSalesInvoice { get; private set; }

    /// <summary>
    /// HungFlag of the WarehouseTransferMaster
    /// HungFlag الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// TTransactionType of the WarehouseTransferMaster
    /// TTransactionType الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? TTransactionType { get; private set; }

    /// <summary>
    /// TransactionAccountCode of the WarehouseTransferMaster
    /// TransactionAccountCode الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string TransactionAccountCode { get; private set; }

    /// <summary>
    /// ExpenseAmount of the WarehouseTransferMaster
    /// ExpenseAmount الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// CCode of the WarehouseTransferMaster
    /// CCode الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// DocBrnNo of the WarehouseTransferMaster
    /// DocBrnNo الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// AuditReference of the WarehouseTransferMaster
    /// AuditReference الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the WarehouseTransferMaster
    /// AuditReferenceDescription الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the WarehouseTransferMaster
    /// AuditReferenceUserId الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the WarehouseTransferMaster
    /// AuditReferenceDate الخاص بـ WarehouseTransferMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the WarehouseTransferMaster
    /// ExternalPostFlag الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// FTransactionNumber of the WarehouseTransferMaster
    /// FTransactionNumber الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? FTransactionNumber { get; private set; }

    /// <summary>
    /// FTransactionSerial of the WarehouseTransferMaster
    /// FTransactionSerial الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? FTransactionSerial { get; private set; }

    /// <summary>
    /// BillOfExchangeNumber of the WarehouseTransferMaster
    /// BillOfExchangeNumber الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string BillOfExchangeNumber { get; private set; }

    /// <summary>
    /// TransactionCostType of the WarehouseTransferMaster
    /// TransactionCostType الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? TransactionCostType { get; private set; }

    /// <summary>
    /// DiffACode of the WarehouseTransferMaster
    /// DiffACode الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string DiffACode { get; private set; }

    /// <summary>
    /// DiffACy of the WarehouseTransferMaster
    /// DiffACy الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string DiffACy { get; private set; }

    /// <summary>
    /// DiffAmt of the WarehouseTransferMaster
    /// DiffAmt الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? DiffAmt { get; private set; }

    /// <summary>
    /// ReturnTransaction of the WarehouseTransferMaster
    /// ReturnTransaction الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? ReturnTransaction { get; private set; }

    /// <summary>
    /// Field1 of the WarehouseTransferMaster
    /// Field1 الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the WarehouseTransferMaster
    /// Field2 الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the WarehouseTransferMaster
    /// Field3 الخاص بـ WarehouseTransferMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// DriverNo of the WarehouseTransferMaster
    /// DriverNo الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// PostUserId of the WarehouseTransferMaster
    /// PostUserId الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the WarehouseTransferMaster
    /// PostDate الخاص بـ WarehouseTransferMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the WarehouseTransferMaster
    /// UnpostUserId الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the WarehouseTransferMaster
    /// UnpostDate الخاص بـ WarehouseTransferMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WarehouseTransferMaster
    /// CompanyNumberShort الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WarehouseTransferMaster
    /// BranchNumber الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WarehouseTransferMaster
    /// BranchYear الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WarehouseTransferMaster
    /// BranchUser الخاص بـ WarehouseTransferMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public TransferType TransferType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

