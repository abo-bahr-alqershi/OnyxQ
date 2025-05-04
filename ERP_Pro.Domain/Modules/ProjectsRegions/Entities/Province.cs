using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Province Entity
/// </summary>
public class Province : Entity<ProvinceId>
{

    private Province() { }

    public Province(ProvinceId id, decimal? provinceNumber)
    {
        Id = id;
        ProvinceNumber = provinceNumber;
    }

    /// <summary>
    /// The unique identifier for the Province
    /// المعرف الفريد لـ Province
    /// </summary>
    public ProvinceId Id { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Province
    /// ProvinceNumber الخاص بـ Province
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// ProvinceNameArabic of the Province
    /// ProvinceNameArabic الخاص بـ Province
    /// </summary>
    public string ProvinceNameArabic { get; private set; }

    /// <summary>
    /// ProvinceNameEnglish of the Province
    /// ProvinceNameEnglish الخاص بـ Province
    /// </summary>
    public string ProvinceNameEnglish { get; private set; }

    /// <summary>
    /// ProvinceShort of the Province
    /// ProvinceShort الخاص بـ Province
    /// </summary>
    public string ProvinceShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Country Country { get; private set; }
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
