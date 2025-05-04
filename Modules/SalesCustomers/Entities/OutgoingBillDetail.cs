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
/// OutgoingBillDetail Entity
/// </summary>
public class OutgoingBillDetail : Entity<OutgoingBillDetailId>
{
    private OutgoingBillDetail() { }

    /// <summary>
    /// The unique identifier for the OutgoingBillDetail
    /// المعرف الفريد لـ OutgoingBillDetail
    /// </summary>
    public OutgoingBillDetailId Id { get; private set; }

    /// <summary>
    /// OutgoingNumber of the OutgoingBillDetail
    /// OutgoingNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingSerialShort of the OutgoingBillDetail
    /// OutgoingSerialShort الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? OutgoingSerialShort { get; private set; }

    /// <summary>
    /// BillNumber of the OutgoingBillDetail
    /// BillNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the OutgoingBillDetail
    /// BillSerial الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the OutgoingBillDetail
    /// SalesInvoiceType الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// ItemCode of the OutgoingBillDetail
    /// ItemCode الخاص بـ OutgoingBillDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the OutgoingBillDetail
    /// ItemQuantity الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the OutgoingBillDetail
    /// FreeQuantity الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the OutgoingBillDetail
    /// ItemUnit الخاص بـ OutgoingBillDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the OutgoingBillDetail
    /// PSize الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the OutgoingBillDetail
    /// PQuantity الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the OutgoingBillDetail
    /// ItemPriceShort الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the OutgoingBillDetail
    /// StockCost الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// WarehouseCode of the OutgoingBillDetail
    /// WarehouseCode الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the OutgoingBillDetail
    /// CostCenterCode الخاص بـ OutgoingBillDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the OutgoingBillDetail
    /// ProjectNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the OutgoingBillDetail
    /// ActivityNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the OutgoingBillDetail
    /// ExpireDate الخاص بـ OutgoingBillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the OutgoingBillDetail
    /// BatchNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// UseSerialNumber of the OutgoingBillDetail
    /// UseSerialNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// DisAmt of the OutgoingBillDetail
    /// DisAmt الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatAmount of the OutgoingBillDetail
    /// VatAmount الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the OutgoingBillDetail
    /// VatPercent الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// RecordNumber of the OutgoingBillDetail
    /// RecordNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the OutgoingBillDetail
    /// DocSequence الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// Barcode of the OutgoingBillDetail
    /// Barcode الخاص بـ OutgoingBillDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UseAttachment of the OutgoingBillDetail
    /// UseAttachment الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the OutgoingBillDetail
    /// ReceiveAttachment الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the OutgoingBillDetail
    /// OutgoingTypeFull الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// ItemLength of the OutgoingBillDetail
    /// ItemLength الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the OutgoingBillDetail
    /// ItemWidth الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the OutgoingBillDetail
    /// ItemHeightShort الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the OutgoingBillDetail
    /// ItemNumberShort الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedUnit of the OutgoingBillDetail
    /// WeightedUnit الخاص بـ OutgoingBillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the OutgoingBillDetail
    /// WeightedQuantity الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// PostCode of the OutgoingBillDetail
    /// PostCode الخاص بـ OutgoingBillDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// OtherAmount of the OutgoingBillDetail
    /// OtherAmount الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// SubCustomerCode of the OutgoingBillDetail
    /// SubCustomerCode الخاص بـ OutgoingBillDetail
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the OutgoingBillDetail
    /// ArgumentNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the OutgoingBillDetail
    /// ItemDescription الخاص بـ OutgoingBillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OutgoingBillDetail
    /// CompanyNumberShort الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OutgoingBillDetail
    /// BranchNumber الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OutgoingBillDetail
    /// BranchYear الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OutgoingBillDetail
    /// BranchUser الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OutgoingBillDetail
    /// ExternalPostFlag الخاص بـ OutgoingBillDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

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
    /// <summary>
    /// ManyToOne relationship to OutgoingBillMaster
    /// </summary>
    public OutgoingBillMaster OutgoingBillMaster { get; private set; }
    #endregion
}
}
