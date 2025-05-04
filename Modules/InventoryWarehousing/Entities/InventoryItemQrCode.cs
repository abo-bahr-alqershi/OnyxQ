using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryItemQrCode Entity
/// </summary>
public class InventoryItemQrCode : Entity<InventoryItemQrCodeId>
{
    private InventoryItemQrCode() { }

    /// <summary>
    /// The unique identifier for the InventoryItemQrCode
    /// المعرف الفريد لـ InventoryItemQrCode
    /// </summary>
    public InventoryItemQrCodeId Id { get; private set; }

    /// <summary>
    /// DocType of the InventoryItemQrCode
    /// DocType الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the InventoryItemQrCode
    /// BillDocumentTypeFull الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the InventoryItemQrCode
    /// DocNo الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the InventoryItemQrCode
    /// DocSer الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the InventoryItemQrCode
    /// DocDate الخاص بـ InventoryItemQrCode
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemCode of the InventoryItemQrCode
    /// ItemCode الخاص بـ InventoryItemQrCode
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the InventoryItemQrCode
    /// ItemUnit الخاص بـ InventoryItemQrCode
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the InventoryItemQrCode
    /// PSize الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// QrCode of the InventoryItemQrCode
    /// QrCode الخاص بـ InventoryItemQrCode
    /// </summary>
    public string QrCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the InventoryItemQrCode
    /// WarehouseCode الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the InventoryItemQrCode
    /// CostCenterCode الخاص بـ InventoryItemQrCode
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the InventoryItemQrCode
    /// ProjectNumber الخاص بـ InventoryItemQrCode
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the InventoryItemQrCode
    /// ActivityNumber الخاص بـ InventoryItemQrCode
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the InventoryItemQrCode
    /// ExpireDate الخاص بـ InventoryItemQrCode
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the InventoryItemQrCode
    /// BatchNumber الخاص بـ InventoryItemQrCode
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeFlag of the InventoryItemQrCode
    /// FreeFlag الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? FreeFlag { get; private set; }

    /// <summary>
    /// OutgoingNumber of the InventoryItemQrCode
    /// OutgoingNumber الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the InventoryItemQrCode
    /// OutgoingGroupSerial الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// InOutFlag of the InventoryItemQrCode
    /// InOutFlag الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryItemQrCode
    /// RecordNumber الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the InventoryItemQrCode
    /// RecordNumberDocument الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InventoryItemQrCode
    /// ExternalPostFlag الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryItemQrCode
    /// CompanyNumberShort الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryItemQrCode
    /// BranchNumber الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryItemQrCode
    /// BranchYear الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryItemQrCode
    /// BranchUser الخاص بـ InventoryItemQrCode
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
