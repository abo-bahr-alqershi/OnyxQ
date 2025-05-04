using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationFuelType Entity
/// </summary>
public class StationFuelType : Entity<StationFuelTypeId>
{

    private StationFuelType() { }

    public StationFuelType(StationFuelTypeId id, decimal? fuelTypeNumber)
    {
        Id = id;
        FuelTypeNumber = fuelTypeNumber;
    }

    /// <summary>
    /// The unique identifier for the StationFuelType
    /// المعرف الفريد لـ StationFuelType
    /// </summary>
    public StationFuelTypeId Id { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationFuelType
    /// FuelTypeNumber الخاص بـ StationFuelType
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    /// <summary>
    /// FuelTypeNameArabic of the StationFuelType
    /// FuelTypeNameArabic الخاص بـ StationFuelType
    /// </summary>
    public string FuelTypeNameArabic { get; private set; }

    /// <summary>
    /// FuelTypeFirstName of the StationFuelType
    /// FuelTypeFirstName الخاص بـ StationFuelType
    /// </summary>
    public string FuelTypeFirstName { get; private set; }

    /// <summary>
    /// ItemCode of the StationFuelType
    /// ItemCode الخاص بـ StationFuelType
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the StationFuelType
    /// ItemUnit الخاص بـ StationFuelType
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// AccountCurrency of the StationFuelType
    /// AccountCurrency الخاص بـ StationFuelType
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// ItemPriceShort of the StationFuelType
    /// ItemPriceShort الخاص بـ StationFuelType
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
