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
/// OutRequestDetail Entity
/// </summary>
public class OutRequestDetail : Entity<OutRequestDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<OutRequestMaster> _outRequestMaster = new List<OutRequestMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private OutRequestDetail() { }

    public OutRequestDetail(OutRequestDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the OutRequestDetail
    /// المعرف الفريد لـ OutRequestDetail
    /// </summary>
    public OutRequestDetailId Id { get; private set; }

    /// <summary>
    /// OutgoingRequestType of the OutRequestDetail
    /// OutgoingRequestType الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? OutgoingRequestType { get; private set; }

    /// <summary>
    /// OutgoingRequestNumber of the OutRequestDetail
    /// OutgoingRequestNumber الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? OutgoingRequestNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the OutRequestDetail
    /// ItemQuantity الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the OutRequestDetail
    /// PSize الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the OutRequestDetail
    /// PQuantity الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemDescription of the OutRequestDetail
    /// ItemDescription الخاص بـ OutRequestDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// RecordNumber of the OutRequestDetail
    /// RecordNumber الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OutRequestDetail
    /// ExternalPostFlag الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ReservedFlag of the OutRequestDetail
    /// ReservedFlag الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ReservedFlag { get; private set; }

    /// <summary>
    /// ReservationDate of the OutRequestDetail
    /// ReservationDate الخاص بـ OutRequestDetail
    /// </summary>
    public DateTime? ReservationDate { get; private set; }

    /// <summary>
    /// UseAttachment of the OutRequestDetail
    /// UseAttachment الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the OutRequestDetail
    /// ReceiveAttachment الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DocTypeRef of the OutRequestDetail
    /// DocTypeRef الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the OutRequestDetail
    /// DocNoRef الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the OutRequestDetail
    /// DocSerRef الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// AvailableQuantity of the OutRequestDetail
    /// AvailableQuantity الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// FAvailableQuantity of the OutRequestDetail
    /// FAvailableQuantity الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? FAvailableQuantity { get; private set; }

    /// <summary>
    /// ItemLength of the OutRequestDetail
    /// ItemLength الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the OutRequestDetail
    /// ItemWidth الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the OutRequestDetail
    /// ItemHeightShort الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the OutRequestDetail
    /// ItemNumberShort الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// FWarehouseCode of the OutRequestDetail
    /// FWarehouseCode الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the OutRequestDetail
    /// WeightedQuantity الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the OutRequestDetail
    /// WeightedUnit الخاص بـ OutRequestDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ExpireDate of the OutRequestDetail
    /// ExpireDate الخاص بـ OutRequestDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the OutRequestDetail
    /// BatchNumber الخاص بـ OutRequestDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// Barcode of the OutRequestDetail
    /// Barcode الخاص بـ OutRequestDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the OutRequestDetail
    /// ArgumentNumber الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OutRequestDetail
    /// CompanyNumberShort الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OutRequestDetail
    /// BranchNumber الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OutRequestDetail
    /// BranchYear الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OutRequestDetail
    /// BranchUser الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocSequence of the OutRequestDetail
    /// DocSequence الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// TransactionQuantityNotReceived of the OutRequestDetail
    /// TransactionQuantityNotReceived الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? TransactionQuantityNotReceived { get; private set; }

    /// <summary>
    /// DocSequenceRef of the OutRequestDetail
    /// DocSequenceRef الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// ReservedQuantity of the OutRequestDetail
    /// ReservedQuantity الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ReservedQuantity { get; private set; }

    /// <summary>
    /// ApprovedQuantity of the OutRequestDetail
    /// ApprovedQuantity الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? ApprovedQuantity { get; private set; }

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
    public ICollection<OutRequestMaster> OutRequestMaster => _outRequestMaster;
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

