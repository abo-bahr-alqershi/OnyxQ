using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptIncomingDetail Entity
/// </summary>
public class GoodsReceiptIncomingDetail : Entity<GoodsReceiptIncomingDetailId>
{
    private GoodsReceiptIncomingDetail() { }

    /// <summary>
    /// The unique identifier for the GoodsReceiptIncomingDetail
    /// المعرف الفريد لـ GoodsReceiptIncomingDetail
    /// </summary>
    public GoodsReceiptIncomingDetailId Id { get; private set; }

    /// <summary>
    /// IncomeType of the GoodsReceiptIncomingDetail
    /// IncomeType الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? IncomeType { get; private set; }

    /// <summary>
    /// IncomeNumber of the GoodsReceiptIncomingDetail
    /// IncomeNumber الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? IncomeNumber { get; private set; }

    /// <summary>
    /// IncomeSerialAlt of the GoodsReceiptIncomingDetail
    /// IncomeSerialAlt الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? IncomeSerialAlt { get; private set; }

    /// <summary>
    /// ItemCode of the GoodsReceiptIncomingDetail
    /// ItemCode الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the GoodsReceiptIncomingDetail
    /// ItemUnit الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemQuantity of the GoodsReceiptIncomingDetail
    /// ItemQuantity الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the GoodsReceiptIncomingDetail
    /// PSize الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the GoodsReceiptIncomingDetail
    /// PQuantity الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the GoodsReceiptIncomingDetail
    /// WarehouseCode الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the GoodsReceiptIncomingDetail
    /// CostCenterCode الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GoodsReceiptIncomingDetail
    /// ProjectNumber الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GoodsReceiptIncomingDetail
    /// ActivityNumber الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the GoodsReceiptIncomingDetail
    /// ExpireDate الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the GoodsReceiptIncomingDetail
    /// BatchNumber الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the GoodsReceiptIncomingDetail
    /// ItemDescription الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// RecordNumber of the GoodsReceiptIncomingDetail
    /// RecordNumber الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the GoodsReceiptIncomingDetail
    /// UseAttachment الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the GoodsReceiptIncomingDetail
    /// ReceiveAttachment الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemLength of the GoodsReceiptIncomingDetail
    /// ItemLength الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the GoodsReceiptIncomingDetail
    /// ItemWidth الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the GoodsReceiptIncomingDetail
    /// ItemHeightShort الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the GoodsReceiptIncomingDetail
    /// ItemNumberShort الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the GoodsReceiptIncomingDetail
    /// WeightedQuantity الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the GoodsReceiptIncomingDetail
    /// WeightedUnit الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// Barcode of the GoodsReceiptIncomingDetail
    /// Barcode الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the GoodsReceiptIncomingDetail
    /// ArgumentNumber الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GoodsReceiptIncomingDetail
    /// ExternalPostFlag الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GoodsReceiptIncomingDetail
    /// CompanyNumberShort الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GoodsReceiptIncomingDetail
    /// BranchNumber الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GoodsReceiptIncomingDetail
    /// BranchYear الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GoodsReceiptIncomingDetail
    /// BranchUser الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocSequence of the GoodsReceiptIncomingDetail
    /// DocSequence الخاص بـ GoodsReceiptIncomingDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to GoodsReceiptIncomingMaster
    /// </summary>
    public GoodsReceiptIncomingMaster GoodsReceiptIncomingMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
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
