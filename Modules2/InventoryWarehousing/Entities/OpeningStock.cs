using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// OpeningStock Entity
/// </summary>
public class OpeningStock : Entity<OpeningStockId>
{

    private OpeningStock() { }

    public OpeningStock(OpeningStockId id, DateTime? expireDate, string batchNumber, decimal? docSequence)
    {
        Id = id;
        ExpireDate = expireDate;
        BatchNumber = batchNumber;
        DocSequence = docSequence;
    }

    /// <summary>
    /// The unique identifier for the OpeningStock
    /// المعرف الفريد لـ OpeningStock
    /// </summary>
    public OpeningStockId Id { get; private set; }

    /// <summary>
    /// ItemQuantity of the OpeningStock
    /// ItemQuantity الخاص بـ OpeningStock
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

