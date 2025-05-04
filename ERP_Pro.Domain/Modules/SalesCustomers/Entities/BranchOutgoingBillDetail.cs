using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BranchOutgoingBillDetail Entity
/// </summary>
public class BranchOutgoingBillDetail : Entity<BranchOutgoingBillDetailId>
{

    private BranchOutgoingBillDetail() { }

    public BranchOutgoingBillDetail(BranchOutgoingBillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BranchOutgoingBillDetail
    /// المعرف الفريد لـ BranchOutgoingBillDetail
    /// </summary>
    public BranchOutgoingBillDetailId Id { get; private set; }

    /// <summary>
    /// OutgoingNumber of the BranchOutgoingBillDetail
    /// OutgoingNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// BillNumber of the BranchOutgoingBillDetail
    /// BillNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BranchOutgoingBillDetail
    /// BillSerial الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the BranchOutgoingBillDetail
    /// SalesInvoiceType الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// ItemCode of the BranchOutgoingBillDetail
    /// ItemCode الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchOutgoingBillDetail
    /// ItemQuantity الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the BranchOutgoingBillDetail
    /// FreeQuantity الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchOutgoingBillDetail
    /// ItemUnit الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchOutgoingBillDetail
    /// PSize الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the BranchOutgoingBillDetail
    /// PQuantity الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchOutgoingBillDetail
    /// ItemPriceShort الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the BranchOutgoingBillDetail
    /// StockCost الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchOutgoingBillDetail
    /// WarehouseCode الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchOutgoingBillDetail
    /// CostCenterCode الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchOutgoingBillDetail
    /// ProjectNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchOutgoingBillDetail
    /// ActivityNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchOutgoingBillDetail
    /// ExpireDate الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchOutgoingBillDetail
    /// BatchNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// UseSerialNumber of the BranchOutgoingBillDetail
    /// UseSerialNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// DisAmt of the BranchOutgoingBillDetail
    /// DisAmt الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatAmount of the BranchOutgoingBillDetail
    /// VatAmount الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the BranchOutgoingBillDetail
    /// VatPercent الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchOutgoingBillDetail
    /// RecordNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchOutgoingBillDetail
    /// DocSequence الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// Barcode of the BranchOutgoingBillDetail
    /// Barcode الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UseAttachment of the BranchOutgoingBillDetail
    /// UseAttachment الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchOutgoingBillDetail
    /// ExternalPostFlag الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BranchOutgoingBillDetail
    /// ReceiveAttachment الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the BranchOutgoingBillDetail
    /// OutgoingTypeFull الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// ItemLength of the BranchOutgoingBillDetail
    /// ItemLength الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the BranchOutgoingBillDetail
    /// ItemWidth الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BranchOutgoingBillDetail
    /// ItemHeightShort الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BranchOutgoingBillDetail
    /// ItemNumberShort الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedUnit of the BranchOutgoingBillDetail
    /// WeightedUnit الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BranchOutgoingBillDetail
    /// WeightedQuantity الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// PostCode of the BranchOutgoingBillDetail
    /// PostCode الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// OtherAmount of the BranchOutgoingBillDetail
    /// OtherAmount الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// SubCustomerCode of the BranchOutgoingBillDetail
    /// SubCustomerCode الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BranchOutgoingBillDetail
    /// ArgumentNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the BranchOutgoingBillDetail
    /// ItemDescription الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchOutgoingBillDetail
    /// CompanyNumberShort الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchOutgoingBillDetail
    /// BranchNumber الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchOutgoingBillDetail
    /// BranchYear الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchOutgoingBillDetail
    /// BranchUser الخاص بـ BranchOutgoingBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public BranchOutgoingBillMaster BranchOutgoingBillMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
