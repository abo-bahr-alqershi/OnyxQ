using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemOrder Entity
/// </summary>
public class ItemOrder : Entity<ItemOrderId>
{

    private ItemOrder() { }

    public ItemOrder(ItemOrderId id, decimal? branchNumber, string itemCode, string itemUnit)
    {
        Id = id;
        BranchNumber = branchNumber;
        ItemCode = itemCode;
        ItemUnit = itemUnit;
    }

    /// <summary>
    /// The unique identifier for the ItemOrder
    /// المعرف الفريد لـ ItemOrder
    /// </summary>
    public ItemOrderId Id { get; private set; }

    /// <summary>
    /// GuarantorCode of the ItemOrder
    /// GuarantorCode الخاص بـ ItemOrder
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemOrder
    /// BranchNumber الخاص بـ ItemOrder
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// ItemCode of the ItemOrder
    /// ItemCode الخاص بـ ItemOrder
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemOrder
    /// ItemUnit الخاص بـ ItemOrder
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemAccountNameArabic of the ItemOrder
    /// ItemAccountNameArabic الخاص بـ ItemOrder
    /// </summary>
    public string ItemAccountNameArabic { get; private set; }

    /// <summary>
    /// ItemNameEnglish of the ItemOrder
    /// ItemNameEnglish الخاص بـ ItemOrder
    /// </summary>
    public string ItemNameEnglish { get; private set; }

    /// <summary>
    /// PSize of the ItemOrder
    /// PSize الخاص بـ ItemOrder
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemDescriptionShort of the ItemOrder
    /// ItemDescriptionShort الخاص بـ ItemOrder
    /// </summary>
    public string ItemDescriptionShort { get; private set; }

    /// <summary>
    /// ItemType of the ItemOrder
    /// ItemType الخاص بـ ItemOrder
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// ItemRoll of the ItemOrder
    /// ItemRoll الخاص بـ ItemOrder
    /// </summary>
    public decimal? ItemRoll { get; private set; }

    /// <summary>
    /// ItemQuantity of the ItemOrder
    /// ItemQuantity الخاص بـ ItemOrder
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// InsertedFlag of the ItemOrder
    /// InsertedFlag الخاص بـ ItemOrder
    /// </summary>
    public decimal? InsertedFlag { get; private set; }

    /// <summary>
    /// VerifyFlag of the ItemOrder
    /// VerifyFlag الخاص بـ ItemOrder
    /// </summary>
    public decimal? VerifyFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ItemOrder
    /// ExternalPostFlag الخاص بـ ItemOrder
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RequestCount of the ItemOrder
    /// RequestCount الخاص بـ ItemOrder
    /// </summary>
    public decimal? RequestCount { get; private set; }

    /// <summary>
    /// ItemDegree of the ItemOrder
    /// ItemDegree الخاص بـ ItemOrder
    /// </summary>
    public decimal? ItemDegree { get; private set; }

    /// <summary>
    /// ItemModel of the ItemOrder
    /// ItemModel الخاص بـ ItemOrder
    /// </summary>
    public string ItemModel { get; private set; }

    /// <summary>
    /// ItemMark of the ItemOrder
    /// ItemMark الخاص بـ ItemOrder
    /// </summary>
    public string ItemMark { get; private set; }

    /// <summary>
    /// ItemImage of the ItemOrder
    /// ItemImage الخاص بـ ItemOrder
    /// </summary>
    public string ItemImage { get; private set; }

    /// <summary>
    /// ManagerCode of the ItemOrder
    /// ManagerCode الخاص بـ ItemOrder
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the ItemOrder
    /// SubGroupCode الخاص بـ ItemOrder
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// ItemFullDescription of the ItemOrder
    /// ItemFullDescription الخاص بـ ItemOrder
    /// </summary>
    public string ItemFullDescription { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ItemOrder
    /// ItemPriceShort الخاص بـ ItemOrder
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// CurCode of the ItemOrder
    /// CurCode الخاص بـ ItemOrder
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CMobile of the ItemOrder
    /// CMobile الخاص بـ ItemOrder
    /// </summary>
    public string CMobile { get; private set; }

    /// <summary>
    /// CAddress of the ItemOrder
    /// CAddress الخاص بـ ItemOrder
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// CCode of the ItemOrder
    /// CCode الخاص بـ ItemOrder
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the ItemOrder
    /// AssistantNumber الخاص بـ ItemOrder
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the ItemOrder
    /// DetailNo الخاص بـ ItemOrder
    /// </summary>
    public string DetailNo { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

