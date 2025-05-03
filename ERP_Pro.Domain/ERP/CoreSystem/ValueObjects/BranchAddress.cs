using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents a branch's address information
/// يمثل معلومات عنوان الفرع
/// </summary>
public class BranchAddress : ValueObject
{
    /// <summary>
    /// العنوان التفصيلي
    /// Detailed address
    /// </summary>
    public string Street { get; private set; }

    /// <summary>
    /// المنطقة
    /// District
    /// </summary>
    public string District { get; private set; }

    /// <summary>
    /// صندوق البريد باللغة المحلية
    /// P.O. Box in local language
    /// </summary>
    public string LocalizedPostalBox { get; private set; } // BRN_LBOX

    /// <summary>
    /// صندوق البريد باللغة الأجنبية
    /// P.O. Box in foreign language
    /// </summary>
    public string ForeignPostalBox { get; private set; } // BRN_FBOX

    /// <summary>
    /// الدولة
    /// Country
    /// </summary>
    public int? CountryId { get; private set; } // CNTRY_NO

    /// <summary>
    /// المحافظة
    /// Province
    /// </summary>
    public int? ProvinceId { get; private set; } // PROV_NO

    /// <summary>
    /// المدينة
    /// City
    /// </summary>
    public int? CityId { get; private set; } // CITY_NO

    /// <summary>
    /// المنطقة
    /// Region
    /// </summary>
    public int? RegionId { get; private set; } // R_CODE

    private BranchAddress() { } // For EF Core

    public BranchAddress(
        string street,
        string district,
        string localizedPostalBox,
        string foreignPostalBox,
        int? countryId,
        int? provinceId,
        int? cityId,
        int? regionId)
    {
        if (string.IsNullOrWhiteSpace(street))
            throw new ArgumentException("Street cannot be empty", nameof(street));

        Street = street;
        District = district;
        LocalizedPostalBox = localizedPostalBox;
        ForeignPostalBox = foreignPostalBox;
        CountryId = countryId;
        ProvinceId = provinceId;
        CityId = cityId;
        RegionId = regionId;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street;
        yield return District;
        yield return LocalizedPostalBox;
        yield return ForeignPostalBox;
        yield return CountryId;
        yield return ProvinceId;
        yield return CityId;
        yield return RegionId;
    }
} 