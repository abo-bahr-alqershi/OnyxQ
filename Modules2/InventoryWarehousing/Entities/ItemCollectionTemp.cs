using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemCollectionTemp Entity
/// </summary>
public class ItemCollectionTemp : Entity<ItemCollectionTempId>
{

    private ItemCollectionTemp() { }

    public ItemCollectionTemp(ItemCollectionTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemCollectionTemp
    /// المعرف الفريد لـ ItemCollectionTemp
    /// </summary>
    public ItemCollectionTempId Id { get; private set; }

    /// <summary>
    /// DocNo of the ItemCollectionTemp
    /// DocNo الخاص بـ ItemCollectionTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the ItemCollectionTemp
    /// ItemCode الخاص بـ ItemCollectionTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the ItemCollectionTemp
    /// ItemNameFull الخاص بـ ItemCollectionTemp
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemCollectionTemp
    /// ItemUnit الخاص بـ ItemCollectionTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemCollectionTemp
    /// WarehouseCode الخاص بـ ItemCollectionTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemCollectionTemp
    /// BatchNumber الخاص بـ ItemCollectionTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the ItemCollectionTemp
    /// GuarantorCode الخاص بـ ItemCollectionTemp
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// GroupClassCode of the ItemCollectionTemp
    /// GroupClassCode الخاص بـ ItemCollectionTemp
    /// </summary>
    public string GroupClassCode { get; private set; }

    /// <summary>
    /// ManagerCode of the ItemCollectionTemp
    /// ManagerCode الخاص بـ ItemCollectionTemp
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the ItemCollectionTemp
    /// SubGroupCode الخاص بـ ItemCollectionTemp
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the ItemCollectionTemp
    /// AssistantNumber الخاص بـ ItemCollectionTemp
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the ItemCollectionTemp
    /// DetailNo الخاص بـ ItemCollectionTemp
    /// </summary>
    public string DetailNo { get; private set; }

    /// <summary>
    /// ActivityNumber of the ItemCollectionTemp
    /// ActivityNumber الخاص بـ ItemCollectionTemp
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// IncomeDate of the ItemCollectionTemp
    /// IncomeDate الخاص بـ ItemCollectionTemp
    /// </summary>
    public DateTime? IncomeDate { get; private set; }

    /// <summary>
    /// ItemType of the ItemCollectionTemp
    /// ItemType الخاص بـ ItemCollectionTemp
    /// </summary>
    public decimal? ItemType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

