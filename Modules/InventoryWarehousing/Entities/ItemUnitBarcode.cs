using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemUnitBarcode Entity
/// </summary>
public class ItemUnitBarcode : Entity<ItemUnitBarcodeId>
{
    private ItemUnitBarcode() { }

    /// <summary>
    /// The unique identifier for the ItemUnitBarcode
    /// المعرف الفريد لـ ItemUnitBarcode
    /// </summary>
    public ItemUnitBarcodeId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemUnitBarcode
    /// ItemCode الخاص بـ ItemUnitBarcode
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemUnitBarcode
    /// ItemUnit الخاص بـ ItemUnitBarcode
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemUnitBarcode
    /// PSize الخاص بـ ItemUnitBarcode
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// Barcode of the ItemUnitBarcode
    /// Barcode الخاص بـ ItemUnitBarcode
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemUnitBarcode
    /// BatchNumber الخاص بـ ItemUnitBarcode
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the ItemUnitBarcode
    /// ExpireDate الخاص بـ ItemUnitBarcode
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// NoSaleFlag of the ItemUnitBarcode
    /// NoSaleFlag الخاص بـ ItemUnitBarcode
    /// </summary>
    public decimal? NoSaleFlag { get; private set; }

    /// <summary>
    /// NoPrintFlag of the ItemUnitBarcode
    /// NoPrintFlag الخاص بـ ItemUnitBarcode
    /// </summary>
    public decimal? NoPrintFlag { get; private set; }

    /// <summary>
    /// FlexNumber of the ItemUnitBarcode
    /// FlexNumber الخاص بـ ItemUnitBarcode
    /// </summary>
    public decimal? FlexNumber { get; private set; }

    /// <summary>
    /// DealWithPrchsFlg of the ItemUnitBarcode
    /// DealWithPrchsFlg الخاص بـ ItemUnitBarcode
    /// </summary>
    public decimal? DealWithPrchsFlg { get; private set; }

    /// <summary>
    /// BarcodeDescriptionLast of the ItemUnitBarcode
    /// BarcodeDescriptionLast الخاص بـ ItemUnitBarcode
    /// </summary>
    public string BarcodeDescriptionLast { get; private set; }

    /// <summary>
    /// BarcodeDescriptionFull of the ItemUnitBarcode
    /// BarcodeDescriptionFull الخاص بـ ItemUnitBarcode
    /// </summary>
    public string BarcodeDescriptionFull { get; private set; }

    /// <summary>
    /// MainBarcode of the ItemUnitBarcode
    /// MainBarcode الخاص بـ ItemUnitBarcode
    /// </summary>
    public decimal? MainBarcode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    #endregion
}
}
