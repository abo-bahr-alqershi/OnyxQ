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

    /// <summary>
    /// The unique identifier for the PrivilegeProjects
    /// المعرف الفريد لـ PrivilegeProjects
    /// </summary>
    public PrivilegeProjectsId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegeProjects
    /// UserId الخاص بـ PrivilegeProjects
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// ProjectNumber of the PrivilegeProjects
    /// ProjectNumber الخاص بـ PrivilegeProjects
    /// </summary>
    public string ProjectNumber { get; private set; }

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
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
