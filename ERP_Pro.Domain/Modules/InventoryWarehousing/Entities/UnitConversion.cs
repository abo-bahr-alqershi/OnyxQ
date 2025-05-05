using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// UnitConversion Entity
/// </summary>
public class UnitConversion : Entity<UnitConversionId>
{

    private UnitConversion() { }

    public UnitConversion(UnitConversionId id, string measureManualCode, string measureObservationCode)
    {
        Id = id;
        MeasureManualCode = measureManualCode;
        MeasureObservationCode = measureObservationCode;
    }

    /// <summary>
    /// The unique identifier for the UnitConversion
    /// المعرف الفريد لـ UnitConversion
    /// </summary>
    public UnitConversionId Id { get; private set; }

    /// <summary>
    /// MeasureManualNumber of the UnitConversion
    /// MeasureManualNumber الخاص بـ UnitConversion
    /// </summary>
    public decimal? MeasureManualNumber { get; private set; }

    /// <summary>
    /// MeasureManualCode of the UnitConversion
    /// MeasureManualCode الخاص بـ UnitConversion
    /// </summary>
    public string MeasureManualCode { get; private set; }

    /// <summary>
    /// MeasureObservationCode of the UnitConversion
    /// MeasureObservationCode الخاص بـ UnitConversion
    /// </summary>
    public string MeasureObservationCode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the UnitConversion
    /// ArgumentNumber الخاص بـ UnitConversion
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

