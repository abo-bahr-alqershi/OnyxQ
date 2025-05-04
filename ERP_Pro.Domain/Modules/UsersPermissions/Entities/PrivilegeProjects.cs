using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeProjects Entity
/// </summary>
public class PrivilegeProjects : Entity<PrivilegeProjectsId>
{

    private PrivilegeProjects() { }

    public PrivilegeProjects(PrivilegeProjectsId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PrivilegeProjects
    /// المعرف الفريد لـ PrivilegeProjects
    /// </summary>
    public PrivilegeProjectsId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeProjects
    /// AdditionalFlag الخاص بـ PrivilegeProjects
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeProjects
    /// ViewFlag الخاص بـ PrivilegeProjects
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
