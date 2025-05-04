using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ConnectWarehouseCodeByActivity Entity
/// </summary>
public class ConnectWarehouseCodeByActivity : Entity<ConnectWarehouseCodeByActivityId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private ConnectWarehouseCodeByActivity() { }

    public ConnectWarehouseCodeByActivity(ConnectWarehouseCodeByActivityId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ConnectWarehouseCodeByActivity
    /// المعرف الفريد لـ ConnectWarehouseCodeByActivity
    /// </summary>
    public ConnectWarehouseCodeByActivityId Id { get; private set; }

    /// <summary>
    /// ActivityNumber of the ConnectWarehouseCodeByActivity
    /// ActivityNumber الخاص بـ ConnectWarehouseCodeByActivity
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
