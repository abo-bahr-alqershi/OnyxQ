using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// AlertSystemDetail Entity
/// </summary>
public class AlertSystemDetail : Entity<AlertSystemDetailId>
{

    private AlertSystemDetail() { }

    public AlertSystemDetail(AlertSystemDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AlertSystemDetail
    /// المعرف الفريد لـ AlertSystemDetail
    /// </summary>
    public AlertSystemDetailId Id { get; private set; }

    /// <summary>
    /// AlertSelect of the AlertSystemDetail
    /// AlertSelect الخاص بـ AlertSystemDetail
    /// </summary>
    public string AlertSelect { get; private set; }

    /// <summary>
    /// AlertSelectWhere of the AlertSystemDetail
    /// AlertSelectWhere الخاص بـ AlertSystemDetail
    /// </summary>
    public string AlertSelectWhere { get; private set; }

    /// <summary>
    /// AlertSelectOrder of the AlertSystemDetail
    /// AlertSelectOrder الخاص بـ AlertSystemDetail
    /// </summary>
    public string AlertSelectOrder { get; private set; }

    /// <summary>
    /// AlertGroupBy of the AlertSystemDetail
    /// AlertGroupBy الخاص بـ AlertSystemDetail
    /// </summary>
    public string AlertGroupBy { get; private set; }

    /// <summary>
    /// FieldCount of the AlertSystemDetail
    /// FieldCount الخاص بـ AlertSystemDetail
    /// </summary>
    public decimal? FieldCount { get; private set; }

    /// <summary>
    /// FieldLabel of the AlertSystemDetail
    /// FieldLabel الخاص بـ AlertSystemDetail
    /// </summary>
    public string FieldLabel { get; private set; }

    /// <summary>
    /// FieldWidth of the AlertSystemDetail
    /// FieldWidth الخاص بـ AlertSystemDetail
    /// </summary>
    public string FieldWidth { get; private set; }

    /// <summary>
    /// FieldDirection of the AlertSystemDetail
    /// FieldDirection الخاص بـ AlertSystemDetail
    /// </summary>
    public string FieldDirection { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: OneToOne
    /// </summary>
    public AlertSystemMaster AlertSystemMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
