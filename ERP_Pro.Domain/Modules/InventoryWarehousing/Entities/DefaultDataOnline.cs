using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// DefaultDataOnline Entity
/// </summary>
public class DefaultDataOnline : Entity<DefaultDataOnlineId>
{

    private DefaultDataOnline() { }

    public DefaultDataOnline(DefaultDataOnlineId id, decimal? dfltNo, decimal? showSystemType)
    {
        Id = id;
        DfltNo = dfltNo;
        ShowSystemType = showSystemType;
    }

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
    /// WarehouseCode of the DefaultDataOnline
    /// WarehouseCode الخاص بـ DefaultDataOnline
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public SalesOrderType SalesOrderType { get; private set; }
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

