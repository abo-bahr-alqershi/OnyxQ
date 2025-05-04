using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// DefaultDataOnline Entity
/// </summary>
public class DefaultDataOnline : Entity<DefaultDataOnlineId>
{
    private DefaultDataOnline() { }

    /// <summary>
    /// The unique identifier for the DefaultDataOnline
    /// المعرف الفريد لـ DefaultDataOnline
    /// </summary>
    public DefaultDataOnlineId Id { get; private set; }

    /// <summary>
    /// DfltNo of the DefaultDataOnline
    /// DfltNo الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? DfltNo { get; private set; }

    /// <summary>
    /// CostCenterCode of the DefaultDataOnline
    /// CostCenterCode الخاص بـ DefaultDataOnline
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the DefaultDataOnline
    /// ProjectNumber الخاص بـ DefaultDataOnline
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the DefaultDataOnline
    /// ActivityNumber الخاص بـ DefaultDataOnline
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the DefaultDataOnline
    /// WarehouseCode الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// SalesOrderType of the DefaultDataOnline
    /// SalesOrderType الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? SalesOrderType { get; private set; }

    /// <summary>
    /// SalesOrderDescription of the DefaultDataOnline
    /// SalesOrderDescription الخاص بـ DefaultDataOnline
    /// </summary>
    public string SalesOrderDescription { get; private set; }

    /// <summary>
    /// ServiceNumber of the DefaultDataOnline
    /// ServiceNumber الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// BankNumber of the DefaultDataOnline
    /// BankNumber الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// RepCode of the DefaultDataOnline
    /// RepCode الخاص بـ DefaultDataOnline
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the DefaultDataOnline
    /// ColumnNumberShort الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CCode of the DefaultDataOnline
    /// CCode الخاص بـ DefaultDataOnline
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the DefaultDataOnline
    /// CalcTypeNumberTax الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CGroupCode of the DefaultDataOnline
    /// CGroupCode الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// LevelNumber of the DefaultDataOnline
    /// LevelNumber الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ShowSystemType of the DefaultDataOnline
    /// ShowSystemType الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? ShowSystemType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to SalesOrderType
    /// </summary>
    public SalesOrderType SalesOrderType { get; private set; }
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
