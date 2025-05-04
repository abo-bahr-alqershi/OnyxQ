using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.Activities.Entities
{
/// <summary>
/// ActivityTree Entity
/// </summary>
public class ActivityTree : Entity<ActivityTreeId>
{

    private ActivityTree() { }

    public ActivityTree(ActivityTreeId id, string activityNumber, string activityTree)
    {
        Id = id;
        ActivityNumber = activityNumber;
        ActivityTree = activityTree;
    }

    /// <summary>
    /// The unique identifier for the ActivityTree
    /// المعرف الفريد لـ ActivityTree
    /// </summary>
    public ActivityTreeId Id { get; private set; }

    /// <summary>
    /// ActivityNumber of the ActivityTree
    /// ActivityNumber الخاص بـ ActivityTree
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ActivityCode of the ActivityTree
    /// ActivityCode الخاص بـ ActivityTree
    /// </summary>
    public string ActivityCode { get; private set; }

    /// <summary>
    /// ActivityTree of the ActivityTree
    /// ActivityTree الخاص بـ ActivityTree
    /// </summary>
    public string ActivityTree { get; private set; }

    /// <summary>
    /// ActivityAName of the ActivityTree
    /// ActivityAName الخاص بـ ActivityTree
    /// </summary>
    public string ActivityAName { get; private set; }

    /// <summary>
    /// ActivityEName of the ActivityTree
    /// ActivityEName الخاص بـ ActivityTree
    /// </summary>
    public string ActivityEName { get; private set; }

    /// <summary>
    /// ActivityParent of the ActivityTree
    /// ActivityParent الخاص بـ ActivityTree
    /// </summary>
    public string ActivityParent { get; private set; }

    /// <summary>
    /// ActivityLevel of the ActivityTree
    /// ActivityLevel الخاص بـ ActivityTree
    /// </summary>
    public decimal? ActivityLevel { get; private set; }

    /// <summary>
    /// ActivitySub of the ActivityTree
    /// ActivitySub الخاص بـ ActivityTree
    /// </summary>
    public decimal? ActivitySub { get; private set; }

    /// <summary>
    /// MainSubject of the ActivityTree
    /// MainSubject الخاص بـ ActivityTree
    /// </summary>
    public decimal? MainSubject { get; private set; }

    /// <summary>
    /// GroupNumber of the ActivityTree
    /// GroupNumber الخاص بـ ActivityTree
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the ActivityTree
    /// InactiveFlag الخاص بـ ActivityTree
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the ActivityTree
    /// InactivatedByUserId الخاص بـ ActivityTree
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the ActivityTree
    /// InactiveDate الخاص بـ ActivityTree
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the ActivityTree
    /// InactiveReason الخاص بـ ActivityTree
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
