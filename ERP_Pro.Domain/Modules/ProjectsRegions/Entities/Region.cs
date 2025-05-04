using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.TransportationShipping.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Region Entity
/// </summary>
public class Region : Entity<RegionId>
{

    private Region() { }

    public Region(RegionId id, decimal? regionCode)
    {
        Id = id;
        RegionCode = regionCode;
    }

    /// <summary>
    /// The unique identifier for the Region
    /// المعرف الفريد لـ Region
    /// </summary>
    public RegionId Id { get; private set; }

    /// <summary>
    /// RegionCode of the Region
    /// RegionCode الخاص بـ Region
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RegionNameArabic of the Region
    /// RegionNameArabic الخاص بـ Region
    /// </summary>
    public string RegionNameArabic { get; private set; }

    /// <summary>
    /// RegionNameEnglish of the Region
    /// RegionNameEnglish الخاص بـ Region
    /// </summary>
    public string RegionNameEnglish { get; private set; }

    /// <summary>
    /// CountryNumber of the Region
    /// CountryNumber الخاص بـ Region
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Region
    /// ProvinceNumber الخاص بـ Region
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// RegionShort of the Region
    /// RegionShort الخاص بـ Region
    /// </summary>
    public string RegionShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Zone Zone { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
