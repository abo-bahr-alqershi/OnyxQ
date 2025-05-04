using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PointTypeReplacementDetail Entity
/// </summary>
public class PointTypeReplacementDetail : Entity<PointTypeReplacementDetailId>
{
    private PointTypeReplacementDetail() { }

    /// <summary>
    /// The unique identifier for the PointTypeReplacementDetail
    /// المعرف الفريد لـ PointTypeReplacementDetail
    /// </summary>
    public PointTypeReplacementDetailId Id { get; private set; }

    /// <summary>
    /// PointTypeNumber of the PointTypeReplacementDetail
    /// PointTypeNumber الخاص بـ PointTypeReplacementDetail
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// Amount of the PointTypeReplacementDetail
    /// Amount الخاص بـ PointTypeReplacementDetail
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// FromPoint of the PointTypeReplacementDetail
    /// FromPoint الخاص بـ PointTypeReplacementDetail
    /// </summary>
    public decimal? FromPoint { get; private set; }

    /// <summary>
    /// ToPoint of the PointTypeReplacementDetail
    /// ToPoint الخاص بـ PointTypeReplacementDetail
    /// </summary>
    public decimal? ToPoint { get; private set; }

    /// <summary>
    /// RecordNumber of the PointTypeReplacementDetail
    /// RecordNumber الخاص بـ PointTypeReplacementDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to PointTypeMaster
    /// </summary>
    public PointTypeMaster PointTypeMaster { get; private set; }
    #endregion
}
}
