using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PrintBarcodeTemp Entity
/// </summary>
public class PrintBarcodeTemp : Entity<PrintBarcodeTempId>
{

    private PrintBarcodeTemp() { }

    public PrintBarcodeTemp(PrintBarcodeTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PrintBarcodeTemp
    /// المعرف الفريد لـ PrintBarcodeTemp
    /// </summary>
    public PrintBarcodeTempId Id { get; private set; }

    /// <summary>
    /// ItemCode of the PrintBarcodeTemp
    /// ItemCode الخاص بـ PrintBarcodeTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the PrintBarcodeTemp
    /// ItemNameFull الخاص بـ PrintBarcodeTemp
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemUnit of the PrintBarcodeTemp
    /// ItemUnit الخاص بـ PrintBarcodeTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemDescriptionShort of the PrintBarcodeTemp
    /// ItemDescriptionShort الخاص بـ PrintBarcodeTemp
    /// </summary>
    public string ItemDescriptionShort { get; private set; }

    /// <summary>
    /// ItemType of the PrintBarcodeTemp
    /// ItemType الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// ItemSizeAlt of the PrintBarcodeTemp
    /// ItemSizeAlt الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? ItemSizeAlt { get; private set; }

    /// <summary>
    /// Barcode of the PrintBarcodeTemp
    /// Barcode الخاص بـ PrintBarcodeTemp
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ExpireDate of the PrintBarcodeTemp
    /// ExpireDate الخاص بـ PrintBarcodeTemp
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the PrintBarcodeTemp
    /// BatchNumber الخاص بـ PrintBarcodeTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the PrintBarcodeTemp
    /// ItemQuantity الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the PrintBarcodeTemp
    /// ItemPriceShort الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// TerminalName of the PrintBarcodeTemp
    /// TerminalName الخاص بـ PrintBarcodeTemp
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// ItemDiscountAmount of the PrintBarcodeTemp
    /// ItemDiscountAmount الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? ItemDiscountAmount { get; private set; }

    /// <summary>
    /// VatAmount of the PrintBarcodeTemp
    /// VatAmount الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercentShort of the PrintBarcodeTemp
    /// VatPercentShort الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? VatPercentShort { get; private set; }

    /// <summary>
    /// RecordNumber of the PrintBarcodeTemp
    /// RecordNumber الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocDate of the PrintBarcodeTemp
    /// DocDate الخاص بـ PrintBarcodeTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemPricePrevious of the PrintBarcodeTemp
    /// ItemPricePrevious الخاص بـ PrintBarcodeTemp
    /// </summary>
    public decimal? ItemPricePrevious { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

