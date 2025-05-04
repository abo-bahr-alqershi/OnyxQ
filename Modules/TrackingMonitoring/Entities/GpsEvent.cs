using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// GpsEvent Entity
/// </summary>
public class GpsEvent : Entity<GpsEventId>
{
    private GpsEvent() { }

    /// <summary>
    /// The unique identifier for the GpsEvent
    /// المعرف الفريد لـ GpsEvent
    /// </summary>
    public GpsEventId Id { get; private set; }

    /// <summary>
    /// SalesmanTypeShort of the GpsEvent
    /// SalesmanTypeShort الخاص بـ GpsEvent
    /// </summary>
    public decimal? SalesmanTypeShort { get; private set; }

    /// <summary>
    /// RepCode of the GpsEvent
    /// RepCode الخاص بـ GpsEvent
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// GpsLatitudeYShort of the GpsEvent
    /// GpsLatitudeYShort الخاص بـ GpsEvent
    /// </summary>
    public string GpsLatitudeYShort { get; private set; }

    /// <summary>
    /// GpsLongitudeXShort of the GpsEvent
    /// GpsLongitudeXShort الخاص بـ GpsEvent
    /// </summary>
    public string GpsLongitudeXShort { get; private set; }

    /// <summary>
    /// GpsLastDate of the GpsEvent
    /// GpsLastDate الخاص بـ GpsEvent
    /// </summary>
    public DateTime? GpsLastDate { get; private set; }

    /// <summary>
    /// SerialShort of the GpsEvent
    /// SerialShort الخاص بـ GpsEvent
    /// </summary>
    public decimal? SerialShort { get; private set; }
}
}
