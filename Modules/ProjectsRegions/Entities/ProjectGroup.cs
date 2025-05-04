using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// ProjectGroup Entity
/// </summary>
public class ProjectGroup : Entity<ProjectGroupId>
{
    private ProjectGroup() { }

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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ProjectGroup to Project
    /// </summary>
    public IReadOnlyCollection<Project> Projects { get; private set; }
    /// <summary>
    /// One-to-many relationship: ProjectGroup to ProjectAdditionalFields
    /// </summary>
    public IReadOnlyCollection<ProjectAdditionalFields> ProjectAdditionalFieldses { get; private set; }
    #endregion
}
}
