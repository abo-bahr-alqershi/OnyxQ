using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// OpeningStock Entity
/// </summary>
public class OpeningStock : Entity<OpeningStockId>
{
    private OpeningStock() { }

    /// <summary>
    /// The unique identifier for the OpeningStock
    /// المعرف الفريد لـ OpeningStock
    /// </summary>
    public OpeningStockId Id { get; private set; }

    /// <summary>
    /// ItemCode of the OpeningStock
    /// ItemCode الخاص بـ OpeningStock
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the OpeningStock
    /// ItemQuantity الخاص بـ OpeningStock
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the OpeningStock
    /// ItemUnit الخاص بـ OpeningStock
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the OpeningStock
    /// PSize الخاص بـ OpeningStock
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the OpeningStock
    /// PQuantity الخاص بـ OpeningStock
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// Barcode of the OpeningStock
    /// Barcode الخاص بـ OpeningStock
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// WarehouseCode of the OpeningStock
    /// WarehouseCode الخاص بـ OpeningStock
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the OpeningStock
    /// WarehouseGroupCode الخاص بـ OpeningStock
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// StockCost of the OpeningStock
    /// StockCost الخاص بـ OpeningStock
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// ExpireDate of the OpeningStock
    /// ExpireDate الخاص بـ OpeningStock
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the OpeningStock
    /// BatchNumber الخاص بـ OpeningStock
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// UseSerialNumber of the OpeningStock
    /// UseSerialNumber الخاص بـ OpeningStock
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// VendorCode of the OpeningStock
    /// VendorCode الخاص بـ OpeningStock
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// RecordNumber of the OpeningStock
    /// RecordNumber الخاص بـ OpeningStock
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the OpeningStock
    /// DocSequence الخاص بـ OpeningStock
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// UseAttachment of the OpeningStock
    /// UseAttachment الخاص بـ OpeningStock
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the OpeningStock
    /// ReceiveAttachment الخاص بـ OpeningStock
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemLength of the OpeningStock
    /// ItemLength الخاص بـ OpeningStock
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the OpeningStock
    /// ItemWidth الخاص بـ OpeningStock
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the OpeningStock
    /// ItemHeightShort الخاص بـ OpeningStock
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the OpeningStock
    /// ItemNumberShort الخاص بـ OpeningStock
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the OpeningStock
    /// WeightedQuantity الخاص بـ OpeningStock
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the OpeningStock
    /// WeightedUnit الخاص بـ OpeningStock
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the OpeningStock
    /// ArgumentNumber الخاص بـ OpeningStock
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OpeningStock
    /// CompanyNumberShort الخاص بـ OpeningStock
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OpeningStock
    /// BranchNumber الخاص بـ OpeningStock
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OpeningStock
    /// BranchYear الخاص بـ OpeningStock
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OpeningStock
    /// BranchUser الخاص بـ OpeningStock
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// MovePaymentYearFlag of the OpeningStock
    /// MovePaymentYearFlag الخاص بـ OpeningStock
    /// </summary>
    public decimal? MovePaymentYearFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
