using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemOrderImage Entity
/// </summary>
public class ItemOrderImage : Entity<ItemOrderImageId>
{
    private ItemOrderImage() { }

    /// <summary>
    /// The unique identifier for the ItemOrderImage
    /// المعرف الفريد لـ ItemOrderImage
    /// </summary>
    public ItemOrderImageId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemOrderImage
    /// ItemCode الخاص بـ ItemOrderImage
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemOrderImage
    /// BranchNumber الخاص بـ ItemOrderImage
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemOrderImage
    /// ItemUnit الخاص بـ ItemOrderImage
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ImageName of the ItemOrderImage
    /// ImageName الخاص بـ ItemOrderImage
    /// </summary>
    public string ImageName { get; private set; }

    /// <summary>
    /// RecordNumber of the ItemOrderImage
    /// RecordNumber الخاص بـ ItemOrderImage
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemOrder
    /// </summary>
    public ItemOrder ItemOrder { get; private set; }
    #endregion
}
}
