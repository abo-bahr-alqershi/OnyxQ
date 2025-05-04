using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// Measurement Entity
/// </summary>
public class Measurement : Entity<MeasurementId>
{

    private Measurement() { }

    public Measurement(MeasurementId id, string measureCode)
    {
        Id = id;
        MeasureCode = measureCode;
    }

    /// <summary>
    /// The unique identifier for the Measurement
    /// المعرف الفريد لـ Measurement
    /// </summary>
    public MeasurementId Id { get; private set; }

    /// <summary>
    /// MeasureCode of the Measurement
    /// MeasureCode الخاص بـ Measurement
    /// </summary>
    public string MeasureCode { get; private set; }

    /// <summary>
    /// Measure of the Measurement
    /// Measure الخاص بـ Measurement
    /// </summary>
    public string Measure { get; private set; }

    /// <summary>
    /// MeasureFirstName of the Measurement
    /// MeasureFirstName الخاص بـ Measurement
    /// </summary>
    public string MeasureFirstName { get; private set; }

    /// <summary>
    /// MeasureType of the Measurement
    /// MeasureType الخاص بـ Measurement
    /// </summary>
    public decimal? MeasureType { get; private set; }

    /// <summary>
    /// MeasureWeightType of the Measurement
    /// MeasureWeightType الخاص بـ Measurement
    /// </summary>
    public decimal? MeasureWeightType { get; private set; }

    /// <summary>
    /// MeasureWeightConnection of the Measurement
    /// MeasureWeightConnection الخاص بـ Measurement
    /// </summary>
    public decimal? MeasureWeightConnection { get; private set; }

    /// <summary>
    /// DfltSize of the Measurement
    /// DfltSize الخاص بـ Measurement
    /// </summary>
    public decimal? DfltSize { get; private set; }

    /// <summary>
    /// AllowUpdate of the Measurement
    /// AllowUpdate الخاص بـ Measurement
    /// </summary>
    public decimal? AllowUpdate { get; private set; }

    /// <summary>
    /// MeasureCodeGb of the Measurement
    /// MeasureCodeGb الخاص بـ Measurement
    /// </summary>
    public string MeasureCodeGb { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
