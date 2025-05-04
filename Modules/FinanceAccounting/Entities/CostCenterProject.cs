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

    /// <summary>
    /// The unique identifier for the CostCenterProject
    /// المعرف الفريد لـ CostCenterProject
    /// </summary>
    public CostCenterProjectId Id { get; private set; }

    /// <summary>
    /// CostCenterCode of the CostCenterProject
    /// CostCenterCode الخاص بـ CostCenterProject
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the CostCenterProject
    /// ProjectNumber الخاص بـ CostCenterProject
    /// </summary>
    public string ProjectNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion
}
}
