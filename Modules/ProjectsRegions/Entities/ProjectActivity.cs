using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// ProjectActivity Entity
/// </summary>
public class ProjectActivity : Entity<ProjectActivityId>
{
    private ProjectActivity() { }

    /// <summary>
    /// The unique identifier for the ProjectActivity
    /// المعرف الفريد لـ ProjectActivity
    /// </summary>
    public ProjectActivityId Id { get; private set; }

    /// <summary>
    /// ProjectNumber of the ProjectActivity
    /// ProjectNumber الخاص بـ ProjectActivity
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ProjectActivity
    /// ActivityNumber الخاص بـ ProjectActivity
    /// </summary>
    public string ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    #endregion
}
}
