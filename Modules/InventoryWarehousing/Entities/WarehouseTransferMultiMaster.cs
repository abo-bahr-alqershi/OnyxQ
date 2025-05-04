using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// WarehouseTransferMultiMaster Entity
/// </summary>
public class WarehouseTransferMultiMaster : Entity<WarehouseTransferMultiMasterId>
{
    private WarehouseTransferMultiMaster() { }

    /// <summary>
    /// The unique identifier for the WarehouseTransferMultiMaster
    /// المعرف الفريد لـ WarehouseTransferMultiMaster
    /// </summary>
    public WarehouseTransferMultiMasterId Id { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the WarehouseTransferMultiMaster
    /// TransactionTypeFull الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

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
    /// CostCenterCode of the WarehouseTransferMultiMaster
    /// CostCenterCode الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the WarehouseTransferMultiMaster
    /// ProjectNumber الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the WarehouseTransferMultiMaster
    /// ActivityNumber الخاص بـ WarehouseTransferMultiMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

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
    /// One-to-many relationship: WarehouseTransferMultiMaster to WarehouseTransferMultiDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiDetail> WarehouseTransferMultiDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to TransferType
    /// </summary>
    public TransferType TransferType { get; private set; }
    #endregion
}
}
