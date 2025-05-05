using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// City Entity
/// </summary>
public class City : Entity<CityId>
{

    private City() { }

    public City(CityId id, decimal? cityNumber)
    {
        Id = id;
        CityNumber = cityNumber;
    }

    /// <summary>
    /// The unique identifier for the City
    /// المعرف الفريد لـ City
    /// </summary>
    public CityId Id { get; private set; }

    /// <summary>
    /// CityNumber of the City
    /// CityNumber الخاص بـ City
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// CityNameArabic of the City
    /// CityNameArabic الخاص بـ City
    /// </summary>
    public string CityNameArabic { get; private set; }

    /// <summary>
    /// CityNameEnglish of the City
    /// CityNameEnglish الخاص بـ City
    /// </summary>
    public string CityNameEnglish { get; private set; }

    /// <summary>
    /// CityShortName of the City
    /// CityShortName الخاص بـ City
    /// </summary>
    public string CityShortName { get; private set; }

    /// <summary>
    /// CitySerial of the City
    /// CitySerial الخاص بـ City
    /// </summary>
    public decimal? CitySerial { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Province Province { get; private set; }
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

