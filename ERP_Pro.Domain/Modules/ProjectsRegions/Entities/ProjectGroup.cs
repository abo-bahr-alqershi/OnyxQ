using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// ProjectGroup Entity
/// </summary>
public class ProjectGroup : Entity<ProjectGroupId>
{

    private ProjectGroup() { }

    public ProjectGroup(ProjectGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the ProjectGroup
    /// المعرف الفريد لـ ProjectGroup
    /// </summary>
    public ProjectGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the ProjectGroup
    /// GroupNumber الخاص بـ ProjectGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupNameArabic of the ProjectGroup
    /// GroupNameArabic الخاص بـ ProjectGroup
    /// </summary>
    public string GroupNameArabic { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the ProjectGroup
    /// GroupNameEnglish الخاص بـ ProjectGroup
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

