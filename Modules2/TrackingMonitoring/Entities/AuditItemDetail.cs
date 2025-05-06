using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;
namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditItemDetail Entity
/// </summary>
public class AuditItemDetail : Entity<AuditItemDetailId>
{

    private AuditItemDetail() { }

    public AuditItemDetail(AuditItemDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AuditItemDetail
    /// المعرف الفريد لـ AuditItemDetail
    /// </summary>
    public AuditItemDetailId Id { get; private set; }

    /// <summary>
    /// DocType of the AuditItemDetail
    /// DocType الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AuditItemDetail
    /// JournalVoucherTypeFull الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the AuditItemDetail
    /// DocNo الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AuditItemDetail
    /// DocSer الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ItemCode of the AuditItemDetail
    /// ItemCode الخاص بـ AuditItemDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the AuditItemDetail
    /// ItemQuantity الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the AuditItemDetail
    /// FreeQuantity الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the AuditItemDetail
    /// ItemUnit الخاص بـ AuditItemDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AuditItemDetail
    /// PSize الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the AuditItemDetail
    /// PQuantity الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the AuditItemDetail
    /// ItemPriceShort الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the AuditItemDetail
    /// StockCost الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// OutgoingQuantity of the AuditItemDetail
    /// OutgoingQuantity الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? OutgoingQuantity { get; private set; }

    /// <summary>
    /// OutgoingFreeQuantity of the AuditItemDetail
    /// OutgoingFreeQuantity الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? OutgoingFreeQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the AuditItemDetail
    /// WarehouseCode الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AuditItemDetail
    /// CostCenterCode الخاص بـ AuditItemDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ExpireDate of the AuditItemDetail
    /// ExpireDate الخاص بـ AuditItemDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the AuditItemDetail
    /// BatchNumber الخاص بـ AuditItemDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DisAmt of the AuditItemDetail
    /// DisAmt الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatAmount of the AuditItemDetail
    /// VatAmount الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the AuditItemDetail
    /// OtherAmount الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the AuditItemDetail
    /// UseSerialNumber الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// ServiceItem of the AuditItemDetail
    /// ServiceItem الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? ServiceItem { get; private set; }

    /// <summary>
    /// RecordNumber of the AuditItemDetail
    /// RecordNumber الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the AuditItemDetail
    /// DocSequence الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ItemDescription of the AuditItemDetail
    /// ItemDescription الخاص بـ AuditItemDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the AuditItemDetail
    /// Barcode الخاص بـ AuditItemDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// SalesOrderNumber of the AuditItemDetail
    /// SalesOrderNumber الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? SalesOrderNumber { get; private set; }

    /// <summary>
    /// SalesOrderSerial of the AuditItemDetail
    /// SalesOrderSerial الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? SalesOrderSerial { get; private set; }

    /// <summary>
    /// DocTypeRef of the AuditItemDetail
    /// DocTypeRef الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the AuditItemDetail
    /// DocNoRef الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AuditItemDetail
    /// DocSerRef الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// TerminalName of the AuditItemDetail
    /// TerminalName الخاص بـ AuditItemDetail
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditItemDetail
    /// CompanyNumberShort الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditItemDetail
    /// BranchNumber الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditItemDetail
    /// BranchYear الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AuditItemDetail
    /// BranchUser الخاص بـ AuditItemDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AuditItemMaster AuditItemMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

