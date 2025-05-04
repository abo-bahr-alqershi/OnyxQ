using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemNotStoreTemp Entity
/// </summary>
public class ItemNotStoreTemp : Entity<ItemNotStoreTempId>
{

    private ItemNotStoreTemp() { }

    public ItemNotStoreTemp(ItemNotStoreTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemNotStoreTemp
    /// المعرف الفريد لـ ItemNotStoreTemp
    /// </summary>
    public ItemNotStoreTempId Id { get; private set; }

    /// <summary>
    /// DocNo of the ItemNotStoreTemp
    /// DocNo الخاص بـ ItemNotStoreTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the ItemNotStoreTemp
    /// ItemCode الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the ItemNotStoreTemp
    /// ItemNameFull الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemNotStoreTemp
    /// ItemUnit الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemNotStoreTemp
    /// WarehouseCode الخاص بـ ItemNotStoreTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemNotStoreTemp
    /// BatchNumber الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the ItemNotStoreTemp
    /// GuarantorCode الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// GroupClassCode of the ItemNotStoreTemp
    /// GroupClassCode الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string GroupClassCode { get; private set; }

    /// <summary>
    /// ManagerCode of the ItemNotStoreTemp
    /// ManagerCode الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the ItemNotStoreTemp
    /// SubGroupCode الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the ItemNotStoreTemp
    /// AssistantNumber الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the ItemNotStoreTemp
    /// DetailNo الخاص بـ ItemNotStoreTemp
    /// </summary>
    public string DetailNo { get; private set; }

    /// <summary>
    /// ActivityNumber of the ItemNotStoreTemp
    /// ActivityNumber الخاص بـ ItemNotStoreTemp
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// IncomeDate of the ItemNotStoreTemp
    /// IncomeDate الخاص بـ ItemNotStoreTemp
    /// </summary>
    public DateTime? IncomeDate { get; private set; }

    /// <summary>
    /// ItemType of the ItemNotStoreTemp
    /// ItemType الخاص بـ ItemNotStoreTemp
    /// </summary>
    public decimal? ItemType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
