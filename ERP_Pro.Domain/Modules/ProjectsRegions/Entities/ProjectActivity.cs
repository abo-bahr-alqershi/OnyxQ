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

    public ProjectActivity(ProjectActivityId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ProjectActivity
    /// المعرف الفريد لـ ProjectActivity
    /// </summary>
    public ProjectActivityId Id { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
