using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// OutgoingDetail Entity
/// </summary>
public class OutgoingDetail : Entity<OutgoingDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<OutgoingMaster> _outgoingMaster = new List<OutgoingMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private OutgoingDetail() { }

    public OutgoingDetail(OutgoingDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the OutgoingDetail
    /// المعرف الفريد لـ OutgoingDetail
    /// </summary>
    public OutgoingDetailId Id { get; private set; }

    /// <summary>
    /// OutgoingNumber of the OutgoingDetail
    /// OutgoingNumber الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the OutgoingDetail
    /// OutgoingTypeFull الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// ItemQuantity of the OutgoingDetail
    /// ItemQuantity الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the OutgoingDetail
    /// PSize الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the OutgoingDetail
    /// PQuantity الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the OutgoingDetail
    /// ItemPriceShort الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the OutgoingDetail
    /// StockCost الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// ExpireDate of the OutgoingDetail
    /// ExpireDate الخاص بـ OutgoingDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the OutgoingDetail
    /// BatchNumber الخاص بـ OutgoingDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ExpenseAmount of the OutgoingDetail
    /// ExpenseAmount الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the OutgoingDetail
    /// UseSerialNumber الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the OutgoingDetail
    /// RecordNumber الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the OutgoingDetail
    /// DocSequence الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocTypeRef of the OutgoingDetail
    /// DocTypeRef الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the OutgoingDetail
    /// DocJvTypeRef الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the OutgoingDetail
    /// DocNoRef الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the OutgoingDetail
    /// DocSerRef الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the OutgoingDetail
    /// DocSequenceRef الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// GroupNumberFull of the OutgoingDetail
    /// GroupNumberFull الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the OutgoingDetail
    /// GuarantorSerial الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// UseAttachment of the OutgoingDetail
    /// UseAttachment الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the OutgoingDetail
    /// ReceiveAttachment الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the OutgoingDetail
    /// ItemDescription الخاص بـ OutgoingDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the OutgoingDetail
    /// Barcode الخاص بـ OutgoingDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ItemLength of the OutgoingDetail
    /// ItemLength الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the OutgoingDetail
    /// ItemWidth الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the OutgoingDetail
    /// ItemHeightShort الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the OutgoingDetail
    /// ItemNumberShort الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the OutgoingDetail
    /// PostCode الخاص بـ OutgoingDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the OutgoingDetail
    /// WeightedQuantity الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the OutgoingDetail
    /// WeightedUnit الخاص بـ OutgoingDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OutgoingDetail
    /// ExternalPostFlag الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// VatPercent of the OutgoingDetail
    /// VatPercent الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the OutgoingDetail
    /// VatAmount الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// ArgumentNumber of the OutgoingDetail
    /// ArgumentNumber الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OutgoingDetail
    /// CompanyNumberShort الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OutgoingDetail
    /// BranchNumber الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OutgoingDetail
    /// BranchYear الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OutgoingDetail
    /// BranchUser الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the OutgoingDetail
    /// WebServiceTransferDataFlag الخاص بـ OutgoingDetail
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// WebServiceTransferDataDescription of the OutgoingDetail
    /// WebServiceTransferDataDescription الخاص بـ OutgoingDetail
    /// </summary>
    public string WebServiceTransferDataDescription { get; private set; }

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
    public ICollection<OutgoingMaster> OutgoingMaster => _outgoingMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
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

