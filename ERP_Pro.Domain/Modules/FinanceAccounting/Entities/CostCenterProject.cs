using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل ربط مركز التكلفة بالمشروع ويحتوي على جميع خصائص الربط بين مراكز التكلفة والمشاريع
/// </summary>
public class CostCenterProject : Entity<CostCenterProjectId>
{

    private CostCenterProject() { }

    public CostCenterProject(CostCenterProjectId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لربط مركز التكلفة بالمشروع
    /// </summary>
    public CostCenterProjectId Id { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع المشروع (متعدد إلى واحد)
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع مركز التكلفة (متعدد إلى واحد)
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
