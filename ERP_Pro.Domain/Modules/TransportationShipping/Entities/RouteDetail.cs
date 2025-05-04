using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Entities
{
/// <summary>
/// RouteDetail Entity
/// </summary>
public class RouteDetail : Entity<RouteDetailId>
{
    private readonly List<RouteMaster> _routeMaster = new List<RouteMaster>();
    private readonly List<Region> _region = new List<Region>();

    private RouteDetail() { }

    public RouteDetail(RouteDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the RouteDetail
    /// المعرف الفريد لـ RouteDetail
    /// </summary>
    public RouteDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the RouteDetail
    /// RecordNumber الخاص بـ RouteDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<RouteMaster> RouteMaster => _routeMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Region> Region => _region;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
