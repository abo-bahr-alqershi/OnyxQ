using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptNoteItemSerialNumber Entity
/// </summary>
public class GoodsReceiptNoteItemSerialNumber : Entity<GoodsReceiptNoteItemSerialNumberId>
{
    private GoodsReceiptNoteItemSerialNumber() { }

    /// <summary>
    /// The unique identifier for the GoodsReceiptNoteItemSerialNumber
    /// المعرف الفريد لـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public GoodsReceiptNoteItemSerialNumberId Id { get; private set; }

    /// <summary>
    /// DocType of the GoodsReceiptNoteItemSerialNumber
    /// DocType الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the GoodsReceiptNoteItemSerialNumber
    /// BillDocumentTypeFull الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the GoodsReceiptNoteItemSerialNumber
    /// DocNo الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the GoodsReceiptNoteItemSerialNumber
    /// DocDate الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocSer of the GoodsReceiptNoteItemSerialNumber
    /// DocSer الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ItemCode of the GoodsReceiptNoteItemSerialNumber
    /// ItemCode الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the GoodsReceiptNoteItemSerialNumber
    /// ItemUnit الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the GoodsReceiptNoteItemSerialNumber
    /// PSize الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// SerialNumber of the GoodsReceiptNoteItemSerialNumber
    /// SerialNumber الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public string SerialNumber { get; private set; }

    /// <summary>
    /// DescNo of the GoodsReceiptNoteItemSerialNumber
    /// DescNo الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? DescNo { get; private set; }

    /// <summary>
    /// WarehouseCode of the GoodsReceiptNoteItemSerialNumber
    /// WarehouseCode الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the GoodsReceiptNoteItemSerialNumber
    /// CostCenterCode الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GoodsReceiptNoteItemSerialNumber
    /// ProjectNumber الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GoodsReceiptNoteItemSerialNumber
    /// ActivityNumber الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the GoodsReceiptNoteItemSerialNumber
    /// ExpireDate الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the GoodsReceiptNoteItemSerialNumber
    /// BatchNumber الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeFlag of the GoodsReceiptNoteItemSerialNumber
    /// FreeFlag الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? FreeFlag { get; private set; }

    /// <summary>
    /// BillCost of the GoodsReceiptNoteItemSerialNumber
    /// BillCost الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? BillCost { get; private set; }

    /// <summary>
    /// OutgoingNumber of the GoodsReceiptNoteItemSerialNumber
    /// OutgoingNumber الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the GoodsReceiptNoteItemSerialNumber
    /// OutgoingGroupSerial الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// InOutFlag of the GoodsReceiptNoteItemSerialNumber
    /// InOutFlag الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the GoodsReceiptNoteItemSerialNumber
    /// RecordNumber الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the GoodsReceiptNoteItemSerialNumber
    /// RecordNumberDocument الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GoodsReceiptNoteItemSerialNumber
    /// ExternalPostFlag الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GoodsReceiptNoteItemSerialNumber
    /// CompanyNumberShort الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GoodsReceiptNoteItemSerialNumber
    /// BranchNumber الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GoodsReceiptNoteItemSerialNumber
    /// BranchYear الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GoodsReceiptNoteItemSerialNumber
    /// BranchUser الخاص بـ GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
