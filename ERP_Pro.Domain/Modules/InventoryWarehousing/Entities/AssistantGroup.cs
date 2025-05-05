using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// AssistantGroup Entity
/// </summary>
public class AssistantGroup : Entity<AssistantGroupId>
{

    private AssistantGroup() { }

    public AssistantGroup(AssistantGroupId id, string assistantNumber)
    {
        Id = id;
        AssistantNumber = assistantNumber;
    }

    /// <summary>
    /// The unique identifier for the AssistantGroup
    /// المعرف الفريد لـ AssistantGroup
    /// </summary>
    public AssistantGroupId Id { get; private set; }

    /// <summary>
    /// GuarantorCode of the AssistantGroup
    /// GuarantorCode الخاص بـ AssistantGroup
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ManagerCode of the AssistantGroup
    /// ManagerCode الخاص بـ AssistantGroup
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the AssistantGroup
    /// SubGroupCode الخاص بـ AssistantGroup
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the AssistantGroup
    /// AssistantNumber الخاص بـ AssistantGroup
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// AssistantNameArabic of the AssistantGroup
    /// AssistantNameArabic الخاص بـ AssistantGroup
    /// </summary>
    public string AssistantNameArabic { get; private set; }

    /// <summary>
    /// AssistantNameEnglish of the AssistantGroup
    /// AssistantNameEnglish الخاص بـ AssistantGroup
    /// </summary>
    public string AssistantNameEnglish { get; private set; }

    /// <summary>
    /// SynchronizeToWebFlag of the AssistantGroup
    /// SynchronizeToWebFlag الخاص بـ AssistantGroup
    /// </summary>
    public decimal? SynchronizeToWebFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

