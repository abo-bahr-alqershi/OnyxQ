using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemBatch Entity
/// </summary>
public class ItemBatch : Entity<ItemBatchId>
{
    private ItemBatch() { }

    /// <summary>
    /// The unique identifier for the ItemBatch
    /// المعرف الفريد لـ ItemBatch
    /// </summary>
    public ItemBatchId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemBatch
    /// ItemCode الخاص بـ ItemBatch
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ColumnNumber1 of the ItemBatch
    /// ColumnNumber1 الخاص بـ ItemBatch
    /// </summary>
    public decimal? ColumnNumber1 { get; private set; }

    /// <summary>
    /// BatchDescriptionNumber1 of the ItemBatch
    /// BatchDescriptionNumber1 الخاص بـ ItemBatch
    /// </summary>
    public string BatchDescriptionNumber1 { get; private set; }

    /// <summary>
    /// ColumnNumber2 of the ItemBatch
    /// ColumnNumber2 الخاص بـ ItemBatch
    /// </summary>
    public decimal? ColumnNumber2 { get; private set; }

    /// <summary>
    /// BatchDescriptionNumber2 of the ItemBatch
    /// BatchDescriptionNumber2 الخاص بـ ItemBatch
    /// </summary>
    public string BatchDescriptionNumber2 { get; private set; }

    /// <summary>
    /// ColumnNumber3 of the ItemBatch
    /// ColumnNumber3 الخاص بـ ItemBatch
    /// </summary>
    public decimal? ColumnNumber3 { get; private set; }

    /// <summary>
    /// BatchDescriptionNumber3 of the ItemBatch
    /// BatchDescriptionNumber3 الخاص بـ ItemBatch
    /// </summary>
    public string BatchDescriptionNumber3 { get; private set; }

    /// <summary>
    /// ColumnNumber4 of the ItemBatch
    /// ColumnNumber4 الخاص بـ ItemBatch
    /// </summary>
    public decimal? ColumnNumber4 { get; private set; }

    /// <summary>
    /// BatchDescriptionNumber4 of the ItemBatch
    /// BatchDescriptionNumber4 الخاص بـ ItemBatch
    /// </summary>
    public string BatchDescriptionNumber4 { get; private set; }

    /// <summary>
    /// ColumnNumber5 of the ItemBatch
    /// ColumnNumber5 الخاص بـ ItemBatch
    /// </summary>
    public decimal? ColumnNumber5 { get; private set; }

    /// <summary>
    /// BatchDescriptionNumber5 of the ItemBatch
    /// BatchDescriptionNumber5 الخاص بـ ItemBatch
    /// </summary>
    public string BatchDescriptionNumber5 { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemBatch
    /// BatchNumber الخاص بـ ItemBatch
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemBatch
    /// CompanyNumberShort الخاص بـ ItemBatch
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemBatch
    /// BranchNumber الخاص بـ ItemBatch
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemBatch
    /// BranchYear الخاص بـ ItemBatch
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemBatch
    /// BranchUser الخاص بـ ItemBatch
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
