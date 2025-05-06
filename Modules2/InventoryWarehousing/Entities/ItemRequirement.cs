using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemRequirement Entity
/// </summary>
public class ItemRequirement : Entity<ItemRequirementId>
{

    private ItemRequirement() { }

    public ItemRequirement(ItemRequirementId id, string requestItemNumber, string itemCode)
    {
        Id = id;
        RequestItemNumber = requestItemNumber;
        ItemCode = itemCode;
    }

    /// <summary>
    /// The unique identifier for the ItemRequirement
    /// المعرف الفريد لـ ItemRequirement
    /// </summary>
    public ItemRequirementId Id { get; private set; }

    /// <summary>
    /// RequestItemNumber of the ItemRequirement
    /// RequestItemNumber الخاص بـ ItemRequirement
    /// </summary>
    public string RequestItemNumber { get; private set; }

    /// <summary>
    /// ItemCode of the ItemRequirement
    /// ItemCode الخاص بـ ItemRequirement
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemRequirement
    /// ItemUnit الخاص بـ ItemRequirement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemRequirement
    /// PSize الخاص بـ ItemRequirement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the ItemRequirement
    /// ItemQuantity الخاص بـ ItemRequirement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the ItemRequirement
    /// PQuantity الخاص بـ ItemRequirement
    /// </summary>
    public decimal? PQuantity { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

