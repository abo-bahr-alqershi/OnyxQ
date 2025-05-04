using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// DetailGroup Entity
/// </summary>
public class DetailGroup : Entity<DetailGroupId>
{

    private DetailGroup() { }

    public DetailGroup(DetailGroupId id, string detailNo)
    {
        Id = id;
        DetailNo = detailNo;
    }

    /// <summary>
    /// The unique identifier for the DetailGroup
    /// المعرف الفريد لـ DetailGroup
    /// </summary>
    public DetailGroupId Id { get; private set; }

    /// <summary>
    /// GuarantorCode of the DetailGroup
    /// GuarantorCode الخاص بـ DetailGroup
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ManagerCode of the DetailGroup
    /// ManagerCode الخاص بـ DetailGroup
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the DetailGroup
    /// SubGroupCode الخاص بـ DetailGroup
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the DetailGroup
    /// AssistantNumber الخاص بـ DetailGroup
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the DetailGroup
    /// DetailNo الخاص بـ DetailGroup
    /// </summary>
    public string DetailNo { get; private set; }

    /// <summary>
    /// DetailAName of the DetailGroup
    /// DetailAName الخاص بـ DetailGroup
    /// </summary>
    public string DetailAName { get; private set; }

    /// <summary>
    /// DetailEName of the DetailGroup
    /// DetailEName الخاص بـ DetailGroup
    /// </summary>
    public string DetailEName { get; private set; }

    /// <summary>
    /// SynchronizeToWebFlag of the DetailGroup
    /// SynchronizeToWebFlag الخاص بـ DetailGroup
    /// </summary>
    public decimal? SynchronizeToWebFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
