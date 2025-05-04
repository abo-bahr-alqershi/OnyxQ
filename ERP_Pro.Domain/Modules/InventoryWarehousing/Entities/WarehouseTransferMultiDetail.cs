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
/// WarehouseTransferMultiDetail Entity
/// </summary>
public class WarehouseTransferMultiDetail : Entity<WarehouseTransferMultiDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<VoucherDetails> _voucherDetails = new List<VoucherDetails>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();
    private readonly List<Warehouse> _warehouseTWCode = new List<Warehouse>();
    private readonly List<WarehouseTransferMultiMaster> _warehouseTransferMultiMaster = new List<WarehouseTransferMultiMaster>();

    private WarehouseTransferMultiDetail() { }

    public WarehouseTransferMultiDetail(WarehouseTransferMultiDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the WarehouseTransferMultiDetail
    /// المعرف الفريد لـ WarehouseTransferMultiDetail
    /// </summary>
    public WarehouseTransferMultiDetailId Id { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the WarehouseTransferMultiDetail
    /// TransactionTypeFull الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

    /// <summary>
    /// TransactionNumberShort of the WarehouseTransferMultiDetail
    /// TransactionNumberShort الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? TransactionNumberShort { get; private set; }

    /// <summary>
    /// ItemQuantity of the WarehouseTransferMultiDetail
    /// ItemQuantity الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the WarehouseTransferMultiDetail
    /// PSize الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the WarehouseTransferMultiDetail
    /// PQuantity الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// TransactionQuantity of the WarehouseTransferMultiDetail
    /// TransactionQuantity الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? TransactionQuantity { get; private set; }

    /// <summary>
    /// CostCenterCode of the WarehouseTransferMultiDetail
    /// CostCenterCode الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ExpireDate of the WarehouseTransferMultiDetail
    /// ExpireDate الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the WarehouseTransferMultiDetail
    /// BatchNumber الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// UseSerialNumber of the WarehouseTransferMultiDetail
    /// UseSerialNumber الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the WarehouseTransferMultiDetail
    /// RecordNumber الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the WarehouseTransferMultiDetail
    /// UseAttachment الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the WarehouseTransferMultiDetail
    /// ReceiveAttachment الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the WarehouseTransferMultiDetail
    /// ItemDescription الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the WarehouseTransferMultiDetail
    /// Barcode الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// DocTypeRef of the WarehouseTransferMultiDetail
    /// DocTypeRef الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the WarehouseTransferMultiDetail
    /// DocNoRef الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the WarehouseTransferMultiDetail
    /// DocSerRef الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ItemLength of the WarehouseTransferMultiDetail
    /// ItemLength الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the WarehouseTransferMultiDetail
    /// ItemWidth الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the WarehouseTransferMultiDetail
    /// ItemHeightShort الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the WarehouseTransferMultiDetail
    /// ItemNumberShort الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the WarehouseTransferMultiDetail
    /// PostCode الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the WarehouseTransferMultiDetail
    /// WeightedQuantity الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the WarehouseTransferMultiDetail
    /// WeightedUnit الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the WarehouseTransferMultiDetail
    /// ArgumentNumber الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WarehouseTransferMultiDetail
    /// CompanyNumberShort الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WarehouseTransferMultiDetail
    /// BranchNumber الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WarehouseTransferMultiDetail
    /// BranchYear الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WarehouseTransferMultiDetail
    /// BranchUser الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the WarehouseTransferMultiDetail
    /// ExternalPostFlag الخاص بـ WarehouseTransferMultiDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

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
    public ICollection<VoucherDetails> VoucherDetails => _voucherDetails;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> WarehouseTWCode => _warehouseTWCode;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<WarehouseTransferMultiMaster> WarehouseTransferMultiMaster => _warehouseTransferMultiMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
