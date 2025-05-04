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
/// OutgoingBillMaster Entity
/// </summary>
public class OutgoingBillMaster : Entity<OutgoingBillMasterId>
{
    private OutgoingBillMaster() { }

    /// <summary>
    /// The unique identifier for the OutgoingBillMaster
    /// المعرف الفريد لـ OutgoingBillMaster
    /// </summary>
    public OutgoingBillMasterId Id { get; private set; }

    /// <summary>
    /// OutgoingNumber of the OutgoingBillMaster
    /// OutgoingNumber الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingSerialShort of the OutgoingBillMaster
    /// OutgoingSerialShort الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? OutgoingSerialShort { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the OutgoingBillMaster
    /// BillDocumentTypeFull الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the OutgoingBillMaster
    /// BillNumber الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the OutgoingBillMaster
    /// BillSerial الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// OutgoingDate of the OutgoingBillMaster
    /// OutgoingDate الخاص بـ OutgoingBillMaster
    /// </summary>
    public DateTime? OutgoingDate { get; private set; }

    /// <summary>
    /// BillCurrency of the OutgoingBillMaster
    /// BillCurrency الخاص بـ OutgoingBillMaster
    /// </summary>
    public string BillCurrency { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the OutgoingBillMaster
    /// SalesInvoiceType الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// BillRate of the OutgoingBillMaster
    /// BillRate الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? BillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the OutgoingBillMaster
    /// StockRateShort الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CCode of the OutgoingBillMaster
    /// CCode الخاص بـ OutgoingBillMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the OutgoingBillMaster
    /// CName الخاص بـ OutgoingBillMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// OutgoingPostFlag of the OutgoingBillMaster
    /// OutgoingPostFlag الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? OutgoingPostFlag { get; private set; }

    /// <summary>
    /// WarehouseCode of the OutgoingBillMaster
    /// WarehouseCode الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the OutgoingBillMaster
    /// ReferenceNumber الخاص بـ OutgoingBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the OutgoingBillMaster
    /// CostCenterCode الخاص بـ OutgoingBillMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the OutgoingBillMaster
    /// ProjectNumber الخاص بـ OutgoingBillMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the OutgoingBillMaster
    /// ActivityNumber الخاص بـ OutgoingBillMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CashNumber of the OutgoingBillMaster
    /// CashNumber الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the OutgoingBillMaster
    /// AccountDescription الخاص بـ OutgoingBillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReceiverName of the OutgoingBillMaster
    /// ReceiverName الخاص بـ OutgoingBillMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// AccountCode of the OutgoingBillMaster
    /// AccountCode الخاص بـ OutgoingBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AttachmentCount of the OutgoingBillMaster
    /// AttachmentCount الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// DriverNo of the OutgoingBillMaster
    /// DriverNo الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// RegionCode of the OutgoingBillMaster
    /// RegionCode الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// SubCustomerCode of the OutgoingBillMaster
    /// SubCustomerCode الخاص بـ OutgoingBillMaster
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// DocBrnNo of the OutgoingBillMaster
    /// DocBrnNo الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// PaidAmount of the OutgoingBillMaster
    /// PaidAmount الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// OutgoingAmount of the OutgoingBillMaster
    /// OutgoingAmount الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? OutgoingAmount { get; private set; }

    /// <summary>
    /// Field1 of the OutgoingBillMaster
    /// Field1 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the OutgoingBillMaster
    /// Field2 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the OutgoingBillMaster
    /// Field3 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the OutgoingBillMaster
    /// Field4 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the OutgoingBillMaster
    /// Field5 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the OutgoingBillMaster
    /// Field6 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the OutgoingBillMaster
    /// Field7 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the OutgoingBillMaster
    /// Field8 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the OutgoingBillMaster
    /// Field9 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the OutgoingBillMaster
    /// Field10 الخاص بـ OutgoingBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OutgoingBillMaster
    /// ExternalPostFlag الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// StandByFlag of the OutgoingBillMaster
    /// StandByFlag الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AuditReference of the OutgoingBillMaster
    /// AuditReference الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the OutgoingBillMaster
    /// AuditReferenceDescription الخاص بـ OutgoingBillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the OutgoingBillMaster
    /// AuditReferenceUserId الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the OutgoingBillMaster
    /// AuditReferenceDate الخاص بـ OutgoingBillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// PostUserId of the OutgoingBillMaster
    /// PostUserId الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the OutgoingBillMaster
    /// PostDate الخاص بـ OutgoingBillMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the OutgoingBillMaster
    /// UnpostUserId الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the OutgoingBillMaster
    /// UnpostDate الخاص بـ OutgoingBillMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the OutgoingBillMaster
    /// OutgoingTypeFull الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OutgoingBillMaster
    /// CompanyNumberShort الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OutgoingBillMaster
    /// BranchNumber الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OutgoingBillMaster
    /// BranchYear الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OutgoingBillMaster
    /// BranchUser الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// OutgoingBillType of the OutgoingBillMaster
    /// OutgoingBillType الخاص بـ OutgoingBillMaster
    /// </summary>
    public decimal? OutgoingBillType { get; private set; }

    /// <summary>
    /// CreatedDateClock of the OutgoingBillMaster
    /// CreatedDateClock الخاص بـ OutgoingBillMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: OutgoingBillMaster to OutgoingBillDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingBillDetail> OutgoingBillDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
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
