using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptNoteTypes Entity
/// </summary>
public class GoodsReceiptNoteTypes : Entity<GoodsReceiptNoteTypesId>
{

    private GoodsReceiptNoteTypes() { }

    public GoodsReceiptNoteTypes(GoodsReceiptNoteTypesId id, decimal? goodsReceiptType)
    {
        Id = id;
        GoodsReceiptType = goodsReceiptType;
    }

    /// <summary>
    /// The unique identifier for the GoodsReceiptNoteTypes
    /// المعرف الفريد لـ GoodsReceiptNoteTypes
    /// </summary>
    public GoodsReceiptNoteTypesId Id { get; private set; }

    /// <summary>
    /// GoodsReceiptType of the GoodsReceiptNoteTypes
    /// GoodsReceiptType الخاص بـ GoodsReceiptNoteTypes
    /// </summary>
    public decimal? GoodsReceiptType { get; private set; }

    /// <summary>
    /// GoodsReceiptNameArabic of the GoodsReceiptNoteTypes
    /// GoodsReceiptNameArabic الخاص بـ GoodsReceiptNoteTypes
    /// </summary>
    public string GoodsReceiptNameArabic { get; private set; }

    /// <summary>
    /// GoodsReceiptNameEnglish of the GoodsReceiptNoteTypes
    /// GoodsReceiptNameEnglish الخاص بـ GoodsReceiptNoteTypes
    /// </summary>
    public string GoodsReceiptNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

