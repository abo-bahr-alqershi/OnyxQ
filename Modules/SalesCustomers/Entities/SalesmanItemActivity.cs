using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanItemActivity Entity
/// </summary>
public class SalesmanItemActivity : Entity<SalesmanItemActivityId>
{
    private SalesmanItemActivity() { }

    /// <summary>
    /// The unique identifier for the SalesmanItemActivity
    /// المعرف الفريد لـ SalesmanItemActivity
    /// </summary>
    public SalesmanItemActivityId Id { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanItemActivity
    /// RepCode الخاص بـ SalesmanItemActivity
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the SalesmanItemActivity
    /// ActivityNumber الخاص بـ SalesmanItemActivity
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemActivity
    /// </summary>
    public ItemActivity ItemActivity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    #endregion
}
}
