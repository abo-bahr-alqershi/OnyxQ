using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ConnectGroupItemType Entity
/// </summary>
public class ConnectGroupItemType : Entity<ConnectGroupItemTypeId>
{
    private ConnectGroupItemType() { }

    /// <summary>
    /// The unique identifier for the ConnectGroupItemType
    /// المعرف الفريد لـ ConnectGroupItemType
    /// </summary>
    public ConnectGroupItemTypeId Id { get; private set; }

    /// <summary>
    /// ItemType of the ConnectGroupItemType
    /// ItemType الخاص بـ ConnectGroupItemType
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// GuarantorCode of the ConnectGroupItemType
    /// GuarantorCode الخاص بـ ConnectGroupItemType
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ManagerCode of the ConnectGroupItemType
    /// ManagerCode الخاص بـ ConnectGroupItemType
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the ConnectGroupItemType
    /// SubGroupCode الخاص بـ ConnectGroupItemType
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the ConnectGroupItemType
    /// AssistantNumber الخاص بـ ConnectGroupItemType
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the ConnectGroupItemType
    /// DetailNo الخاص بـ ConnectGroupItemType
    /// </summary>
    public string DetailNo { get; private set; }
}
}
