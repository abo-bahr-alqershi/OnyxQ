using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BranchOutgoingBillMaster Entity
/// </summary>
public class BranchOutgoingBillMaster : Entity<BranchOutgoingBillMasterId>
{

    private BranchOutgoingBillMaster() { }

    public BranchOutgoingBillMaster(BranchOutgoingBillMasterId id, decimal? outgoingSerialShort)
    {
        Id = id;
        OutgoingSerialShort = outgoingSerialShort;
    }

    /// <summary>
    /// The unique identifier for the BranchOutgoingBillMaster
    /// المعرف الفريد لـ BranchOutgoingBillMaster
    /// </summary>
    public BranchOutgoingBillMasterId Id { get; private set; }

    /// <summary>
    /// OutgoingNumber of the BranchOutgoingBillMaster
    /// OutgoingNumber الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingSerialShort of the BranchOutgoingBillMaster
    /// OutgoingSerialShort الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? OutgoingSerialShort { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchOutgoingBillMaster
    /// BillDocumentTypeFull الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the BranchOutgoingBillMaster
    /// BillNumber الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BranchOutgoingBillMaster
    /// BillSerial الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// OutgoingDate of the BranchOutgoingBillMaster
    /// OutgoingDate الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public DateTime? OutgoingDate { get; private set; }

    /// <summary>
    /// BillCurrency of the BranchOutgoingBillMaster
    /// BillCurrency الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string BillCurrency { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the BranchOutgoingBillMaster
    /// SalesInvoiceType الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// BillRate of the BranchOutgoingBillMaster
    /// BillRate الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? BillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the BranchOutgoingBillMaster
    /// StockRateShort الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CCode of the BranchOutgoingBillMaster
    /// CCode الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the BranchOutgoingBillMaster
    /// CName الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// OutgoingPostFlag of the BranchOutgoingBillMaster
    /// OutgoingPostFlag الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? OutgoingPostFlag { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchOutgoingBillMaster
    /// WarehouseCode الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchOutgoingBillMaster
    /// ReferenceNumber الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchOutgoingBillMaster
    /// CostCenterCode الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchOutgoingBillMaster
    /// ProjectNumber الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchOutgoingBillMaster
    /// ActivityNumber الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CashNumber of the BranchOutgoingBillMaster
    /// CashNumber الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the BranchOutgoingBillMaster
    /// AccountDescription الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReceiverName of the BranchOutgoingBillMaster
    /// ReceiverName الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// AccountCode of the BranchOutgoingBillMaster
    /// AccountCode الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// OutgoingBillType of the BranchOutgoingBillMaster
    /// OutgoingBillType الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? OutgoingBillType { get; private set; }

    /// <summary>
    /// AttachmentCount of the BranchOutgoingBillMaster
    /// AttachmentCount الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// DriverNo of the BranchOutgoingBillMaster
    /// DriverNo الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// RegionCode of the BranchOutgoingBillMaster
    /// RegionCode الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// SubCustomerCode of the BranchOutgoingBillMaster
    /// SubCustomerCode الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchOutgoingBillMaster
    /// DocBrnNo الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// PaidAmount of the BranchOutgoingBillMaster
    /// PaidAmount الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// OutgoingAmount of the BranchOutgoingBillMaster
    /// OutgoingAmount الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? OutgoingAmount { get; private set; }

    /// <summary>
    /// Field1 of the BranchOutgoingBillMaster
    /// Field1 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchOutgoingBillMaster
    /// Field2 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchOutgoingBillMaster
    /// Field3 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BranchOutgoingBillMaster
    /// Field4 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BranchOutgoingBillMaster
    /// Field5 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BranchOutgoingBillMaster
    /// Field6 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BranchOutgoingBillMaster
    /// Field7 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BranchOutgoingBillMaster
    /// Field8 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BranchOutgoingBillMaster
    /// Field9 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BranchOutgoingBillMaster
    /// Field10 الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchOutgoingBillMaster
    /// ExternalPostFlag الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// StandByFlag of the BranchOutgoingBillMaster
    /// StandByFlag الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AuditReference of the BranchOutgoingBillMaster
    /// AuditReference الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BranchOutgoingBillMaster
    /// AuditReferenceDescription الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BranchOutgoingBillMaster
    /// AuditReferenceUserId الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BranchOutgoingBillMaster
    /// AuditReferenceDate الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// CreatedDateClock of the BranchOutgoingBillMaster
    /// CreatedDateClock الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// PostUserId of the BranchOutgoingBillMaster
    /// PostUserId الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BranchOutgoingBillMaster
    /// PostDate الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BranchOutgoingBillMaster
    /// UnpostUserId الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BranchOutgoingBillMaster
    /// UnpostDate الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the BranchOutgoingBillMaster
    /// OutgoingTypeFull الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchOutgoingBillMaster
    /// CompanyNumberShort الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchOutgoingBillMaster
    /// BranchNumber الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchOutgoingBillMaster
    /// BranchYear الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchOutgoingBillMaster
    /// BranchUser الخاص بـ BranchOutgoingBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

