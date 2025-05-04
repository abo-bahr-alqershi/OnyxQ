using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// RegionSalesman Entity
/// </summary>
public class RegionSalesman : Entity<RegionSalesmanId>
{

    private RegionSalesman() { }

    public RegionSalesman(RegionSalesmanId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the RegionSalesman
    /// المعرف الفريد لـ RegionSalesman
    /// </summary>
    public RegionSalesmanId Id { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Promoter Promoter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Region Region { get; private set; }
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
