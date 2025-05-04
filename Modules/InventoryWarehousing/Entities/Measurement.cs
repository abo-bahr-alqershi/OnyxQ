using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// Measurement Entity
/// </summary>
public class Measurement : Entity<MeasurementId>
{
    private Measurement() { }

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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Measurement to SalesmanCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCommissionSetupDetail> SalesmanCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Measurement to EmployeeCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<EmployeeCommissionSetupDetail> EmployeeCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Measurement to ItemDetail
    /// </summary>
    public IReadOnlyCollection<ItemDetail> ItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Measurement to ItemMaster
    /// </summary>
    public IReadOnlyCollection<ItemMaster> ItemMasters { get; private set; }
    #endregion
}
}
