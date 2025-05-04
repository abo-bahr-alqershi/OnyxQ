using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// Zone Entity
/// </summary>
public class Zone : Entity<ZoneId>
{

    private Zone() { }

    public Zone(ZoneId id, decimal? zoneNumber)
    {
        Id = id;
        ZoneNumber = zoneNumber;
    }

    /// <summary>
    /// The unique identifier for the Zone
    /// المعرف الفريد لـ Zone
    /// </summary>
    public ZoneId Id { get; private set; }

    /// <summary>
    /// ZoneNumber of the Zone
    /// ZoneNumber الخاص بـ Zone
    /// </summary>
    public decimal? ZoneNumber { get; private set; }

    /// <summary>
    /// ZoneLastName of the Zone
    /// ZoneLastName الخاص بـ Zone
    /// </summary>
    public string ZoneLastName { get; private set; }

    /// <summary>
    /// ZoneFirstName of the Zone
    /// ZoneFirstName الخاص بـ Zone
    /// </summary>
    public string ZoneFirstName { get; private set; }

    /// <summary>
    /// ZoneShort of the Zone
    /// ZoneShort الخاص بـ Zone
    /// </summary>
    public string ZoneShort { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
