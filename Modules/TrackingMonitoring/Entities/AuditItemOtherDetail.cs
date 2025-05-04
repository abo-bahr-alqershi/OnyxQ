using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditItemOtherDetail Entity
/// </summary>
public class AuditItemOtherDetail : Entity<AuditItemOtherDetailId>
{
    private AuditItemOtherDetail() { }

    /// <summary>
    /// The unique identifier for the AuditItemOtherDetail
    /// المعرف الفريد لـ AuditItemOtherDetail
    /// </summary>
    public AuditItemOtherDetailId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the AuditItemOtherDetail
    /// AuditNumber الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the AuditItemOtherDetail
    /// AuditType الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// DocType of the AuditItemOtherDetail
    /// DocType الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AuditItemOtherDetail
    /// JournalVoucherTypeFull الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the AuditItemOtherDetail
    /// DocNo الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AuditItemOtherDetail
    /// DocSer الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ItemCode of the AuditItemOtherDetail
    /// ItemCode الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the AuditItemOtherDetail
    /// ItemQuantity الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the AuditItemOtherDetail
    /// FreeQuantity الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the AuditItemOtherDetail
    /// ItemUnit الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AuditItemOtherDetail
    /// PSize الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the AuditItemOtherDetail
    /// PQuantity الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the AuditItemOtherDetail
    /// ItemPriceShort الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the AuditItemOtherDetail
    /// StockCost الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// FlowQuantity of the AuditItemOtherDetail
    /// FlowQuantity الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? FlowQuantity { get; private set; }

    /// <summary>
    /// FlowFreeQuantity of the AuditItemOtherDetail
    /// FlowFreeQuantity الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? FlowFreeQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the AuditItemOtherDetail
    /// WarehouseCode الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AuditItemOtherDetail
    /// CostCenterCode الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AuditItemOtherDetail
    /// ProjectNumber الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AuditItemOtherDetail
    /// ActivityNumber الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the AuditItemOtherDetail
    /// ExpireDate الخاص بـ AuditItemOtherDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the AuditItemOtherDetail
    /// BatchNumber الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DisAmt of the AuditItemOtherDetail
    /// DisAmt الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatAmount of the AuditItemOtherDetail
    /// VatAmount الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the AuditItemOtherDetail
    /// OtherAmount الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the AuditItemOtherDetail
    /// UseSerialNumber الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// ServiceItem of the AuditItemOtherDetail
    /// ServiceItem الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? ServiceItem { get; private set; }

    /// <summary>
    /// RecordNumber of the AuditItemOtherDetail
    /// RecordNumber الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the AuditItemOtherDetail
    /// DocSequence الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ItemDescription of the AuditItemOtherDetail
    /// ItemDescription الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the AuditItemOtherDetail
    /// Barcode الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// FQuantity of the AuditItemOtherDetail
    /// FQuantity الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? FQuantity { get; private set; }

    /// <summary>
    /// TQuantity of the AuditItemOtherDetail
    /// TQuantity الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? TQuantity { get; private set; }

    /// <summary>
    /// FAmount of the AuditItemOtherDetail
    /// FAmount الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? FAmount { get; private set; }

    /// <summary>
    /// TAmount of the AuditItemOtherDetail
    /// TAmount الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? TAmount { get; private set; }

    /// <summary>
    /// DiscType of the AuditItemOtherDetail
    /// DiscType الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DiscType { get; private set; }

    /// <summary>
    /// QuotationItemCode of the AuditItemOtherDetail
    /// QuotationItemCode الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string QuotationItemCode { get; private set; }

    /// <summary>
    /// DocTypeRef of the AuditItemOtherDetail
    /// DocTypeRef الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the AuditItemOtherDetail
    /// DocJvTypeRef الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the AuditItemOtherDetail
    /// DocNoRef الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AuditItemOtherDetail
    /// DocSerRef الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the AuditItemOtherDetail
    /// DocSequenceRef الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// TerminalName of the AuditItemOtherDetail
    /// TerminalName الخاص بـ AuditItemOtherDetail
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditItemOtherDetail
    /// CompanyNumberShort الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditItemOtherDetail
    /// BranchNumber الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditItemOtherDetail
    /// BranchYear الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AuditItemOtherDetail
    /// BranchUser الخاص بـ AuditItemOtherDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AuditItemOtherMaster
    /// </summary>
    public AuditItemOtherMaster AuditItemOtherMaster { get; private set; }
    #endregion
}
}
