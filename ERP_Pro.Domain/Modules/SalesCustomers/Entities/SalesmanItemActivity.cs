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

    public SalesmanItemActivity(SalesmanItemActivityId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanItemActivity
    /// المعرف الفريد لـ SalesmanItemActivity
    /// </summary>
    public SalesmanItemActivityId Id { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemActivity ItemActivity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
