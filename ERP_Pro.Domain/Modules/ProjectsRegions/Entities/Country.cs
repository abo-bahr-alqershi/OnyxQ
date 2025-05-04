using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Country Entity
/// </summary>
public class Country : Entity<CountryId>
{

    private Country() { }

    public Country(CountryId id, decimal? countryNumber)
    {
        Id = id;
        CountryNumber = countryNumber;
    }

    /// <summary>
    /// The unique identifier for the Country
    /// المعرف الفريد لـ Country
    /// </summary>
    public CountryId Id { get; private set; }

    /// <summary>
    /// CountryNumber of the Country
    /// CountryNumber الخاص بـ Country
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CountryNameArabic of the Country
    /// CountryNameArabic الخاص بـ Country
    /// </summary>
    public string CountryNameArabic { get; private set; }

    /// <summary>
    /// CountryNameEnglish of the Country
    /// CountryNameEnglish الخاص بـ Country
    /// </summary>
    public string CountryNameEnglish { get; private set; }

    /// <summary>
    /// CountryShortName of the Country
    /// CountryShortName الخاص بـ Country
    /// </summary>
    public string CountryShortName { get; private set; }

    /// <summary>
    /// CountryContinent of the Country
    /// CountryContinent الخاص بـ Country
    /// </summary>
    public string CountryContinent { get; private set; }

    /// <summary>
    /// CurNo of the Country
    /// CurNo الخاص بـ Country
    /// </summary>
    public decimal? CurNo { get; private set; }

    /// <summary>
    /// CurCode of the Country
    /// CurCode الخاص بـ Country
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CountryAntion of the Country
    /// CountryAntion الخاص بـ Country
    /// </summary>
    public string CountryAntion { get; private set; }

    /// <summary>
    /// CountryEntion of the Country
    /// CountryEntion الخاص بـ Country
    /// </summary>
    public string CountryEntion { get; private set; }

    /// <summary>
    /// NationShortName of the Country
    /// NationShortName الخاص بـ Country
    /// </summary>
    public string NationShortName { get; private set; }

    /// <summary>
    /// NotAllowDealWithFlag of the Country
    /// NotAllowDealWithFlag الخاص بـ Country
    /// </summary>
    public decimal? NotAllowDealWithFlag { get; private set; }

    /// <summary>
    /// PhoneKey of the Country
    /// PhoneKey الخاص بـ Country
    /// </summary>
    public string PhoneKey { get; private set; }

    #region Navigation Properties
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
