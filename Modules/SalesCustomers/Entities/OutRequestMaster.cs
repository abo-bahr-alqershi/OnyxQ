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
/// OutRequestMaster Entity
/// </summary>
public class OutRequestMaster : Entity<OutRequestMasterId>
{
    private OutRequestMaster() { }

    /// <summary>
    /// The unique identifier for the OutRequestMaster
    /// المعرف الفريد لـ OutRequestMaster
    /// </summary>
    public OutRequestMasterId Id { get; private set; }

    /// <summary>
    /// OutgoingRequestType of the OutRequestMaster
    /// OutgoingRequestType الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? OutgoingRequestType { get; private set; }

    /// <summary>
    /// OutgoingRequestNumber of the OutRequestMaster
    /// OutgoingRequestNumber الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? OutgoingRequestNumber { get; private set; }

    /// <summary>
    /// OutgoingRequestSerial of the OutRequestMaster
    /// OutgoingRequestSerial الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? OutgoingRequestSerial { get; private set; }

    /// <summary>
    /// OutgoingRequestDate of the OutRequestMaster
    /// OutgoingRequestDate الخاص بـ OutRequestMaster
    /// </summary>
    public DateTime? OutgoingRequestDate { get; private set; }

    /// <summary>
    /// WarehouseCode of the OutRequestMaster
    /// WarehouseCode الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the OutRequestMaster
    /// FWarehouseCode الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// HierarchyNumber of the OutRequestMaster
    /// HierarchyNumber الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? HierarchyNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the OutRequestMaster
    /// CostCenterCode الخاص بـ OutRequestMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the OutRequestMaster
    /// ProjectNumber الخاص بـ OutRequestMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the OutRequestMaster
    /// ActivityNumber الخاص بـ OutRequestMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// RequestSide of the OutRequestMaster
    /// RequestSide الخاص بـ OutRequestMaster
    /// </summary>
    public string RequestSide { get; private set; }

    /// <summary>
    /// DocDesc of the OutRequestMaster
    /// DocDesc الخاص بـ OutRequestMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the OutRequestMaster
    /// ProcessedFlagFull الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// InactiveFlag of the OutRequestMaster
    /// InactiveFlag الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the OutRequestMaster
    /// InactivatedByUserId الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the OutRequestMaster
    /// InactiveDate الخاص بـ OutRequestMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the OutRequestMaster
    /// InactiveReason الخاص بـ OutRequestMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ApprovedFlag of the OutRequestMaster
    /// ApprovedFlag الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the OutRequestMaster
    /// ApprovalUserId الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the OutRequestMaster
    /// ApprovalDate الخاص بـ OutRequestMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the OutRequestMaster
    /// ApprovalDescription الخاص بـ OutRequestMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the OutRequestMaster
    /// ReferenceNumber الخاص بـ OutRequestMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReserveNumber of the OutRequestMaster
    /// ReserveNumber الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? ReserveNumber { get; private set; }

    /// <summary>
    /// UseRequestMoreOnce of the OutRequestMaster
    /// UseRequestMoreOnce الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? UseRequestMoreOnce { get; private set; }

    /// <summary>
    /// Field1 of the OutRequestMaster
    /// Field1 الخاص بـ OutRequestMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the OutRequestMaster
    /// Field2 الخاص بـ OutRequestMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the OutRequestMaster
    /// Field3 الخاص بـ OutRequestMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OutRequestMaster
    /// ExternalPostFlag الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OutRequestMaster
    /// CompanyNumberShort الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OutRequestMaster
    /// BranchNumber الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OutRequestMaster
    /// BranchYear الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OutRequestMaster
    /// BranchUser الخاص بـ OutRequestMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the OutRequestMaster
    /// DocSerExtrnl الخاص بـ OutRequestMaster
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// CCode of the OutRequestMaster
    /// CCode الخاص بـ OutRequestMaster
    /// </summary>
    public string CCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: OutRequestMaster to OutRequestDetail
    /// </summary>
    public IReadOnlyCollection<OutRequestDetail> OutRequestDetails { get; private set; }
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
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
