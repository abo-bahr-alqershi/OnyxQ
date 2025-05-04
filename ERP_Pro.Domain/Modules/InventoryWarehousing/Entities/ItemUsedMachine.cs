using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemUsedMachine Entity
/// </summary>
public class ItemUsedMachine : Entity<ItemUsedMachineId>
{

    private ItemUsedMachine() { }

    public ItemUsedMachine(ItemUsedMachineId id, string itemCode)
    {
        Id = id;
        ItemCode = itemCode;
    }

    /// <summary>
    /// The unique identifier for the ItemUsedMachine
    /// المعرف الفريد لـ ItemUsedMachine
    /// </summary>
    public ItemUsedMachineId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemUsedMachine
    /// ItemCode الخاص بـ ItemUsedMachine
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the ItemUsedMachine
    /// ItemNameFull الخاص بـ ItemUsedMachine
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemNameEnglish of the ItemUsedMachine
    /// ItemNameEnglish الخاص بـ ItemUsedMachine
    /// </summary>
    public string ItemNameEnglish { get; private set; }

    /// <summary>
    /// GuarantorCode of the ItemUsedMachine
    /// GuarantorCode الخاص بـ ItemUsedMachine
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ManagerCode of the ItemUsedMachine
    /// ManagerCode الخاص بـ ItemUsedMachine
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the ItemUsedMachine
    /// SubGroupCode الخاص بـ ItemUsedMachine
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// ItemDescriptionShort of the ItemUsedMachine
    /// ItemDescriptionShort الخاص بـ ItemUsedMachine
    /// </summary>
    public string ItemDescriptionShort { get; private set; }

    /// <summary>
    /// ItemFullDescription of the ItemUsedMachine
    /// ItemFullDescription الخاص بـ ItemUsedMachine
    /// </summary>
    public string ItemFullDescription { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ItemUsedMachine
    /// ItemPriceShort الخاص بـ ItemUsedMachine
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// Status of the ItemUsedMachine
    /// Status الخاص بـ ItemUsedMachine
    /// </summary>
    public decimal? Status { get; private set; }

    /// <summary>
    /// CMobile of the ItemUsedMachine
    /// CMobile الخاص بـ ItemUsedMachine
    /// </summary>
    public string CMobile { get; private set; }

    /// <summary>
    /// CAddress of the ItemUsedMachine
    /// CAddress الخاص بـ ItemUsedMachine
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// CCode of the ItemUsedMachine
    /// CCode الخاص بـ ItemUsedMachine
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CurCode of the ItemUsedMachine
    /// CurCode الخاص بـ ItemUsedMachine
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the ItemUsedMachine
    /// AssistantNumber الخاص بـ ItemUsedMachine
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the ItemUsedMachine
    /// DetailNo الخاص بـ ItemUsedMachine
    /// </summary>
    public string DetailNo { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
