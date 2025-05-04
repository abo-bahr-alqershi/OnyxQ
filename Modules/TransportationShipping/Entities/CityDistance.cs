using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Entities
{
/// <summary>
/// CityDistance Entity
/// </summary>
public class CityDistance : Entity<CityDistanceId>
{
    private CityDistance() { }

    /// <summary>
    /// The unique identifier for the CityDistance
    /// المعرف الفريد لـ CityDistance
    /// </summary>
    public CityDistanceId Id { get; private set; }

    /// <summary>
    /// FCityNumber of the CityDistance
    /// FCityNumber الخاص بـ CityDistance
    /// </summary>
    public decimal? FCityNumber { get; private set; }

    /// <summary>
    /// TCityNumber of the CityDistance
    /// TCityNumber الخاص بـ CityDistance
    /// </summary>
    public decimal? TCityNumber { get; private set; }

    /// <summary>
    /// DistDay of the CityDistance
    /// DistDay الخاص بـ CityDistance
    /// </summary>
    public decimal? DistDay { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CityDistance
    /// CompanyNumberShort الخاص بـ CityDistance
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CityDistance
    /// BranchNumber الخاص بـ CityDistance
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CityDistance
    /// BranchYear الخاص بـ CityDistance
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CityDistance
    /// BranchUser الخاص بـ CityDistance
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
