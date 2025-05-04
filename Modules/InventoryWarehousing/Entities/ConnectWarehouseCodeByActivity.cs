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
    private ConnectWarehouseCodeByActivity() { }

    /// <summary>
    /// The unique identifier for the ConnectWarehouseCodeByActivity
    /// المعرف الفريد لـ ConnectWarehouseCodeByActivity
    /// </summary>
    public ConnectWarehouseCodeByActivityId Id { get; private set; }

    /// <summary>
    /// WarehouseCode of the ConnectWarehouseCodeByActivity
    /// WarehouseCode الخاص بـ ConnectWarehouseCodeByActivity
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the ConnectWarehouseCodeByActivity
    /// ActivityNumber الخاص بـ ConnectWarehouseCodeByActivity
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the ConnectWarehouseCodeByActivity
    /// CostCenterCode الخاص بـ ConnectWarehouseCodeByActivity
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ConnectWarehouseCodeByActivity
    /// ProjectNumber الخاص بـ ConnectWarehouseCodeByActivity
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ConnectWarehouseCodeByActivity
    /// ActivityNumber الخاص بـ ConnectWarehouseCodeByActivity
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
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
