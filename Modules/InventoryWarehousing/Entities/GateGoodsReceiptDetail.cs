using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GateGoodsReceiptDetail Entity
/// </summary>
public class GateGoodsReceiptDetail : Entity<GateGoodsReceiptDetailId>
{
    private GateGoodsReceiptDetail() { }

    /// <summary>
    /// The unique identifier for the GateGoodsReceiptDetail
    /// المعرف الفريد لـ GateGoodsReceiptDetail
    /// </summary>
    public GateGoodsReceiptDetailId Id { get; private set; }

    /// <summary>
    /// DocType of the GateGoodsReceiptDetail
    /// DocType الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocNo of the GateGoodsReceiptDetail
    /// DocNo الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GateGoodsReceiptDetail
    /// DocSer الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the GateGoodsReceiptDetail
    /// BillDocumentTypeFull الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// ItemCode of the GateGoodsReceiptDetail
    /// ItemCode الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the GateGoodsReceiptDetail
    /// ItemQuantity الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the GateGoodsReceiptDetail
    /// ItemUnit الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the GateGoodsReceiptDetail
    /// PSize الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// RecordNumber of the GateGoodsReceiptDetail
    /// RecordNumber الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the GateGoodsReceiptDetail
    /// WarehouseCode الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// PQuantity of the GateGoodsReceiptDetail
    /// PQuantity الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the GateGoodsReceiptDetail
    /// ItemPriceShort الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the GateGoodsReceiptDetail
    /// StockCost الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// GroupItemType of the GateGoodsReceiptDetail
    /// GroupItemType الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? GroupItemType { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GateGoodsReceiptDetail
    /// CompanyNumberShort الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GateGoodsReceiptDetail
    /// BranchNumber الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GateGoodsReceiptDetail
    /// BranchYear الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GateGoodsReceiptDetail
    /// BranchUser الخاص بـ GateGoodsReceiptDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    #endregion
}
}
