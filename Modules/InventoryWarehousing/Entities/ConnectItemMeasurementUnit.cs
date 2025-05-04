using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ConnectItemMeasurementUnit Entity
/// </summary>
public class ConnectItemMeasurementUnit : Entity<ConnectItemMeasurementUnitId>
{
    private ConnectItemMeasurementUnit() { }

    /// <summary>
    /// The unique identifier for the ConnectItemMeasurementUnit
    /// المعرف الفريد لـ ConnectItemMeasurementUnit
    /// </summary>
    public ConnectItemMeasurementUnitId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ConnectItemMeasurementUnit
    /// ItemCode الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ConnectItemMeasurementUnit
    /// ItemUnit الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ConnectItemMeasurementUnit
    /// PSize الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// DfltUnit of the ConnectItemMeasurementUnit
    /// DfltUnit الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public decimal? DfltUnit { get; private set; }

    /// <summary>
    /// MeasureWeightCode of the ConnectItemMeasurementUnit
    /// MeasureWeightCode الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public string MeasureWeightCode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the ConnectItemMeasurementUnit
    /// ArgumentNumber الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// MeasureQuantityCode of the ConnectItemMeasurementUnit
    /// MeasureQuantityCode الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public string MeasureQuantityCode { get; private set; }

    /// <summary>
    /// MinUnit of the ConnectItemMeasurementUnit
    /// MinUnit الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public decimal? MinUnit { get; private set; }

    /// <summary>
    /// Factor of the ConnectItemMeasurementUnit
    /// Factor الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public string Factor { get; private set; }

    /// <summary>
    /// UseFraction of the ConnectItemMeasurementUnit
    /// UseFraction الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public decimal? UseFraction { get; private set; }

    /// <summary>
    /// UpdateFlag of the ConnectItemMeasurementUnit
    /// UpdateFlag الخاص بـ ConnectItemMeasurementUnit
    /// </summary>
    public decimal? UpdateFlag { get; private set; }
}
}
