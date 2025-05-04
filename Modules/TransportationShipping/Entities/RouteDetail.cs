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
    private RouteDetail() { }

    /// <summary>
    /// The unique identifier for the RouteDetail
    /// المعرف الفريد لـ RouteDetail
    /// </summary>
    public RouteDetailId Id { get; private set; }

    /// <summary>
    /// RouteNumber of the RouteDetail
    /// RouteNumber الخاص بـ RouteDetail
    /// </summary>
    public decimal? RouteNumber { get; private set; }

    /// <summary>
    /// RegionCode of the RouteDetail
    /// RegionCode الخاص بـ RouteDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RecordNumber of the RouteDetail
    /// RecordNumber الخاص بـ RouteDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to RouteMaster
    /// </summary>
    public RouteMaster RouteMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    #endregion
}
}
