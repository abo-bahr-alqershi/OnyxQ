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
/// WarehouseTransferMultiMaster Entity
/// </summary>
public class WarehouseTransferMultiMaster : AggregateRoot<WarehouseTransferMultiMasterId>
{

    private WarehouseTransferMultiMaster() { }

    public WarehouseTransferMultiMaster(WarehouseTransferMultiMasterId id, decimal? transactionSerial)
    {
        Id = id;
        TransactionSerial = transactionSerial;
    }

    /// <summary>
    /// The unique identifier for the WarehouseTransferMultiMaster
    /// المعرف الفريد لـ WarehouseTransferMultiMaster
    /// </summary>
    public WarehouseTransferMultiMasterId Id { get; private set; }

    /// <summary>
    /// TransactionNumberShort of the WarehouseTransferMultiMaster
    /// TransactionNumberShort الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? TransactionNumberShort { get; private set; }

    /// <summary>
    /// TransactionSerial of the WarehouseTransferMultiMaster
    /// TransactionSerial الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    /// <summary>
    /// TransactionDate of the WarehouseTransferMultiMaster
    /// TransactionDate الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public DateTime? TransactionDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the WarehouseTransferMultiMaster
    /// ReferenceNumber الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// TransactionDescription of the WarehouseTransferMultiMaster
    /// TransactionDescription الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public string TransactionDescription { get; private set; }

    /// <summary>
    /// StockRate of the WarehouseTransferMultiMaster
    /// StockRate الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// TransactionAmount of the WarehouseTransferMultiMaster
    /// TransactionAmount الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? TransactionAmount { get; private set; }

    /// <summary>
    /// TransactionReason of the WarehouseTransferMultiMaster
    /// TransactionReason الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public string TransactionReason { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the WarehouseTransferMultiMaster
    /// ProcessedFlagFull الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// HungFlag of the WarehouseTransferMultiMaster
    /// HungFlag الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// DriverNo of the WarehouseTransferMultiMaster
    /// DriverNo الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// DocBrnNo of the WarehouseTransferMultiMaster
    /// DocBrnNo الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WarehouseTransferMultiMaster
    /// CompanyNumberShort الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WarehouseTransferMultiMaster
    /// BranchNumber الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WarehouseTransferMultiMaster
    /// BranchYear الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WarehouseTransferMultiMaster
    /// BranchUser الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the WarehouseTransferMultiMaster
    /// ExternalPostFlag الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

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
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

