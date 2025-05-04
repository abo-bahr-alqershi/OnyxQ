using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PointTypeCalculationDetail Entity
/// </summary>
public class PointTypeCalculationDetail : Entity<PointTypeCalculationDetailId>
{

    private PointTypeCalculationDetail() { }

    public PointTypeCalculationDetail(PointTypeCalculationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PointTypeCalculationDetail
    /// المعرف الفريد لـ PointTypeCalculationDetail
    /// </summary>
    public PointTypeCalculationDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the PointTypeCalculationDetail
    /// RecordNumber الخاص بـ PointTypeCalculationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// FromAmount of the PointTypeCalculationDetail
    /// FromAmount الخاص بـ PointTypeCalculationDetail
    /// </summary>
    public decimal? FromAmount { get; private set; }

    /// <summary>
    /// ToAmount of the PointTypeCalculationDetail
    /// ToAmount الخاص بـ PointTypeCalculationDetail
    /// </summary>
    public decimal? ToAmount { get; private set; }

    /// <summary>
    /// PointCount of the PointTypeCalculationDetail
    /// PointCount الخاص بـ PointTypeCalculationDetail
    /// </summary>
    public decimal? PointCount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PointTypeMaster PointTypeMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
