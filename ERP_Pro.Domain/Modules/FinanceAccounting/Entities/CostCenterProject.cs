using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CostCenterProject Entity
/// </summary>
public class CostCenterProject : Entity<CostCenterProjectId>
{

    private CostCenterProject() { }

    public CostCenterProject(CostCenterProjectId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CostCenterProject
    /// المعرف الفريد لـ CostCenterProject
    /// </summary>
    public CostCenterProjectId Id { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
