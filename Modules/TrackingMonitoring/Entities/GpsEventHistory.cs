using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// GpsEventHistory Entity
/// </summary>
public class GpsEventHistory : Entity<GpsEventHistoryId>
{
    private GpsEventHistory() { }

    /// <summary>
    /// The unique identifier for the GpsEventHistory
    /// المعرف الفريد لـ GpsEventHistory
    /// </summary>
    public GpsEventHistoryId Id { get; private set; }

    /// <summary>
    /// DocSer of the GpsEventHistory
    /// DocSer الخاص بـ GpsEventHistory
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// SalesmanTypeShort of the GpsEventHistory
    /// SalesmanTypeShort الخاص بـ GpsEventHistory
    /// </summary>
    public decimal? SalesmanTypeShort { get; private set; }

    /// <summary>
    /// RepCode of the GpsEventHistory
    /// RepCode الخاص بـ GpsEventHistory
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ServiceStatus of the GpsEventHistory
    /// ServiceStatus الخاص بـ GpsEventHistory
    /// </summary>
    public decimal? ServiceStatus { get; private set; }

    /// <summary>
    /// DeviceStat of the GpsEventHistory
    /// DeviceStat الخاص بـ GpsEventHistory
    /// </summary>
    public decimal? DeviceStat { get; private set; }

    /// <summary>
    /// GpsLatitudeYShort of the GpsEventHistory
    /// GpsLatitudeYShort الخاص بـ GpsEventHistory
    /// </summary>
    public string GpsLatitudeYShort { get; private set; }

    /// <summary>
    /// GpsLongitudeXShort of the GpsEventHistory
    /// GpsLongitudeXShort الخاص بـ GpsEventHistory
    /// </summary>
    public string GpsLongitudeXShort { get; private set; }

    /// <summary>
    /// GpsLastDate of the GpsEventHistory
    /// GpsLastDate الخاص بـ GpsEventHistory
    /// </summary>
    public DateTime? GpsLastDate { get; private set; }

    /// <summary>
    /// GpsLastServerDate of the GpsEventHistory
    /// GpsLastServerDate الخاص بـ GpsEventHistory
    /// </summary>
    public DateTime? GpsLastServerDate { get; private set; }
}
}
