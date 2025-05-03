using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents a company's address information
/// يمثل معلومات عنوان الشركة
/// </summary>
public class CompanyAddress : ValueObject
{
    /// <summary>
    /// العنوان التفصيلي
    /// Detailed address
    /// </summary>
    public string Street { get; private set; }

    /// <summary>
    /// المدينة
    /// City
    /// </summary>
    public string District { get; private set; }

    /// <summary>
    /// الرمز البريدي
    /// Postal code
    /// </summary>
    public string PostalCode { get; private set; }

    /// <summary>
    /// الدولة
    /// Country
    /// </summary>
    public int? CountryId { get; private set; }

    /// <summary>
    /// المدينة
    /// City
    /// </summary>
    public int? CityId { get; private set; }

    /// <summary>
    /// المنطقة/المحافظة
    /// Region/Province
    /// </summary>
    public int? RegionId { get; private set; }

    /// <summary>
    /// المنطقة/المحافظة
    /// Region/Province
    /// </summary>
    public int? ProvinceId { get; private set; }

    private CompanyAddress() { } // For EF Core

    public CompanyAddress(
        string street,
        string district,
        string postalCode,
        int? countryId,
        int? cityId,
        int? regionId,
        int? provinceId)
    {
        if (string.IsNullOrWhiteSpace(street))
            throw new ArgumentException("Street cannot be empty", nameof(street));
        
        if (string.IsNullOrWhiteSpace(district))
            throw new ArgumentException("District cannot be empty", nameof(district));
        
        if (string.IsNullOrWhiteSpace(postalCode))
            throw new ArgumentException("Postal code cannot be empty", nameof(postalCode));

        Street = street;
        District = district;
        PostalCode = postalCode;
        CountryId = countryId;
        CityId = cityId;
        RegionId = regionId;
        ProvinceId = provinceId;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street;
        yield return District;
        yield return PostalCode;
        yield return CountryId;
        yield return CityId;
        yield return RegionId;
        yield return ProvinceId;
    }
} 