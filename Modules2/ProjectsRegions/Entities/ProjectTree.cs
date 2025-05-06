using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// ProjectTree Entity
/// </summary>
public class ProjectTree : Entity<ProjectTreeId>
{

    private ProjectTree() { }

    public ProjectTree(ProjectTreeId id, string projectNumber, string projectTree)
    {
        Id = id;
        ProjectNumber = projectNumber;
        ProjectTree = projectTree;
    }

    /// <summary>
    /// The unique identifier for the ProjectTree
    /// المعرف الفريد لـ ProjectTree
    /// </summary>
    public ProjectTreeId Id { get; private set; }

    /// <summary>
    /// ProjectNumber of the ProjectTree
    /// ProjectNumber الخاص بـ ProjectTree
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ProjectCode of the ProjectTree
    /// ProjectCode الخاص بـ ProjectTree
    /// </summary>
    public string ProjectCode { get; private set; }

    /// <summary>
    /// ProjectTree of the ProjectTree
    /// ProjectTree الخاص بـ ProjectTree
    /// </summary>
    public string ProjectTree { get; private set; }

    /// <summary>
    /// ProjectNameArabic of the ProjectTree
    /// ProjectNameArabic الخاص بـ ProjectTree
    /// </summary>
    public string ProjectNameArabic { get; private set; }

    /// <summary>
    /// ProjectNameEnglish of the ProjectTree
    /// ProjectNameEnglish الخاص بـ ProjectTree
    /// </summary>
    public string ProjectNameEnglish { get; private set; }

    /// <summary>
    /// ProjectParent of the ProjectTree
    /// ProjectParent الخاص بـ ProjectTree
    /// </summary>
    public string ProjectParent { get; private set; }

    /// <summary>
    /// ProjectLevel of the ProjectTree
    /// ProjectLevel الخاص بـ ProjectTree
    /// </summary>
    public decimal? ProjectLevel { get; private set; }

    /// <summary>
    /// ProjectSub of the ProjectTree
    /// ProjectSub الخاص بـ ProjectTree
    /// </summary>
    public decimal? ProjectSub { get; private set; }

    /// <summary>
    /// MainSubject of the ProjectTree
    /// MainSubject الخاص بـ ProjectTree
    /// </summary>
    public decimal? MainSubject { get; private set; }

    /// <summary>
    /// GroupNumber of the ProjectTree
    /// GroupNumber الخاص بـ ProjectTree
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the ProjectTree
    /// InactiveFlag الخاص بـ ProjectTree
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the ProjectTree
    /// InactivatedByUserId الخاص بـ ProjectTree
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the ProjectTree
    /// InactiveDate الخاص بـ ProjectTree
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the ProjectTree
    /// InactiveReason الخاص بـ ProjectTree
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

