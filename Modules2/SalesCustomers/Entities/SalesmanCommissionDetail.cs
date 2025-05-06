using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionDetail Entity
/// </summary>
public class SalesmanCommissionDetail : Entity<SalesmanCommissionDetailId>
{
    private readonly List<SalesPlanMaster> _salesPlanMaster = new List<SalesPlanMaster>();
    private readonly List<SalesmanCommissionTypeMaster> _salesmanCommissionTypeMaster = new List<SalesmanCommissionTypeMaster>();
    private readonly List<Salesman> _salesman = new List<Salesman>();

    private SalesmanCommissionDetail() { }

    public SalesmanCommissionDetail(SalesmanCommissionDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionDetail
    /// المعرف الفريد لـ SalesmanCommissionDetail
    /// </summary>
    public SalesmanCommissionDetailId Id { get; private set; }

    /// <summary>
    /// PlanNumber of the SalesmanCommissionDetail
    /// PlanNumber الخاص بـ SalesmanCommissionDetail
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<SalesPlanMaster> SalesPlanMaster => _salesPlanMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<SalesmanCommissionTypeMaster> SalesmanCommissionTypeMaster => _salesmanCommissionTypeMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Salesman> Salesman => _salesman;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

