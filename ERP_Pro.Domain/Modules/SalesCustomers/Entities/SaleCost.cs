using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SaleCost Entity
/// </summary>
public class SaleCost : Entity<SaleCostId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private SaleCost() { }

    public SaleCost(SaleCostId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SaleCost
    /// المعرف الفريد لـ SaleCost
    /// </summary>
    public SaleCostId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the SaleCost
    /// BillTypeFull الخاص بـ SaleCost
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SaleCost
    /// BillDocumentTypeFull الخاص بـ SaleCost
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the SaleCost
    /// BillNumber الخاص بـ SaleCost
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// DocSer of the SaleCost
    /// DocSer الخاص بـ SaleCost
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the SaleCost
    /// DocDate الخاص بـ SaleCost
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemQuantity of the SaleCost
    /// ItemQuantity الخاص بـ SaleCost
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the SaleCost
    /// PSize الخاص بـ SaleCost
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the SaleCost
    /// PQuantity الخاص بـ SaleCost
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemCostShort of the SaleCost
    /// ItemCostShort الخاص بـ SaleCost
    /// </summary>
    public decimal? ItemCostShort { get; private set; }

    /// <summary>
    /// PurchaseInvoiceType of the SaleCost
    /// PurchaseInvoiceType الخاص بـ SaleCost
    /// </summary>
    public decimal? PurchaseInvoiceType { get; private set; }

    /// <summary>
    /// GroupNumberFull of the SaleCost
    /// GroupNumberFull الخاص بـ SaleCost
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the SaleCost
    /// GuarantorSerial الخاص بـ SaleCost
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// DocSequenceGr of the SaleCost
    /// DocSequenceGr الخاص بـ SaleCost
    /// </summary>
    public decimal? DocSequenceGr { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the SaleCost
    /// WarehouseGroupCode الخاص بـ SaleCost
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the SaleCost
    /// CostCenterCode الخاص بـ SaleCost
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// VendorCode of the SaleCost
    /// VendorCode الخاص بـ SaleCost
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ExpireDate of the SaleCost
    /// ExpireDate الخاص بـ SaleCost
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the SaleCost
    /// BatchNumber الخاص بـ SaleCost
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the SaleCost
    /// RecordNumber الخاص بـ SaleCost
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the SaleCost
    /// DocSequence الخاص بـ SaleCost
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// Barcode of the SaleCost
    /// Barcode الخاص بـ SaleCost
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ReceiverNumber of the SaleCost
    /// ReceiverNumber الخاص بـ SaleCost
    /// </summary>
    public decimal? ReceiverNumber { get; private set; }

    /// <summary>
    /// OutgoingNumber of the SaleCost
    /// OutgoingNumber الخاص بـ SaleCost
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the SaleCost
    /// OutgoingGroupSerial الخاص بـ SaleCost
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// ItemLength of the SaleCost
    /// ItemLength الخاص بـ SaleCost
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the SaleCost
    /// ItemWidth الخاص بـ SaleCost
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the SaleCost
    /// ItemHeightShort الخاص بـ SaleCost
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the SaleCost
    /// ItemNumberShort الخاص بـ SaleCost
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// ArgumentNumber of the SaleCost
    /// ArgumentNumber الخاص بـ SaleCost
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// WeightedQuantity of the SaleCost
    /// WeightedQuantity الخاص بـ SaleCost
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the SaleCost
    /// WeightedUnit الخاص بـ SaleCost
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SaleCost
    /// CompanyNumberShort الخاص بـ SaleCost
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SaleCost
    /// BranchNumber الخاص بـ SaleCost
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SaleCost
    /// BranchYear الخاص بـ SaleCost
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SaleCost
    /// BranchUser الخاص بـ SaleCost
    /// </summary>
    public decimal? BranchUser { get; private set; }

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
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
