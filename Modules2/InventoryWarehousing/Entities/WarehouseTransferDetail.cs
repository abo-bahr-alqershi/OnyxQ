using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// WarehouseTransferDetail Entity
/// </summary>
public class WarehouseTransferDetail : Entity<WarehouseTransferDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();
    private readonly List<WarehouseTransferMaster> _warehouseTransferMaster = new List<WarehouseTransferMaster>();

    private WarehouseTransferDetail() { }

    public WarehouseTransferDetail(WarehouseTransferDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the WarehouseTransferDetail
    /// المعرف الفريد لـ WarehouseTransferDetail
    /// </summary>
    public WarehouseTransferDetailId Id { get; private set; }

    /// <summary>
    /// TransactionInOutType of the WarehouseTransferDetail
    /// TransactionInOutType الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? TransactionInOutType { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the WarehouseTransferDetail
    /// TransactionTypeFull الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

    /// <summary>
    /// TransactionNumberShort of the WarehouseTransferDetail
    /// TransactionNumberShort الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? TransactionNumberShort { get; private set; }

    /// <summary>
    /// ItemQuantity of the WarehouseTransferDetail
    /// ItemQuantity الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the WarehouseTransferDetail
    /// PSize الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the WarehouseTransferDetail
    /// PQuantity الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// TWarehouseCode of the WarehouseTransferDetail
    /// TWarehouseCode الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the WarehouseTransferDetail
    /// FWarehouseCode الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TransactionQuantity of the WarehouseTransferDetail
    /// TransactionQuantity الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? TransactionQuantity { get; private set; }

    /// <summary>
    /// CostCenterCode of the WarehouseTransferDetail
    /// CostCenterCode الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// StockCost of the WarehouseTransferDetail
    /// StockCost الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// ExpireDate of the WarehouseTransferDetail
    /// ExpireDate الخاص بـ WarehouseTransferDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the WarehouseTransferDetail
    /// BatchNumber الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// UseSerialNumber of the WarehouseTransferDetail
    /// UseSerialNumber الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// ExpenseAmount of the WarehouseTransferDetail
    /// ExpenseAmount الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the WarehouseTransferDetail
    /// RecordNumber الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the WarehouseTransferDetail
    /// DocSequence الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequenceTr of the WarehouseTransferDetail
    /// DocSequenceTr الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocSequenceTr { get; private set; }

    /// <summary>
    /// BillOfExchangeNumber of the WarehouseTransferDetail
    /// BillOfExchangeNumber الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string BillOfExchangeNumber { get; private set; }

    /// <summary>
    /// FTransactionNumber of the WarehouseTransferDetail
    /// FTransactionNumber الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? FTransactionNumber { get; private set; }

    /// <summary>
    /// FTransactionSerial of the WarehouseTransferDetail
    /// FTransactionSerial الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? FTransactionSerial { get; private set; }

    /// <summary>
    /// UseAttachment of the WarehouseTransferDetail
    /// UseAttachment الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the WarehouseTransferDetail
    /// ReceiveAttachment الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemPriceShort of the WarehouseTransferDetail
    /// ItemPriceShort الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ItemDescription of the WarehouseTransferDetail
    /// ItemDescription الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the WarehouseTransferDetail
    /// Barcode الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// DocTypeRef of the WarehouseTransferDetail
    /// DocTypeRef الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the WarehouseTransferDetail
    /// DocJvTypeRef الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the WarehouseTransferDetail
    /// DocNoRef الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the WarehouseTransferDetail
    /// DocSerRef الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// VendorCode of the WarehouseTransferDetail
    /// VendorCode الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the WarehouseTransferDetail
    /// ExternalPostFlag الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// FAvailableQuantity of the WarehouseTransferDetail
    /// FAvailableQuantity الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? FAvailableQuantity { get; private set; }

    /// <summary>
    /// TAvailableQuantity of the WarehouseTransferDetail
    /// TAvailableQuantity الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? TAvailableQuantity { get; private set; }

    /// <summary>
    /// ItemLength of the WarehouseTransferDetail
    /// ItemLength الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the WarehouseTransferDetail
    /// ItemWidth الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the WarehouseTransferDetail
    /// ItemHeightShort الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the WarehouseTransferDetail
    /// ItemNumberShort الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the WarehouseTransferDetail
    /// PostCode الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the WarehouseTransferDetail
    /// ArgumentNumber الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// WeightedQuantity of the WarehouseTransferDetail
    /// WeightedQuantity الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the WarehouseTransferDetail
    /// WeightedUnit الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WarehouseTransferDetail
    /// CompanyNumberShort الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WarehouseTransferDetail
    /// BranchNumber الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WarehouseTransferDetail
    /// BranchYear الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WarehouseTransferDetail
    /// BranchUser الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the WarehouseTransferDetail
    /// WebServiceTransferDataFlag الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// WebServiceTransferDataDescription of the WarehouseTransferDetail
    /// WebServiceTransferDataDescription الخاص بـ WarehouseTransferDetail
    /// </summary>
    public string WebServiceTransferDataDescription { get; private set; }

    /// <summary>
    /// DocSequenceRef of the WarehouseTransferDetail
    /// DocSequenceRef الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// TransactionQuantityNotReceived of the WarehouseTransferDetail
    /// TransactionQuantityNotReceived الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? TransactionQuantityNotReceived { get; private set; }

    /// <summary>
    /// DocTypeRefDtl of the WarehouseTransferDetail
    /// DocTypeRefDtl الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocTypeRefDtl { get; private set; }

    /// <summary>
    /// DocNoRefDtl of the WarehouseTransferDetail
    /// DocNoRefDtl الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocNoRefDtl { get; private set; }

    /// <summary>
    /// DocSerRefDtl of the WarehouseTransferDetail
    /// DocSerRefDtl الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocSerRefDtl { get; private set; }

    /// <summary>
    /// DocSequenceRefDtl of the WarehouseTransferDetail
    /// DocSequenceRefDtl الخاص بـ WarehouseTransferDetail
    /// </summary>
    public decimal? DocSequenceRefDtl { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<WarehouseTransferMaster> WarehouseTransferMaster => _warehouseTransferMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

