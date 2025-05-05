using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemStoreTemp Entity
/// </summary>
public class ItemStoreTemp : Entity<ItemStoreTempId>
{

    private ItemStoreTemp() { }

    public ItemStoreTemp(ItemStoreTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemStoreTemp
    /// المعرف الفريد لـ ItemStoreTemp
    /// </summary>
    public ItemStoreTempId Id { get; private set; }

    /// <summary>
    /// DocNo of the ItemStoreTemp
    /// DocNo الخاص بـ ItemStoreTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the ItemStoreTemp
    /// ItemCode الخاص بـ ItemStoreTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the ItemStoreTemp
    /// ItemNameFull الخاص بـ ItemStoreTemp
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemStoreTemp
    /// ItemUnit الخاص بـ ItemStoreTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemStoreTemp
    /// WarehouseCode الخاص بـ ItemStoreTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemStoreTemp
    /// BatchNumber الخاص بـ ItemStoreTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the ItemStoreTemp
    /// GuarantorCode الخاص بـ ItemStoreTemp
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// GroupClassCode of the ItemStoreTemp
    /// GroupClassCode الخاص بـ ItemStoreTemp
    /// </summary>
    public string GroupClassCode { get; private set; }

    /// <summary>
    /// ManagerCode of the ItemStoreTemp
    /// ManagerCode الخاص بـ ItemStoreTemp
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the ItemStoreTemp
    /// SubGroupCode الخاص بـ ItemStoreTemp
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the ItemStoreTemp
    /// AssistantNumber الخاص بـ ItemStoreTemp
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the ItemStoreTemp
    /// DetailNo الخاص بـ ItemStoreTemp
    /// </summary>
    public string DetailNo { get; private set; }

    /// <summary>
    /// ActivityNumber of the ItemStoreTemp
    /// ActivityNumber الخاص بـ ItemStoreTemp
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// IncomeDate of the ItemStoreTemp
    /// IncomeDate الخاص بـ ItemStoreTemp
    /// </summary>
    public DateTime? IncomeDate { get; private set; }

    /// <summary>
    /// ItemType of the ItemStoreTemp
    /// ItemType الخاص بـ ItemStoreTemp
    /// </summary>
    public decimal? ItemType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

