using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.Activities.Entities
{
/// <summary>
/// ActivityGroup Entity
/// </summary>
public class ActivityGroup : Entity<ActivityGroupId>
{

    private ActivityGroup() { }

    public ActivityGroup(ActivityGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the ActivityGroup
    /// المعرف الفريد لـ ActivityGroup
    /// </summary>
    public ActivityGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the ActivityGroup
    /// GroupNumber الخاص بـ ActivityGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupNameArabic of the ActivityGroup
    /// GroupNameArabic الخاص بـ ActivityGroup
    /// </summary>
    public string GroupNameArabic { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the ActivityGroup
    /// GroupNameEnglish الخاص بـ ActivityGroup
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
