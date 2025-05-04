using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Entities
{
/// <summary>
/// RouteMaster Entity
/// </summary>
public class RouteMaster : Entity<RouteMasterId>
{
    private RouteMaster() { }

    /// <summary>
    /// The unique identifier for the RouteMaster
    /// المعرف الفريد لـ RouteMaster
    /// </summary>
    public RouteMasterId Id { get; private set; }

    /// <summary>
    /// RouteNumber of the RouteMaster
    /// RouteNumber الخاص بـ RouteMaster
    /// </summary>
    public decimal? RouteNumber { get; private set; }

    /// <summary>
    /// RouteNameArabic of the RouteMaster
    /// RouteNameArabic الخاص بـ RouteMaster
    /// </summary>
    public string RouteNameArabic { get; private set; }

    /// <summary>
    /// RouteNameEnglish of the RouteMaster
    /// RouteNameEnglish الخاص بـ RouteMaster
    /// </summary>
    public string RouteNameEnglish { get; private set; }

    /// <summary>
    /// CountryNumber of the RouteMaster
    /// CountryNumber الخاص بـ RouteMaster
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the RouteMaster
    /// ProvinceNumber الخاص بـ RouteMaster
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the RouteMaster
    /// CityNumber الخاص بـ RouteMaster
    /// </summary>
    public decimal? CityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: RouteMaster to RouteDetail
    /// </summary>
    public IReadOnlyCollection<RouteDetail> RouteDetails { get; private set; }
    #endregion
}
}
