using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// OutRequestDetail Entity
/// </summary>
public class OutRequestDetail : Entity<OutRequestDetailId>
{
    private OutRequestDetail() { }

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
    /// OutgoingRequestSerial of the OutRequestDetail
    /// OutgoingRequestSerial الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? OutgoingRequestSerial { get; private set; }

    /// <summary>
    /// ItemCode of the OutRequestDetail
    /// ItemCode الخاص بـ OutRequestDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the OutRequestDetail
    /// ItemUnit الخاص بـ OutRequestDetail
    /// </summary>
    public string ItemUnit { get; private set; }

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
    /// WarehouseCode of the OutRequestDetail
    /// WarehouseCode الخاص بـ OutRequestDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

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
    /// CostCenterCode of the OutRequestDetail
    /// CostCenterCode الخاص بـ OutRequestDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the OutRequestDetail
    /// ProjectNumber الخاص بـ OutRequestDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the OutRequestDetail
    /// ActivityNumber الخاص بـ OutRequestDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

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
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to OutRequestMaster
    /// </summary>
    public OutRequestMaster OutRequestMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
