using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// يمثل هذا النموذج الموقع الجغرافي
/// Represents a geographical location
/// </summary>
public class GeoLocation : ValueObject
{
    /// <summary>
    /// خط العرض
    /// Latitude
    /// </summary>
    public decimal Latitude { get; private set; }

    /// <summary>
    /// خط الطول
    /// Longitude
    /// </summary>
    public decimal Longitude { get; private set; }

    private GeoLocation() { } // Required by EF Core

    public GeoLocation(decimal latitude, decimal longitude)
    {
        if (latitude < -90 || latitude > 90)
            throw new ArgumentException("Latitude must be between -90 and 90 degrees", nameof(latitude));

        if (longitude < -180 || longitude > 180)
            throw new ArgumentException("Longitude must be between -180 and 180 degrees", nameof(longitude));

        Latitude = latitude;
        Longitude = longitude;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Latitude;
        yield return Longitude;
    }

    /// <summary>
    /// حساب المسافة بين موقعين جغرافيين باستخدام صيغة هافرساين
    /// Calculate distance between two geographical locations using Haversine formula
    /// </summary>
    public decimal CalculateDistance(GeoLocation other)
    {
        const double earthRadiusKm = 6371;

        var dLat = ToRadian((double)(other.Latitude - Latitude));
        var dLon = ToRadian((double)(other.Longitude - Longitude));

        var lat1 = ToRadian((double)Latitude);
        var lat2 = ToRadian((double)other.Latitude);

        var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        var c = 2 * Math.Asin(Math.Sqrt(a));

        return (decimal)(earthRadiusKm * c);
    }

    private static double ToRadian(double degree)
    {
        return degree * Math.PI / 180;
    }
} 