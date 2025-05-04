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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ActivityGroup to Activity
    /// </summary>
    public IReadOnlyCollection<Activity> Activities { get; private set; }
    #endregion
}
}
